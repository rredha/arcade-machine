using UnityEngine;
using System.Collections;
//using Arcade.Project.Runtime.Games.AngryBird.Cues;
using Arcade.Project.Runtime.Games.AngryBird.Configurations;
using Arcade.Project.Runtime.Games.AngryBird.Interfaces;

namespace Arcade.Project.Runtime.Games.AngryBird
{
  public class Rubber : MonoBehaviour
  {
    [SerializeField] private SlingshotConfiguration config;

    private LineRenderer leftLineRenderer;
    private LineRenderer rightLineRenderer;
    [SerializeField] private Transform leftRubber;
    [SerializeField] private Transform rightRubber;
    [SerializeField] private Transform center;
    [SerializeField] private Transform holder;
    //
    // set to property, with public getter.
    public Transform Holder;
    public Transform Center;
    public SlingshotConfiguration Config;

    private void Awake()
    {
      Holder = holder;
      Center = center;
      Config = config;

      leftLineRenderer = leftRubber.GetComponent<LineRenderer>();
      rightLineRenderer = rightRubber.GetComponent<LineRenderer>();
    }

    public void Init()
    {
      leftLineRenderer.positionCount = 2;
      rightLineRenderer.positionCount = 2;

      leftLineRenderer.SetPosition(0, leftRubber.position);
      rightLineRenderer.SetPosition(0, rightRubber.position);
    }

    public void Set(Vector3 position)
    {
      position = center.position + Vector3.ClampMagnitude(position - center.position, config.maxLength);
      position.y = Mathf.Clamp(position.y, config.bottomBoundary, 1000);

      leftLineRenderer.SetPosition(1, position);
      rightLineRenderer.SetPosition(1, position);

      // fix later, projectile position is the one that needs updating.
      holder.transform.position = position;
    }

    public void Reset()
    {
      Set(holder.position);
    }
  }
}
