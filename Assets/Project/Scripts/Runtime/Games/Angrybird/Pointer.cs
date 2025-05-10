using UnityEngine;
using UnityEngine.InputSystem;
using Arcade.Project.Runtime.Games.AngryBird.Cues;
using Arcade.Project.Runtime.Games.AngryBird.Interfaces;
using Arcade.Project.Runtime.Games.AngryBird.Utils.InputSystem;

namespace Arcade.Project.Runtime.Games.AngryBird
{
  public class Pointer : MonoBehaviour
  {
    [SerializeField] private IVisualCue changeColor;
    [SerializeField] private Collider2D _otherCollider;

    private Camera _camera;
    private Collider2D _collider;
    private SpriteRenderer _spriteRenderer;
    private Vector2 _pointerWorldPosition;
    private Vector2 _pointerScreenPosition;
    private PlayerInputActions _playerInputActions;

    private void Awake()
    {
      _camera = Camera.main;
      _collider = GetComponent<Collider2D>();
      _collider.isTrigger = true;
      _spriteRenderer = GetComponent<SpriteRenderer>();

      _playerInputActions = new PlayerInputActions();
      _playerInputActions.Player.Enable();
      _playerInputActions.Player.Move.performed += Move_performed;
    }

    private void FixedUpdate()
    {
      transform.position = _pointerWorldPosition;
      if (_collider.IsTouching(_otherCollider))
      {
        _spriteRenderer.color = Color.blue;
      }
    }

    private void Move_performed(InputAction.CallbackContext ctx)
    {
      // convert form screen to world position.
      _pointerWorldPosition = ScreenToWorldPosition(ctx.ReadValue<Vector2>());
    }

    private Vector3 ScreenToWorldPosition(Vector2 screenPosition)
    {
      var worldPosition = _camera.ScreenToWorldPoint(screenPosition);
      return new Vector3(worldPosition.x, worldPosition.y, 10);
    }
  }
}
