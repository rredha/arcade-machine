using UnityEngine;

namespace Arcade.Project.Runtime.Games.AngryBird
{
  public class GameManager : MonoBehaviour
  {
    public static GameManager Instance;
    [SerializeField] private Spawner Spawner;
    [SerializeField] private Transform CenterOfTheScreen;

    private void Awake()
    {
      StartCoroutine(Spawner.Spawn(CenterOfTheScreen, this.transform));
    }
  }
}
