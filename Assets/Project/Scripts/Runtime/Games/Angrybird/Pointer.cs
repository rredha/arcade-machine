using UnityEngine;
using InputSystem;
using Arcade.Project.Runtime.Games.AngryBird.Cues;
using Arcade.Project.Runtime.Games.AngryBird.Interfaces;

namespace Arcade.Project.Runtime.Games.AngryBird
{
  public class Pointer : MonoBehaviour, IMovable
  {
    [SerializeField] private IVisualCue highlight;
    [SerializeField] private Collider2D otherCollider;

    private Camera _camera;
    private Collider2D _collider;
    private Vector3 _mousePosWorld;
    private Vector3 _mousePosScreen;

    private void Awake()
    {
      _camera = Camera.main;
      _collider = GetComponent<Collider2D>();
      _collider.isTrigger = true;
    }

    private void FixedUpdate()
    {
      Move();
    }

    public void Move()
    {
      _mousePosScreen = Input.mousePosition;
      if (_camera) _mousePosScreen.z = 10;
      _mousePosWorld = _camera.ScreenToWorldPoint(_mousePosScreen);

      transform.position = _mousePosWorld;
    }
  }
}
