using UnityEngine;
using UnityEngine.InputSystem;
using Arcade.Project.Runtime.Games.AngryBird;
using Arcade.Project.Runtime.Games.AngryBird.Cues;
using Arcade.Project.Runtime.Games.AngryBird.Interfaces;
using Arcade.Project.Runtime.Games.AngryBird.Configurations;
using Arcade.Project.Runtime.Games.AngryBird.Utils.InputSystem;

namespace Arcade.Project.Runtime.Games.AngryBird
{
  public class Slingshot : MonoBehaviour
  {
    private Rubber _rubber;

    private PlayerInputActions _playerInputActions;
    private Vector3 _pointerWorldPosition;
    private Vector2 _pointerScreenPosition;

    private Camera _camera;

    private Projectile proj;
    private Color _defaultColor;
    private LayerMask _layerMask;

    private void Awake()
    {
      _camera = Camera.main;
      _rubber = GetComponent<Rubber>();
      _playerInputActions = new PlayerInputActions();
      _playerInputActions.Player.Enable();
      _playerInputActions.Player.Move.performed += Move_performed;
      _playerInputActions.Player.Release.performed += Release_performed;

      _layerMask = LayerMask.GetMask("Selectables");
    }

    private void Start()
    {
      _rubber.Init();
    }


    private void FixedUpdate()
    {
      _rubber.Reset();

      // state pattern needed.
      var collider = Physics2D.OverlapPoint(_rubber.Holder.position, _layerMask, -Mathf.Infinity, +Mathf.Infinity);
      if (collider != null)
      {
        proj = collider.GetComponentInChildren<Projectile>();
        if (proj != null)
        {
          // if not using the release from select action.
          // else in select action performed, drop the projectile in the placeholder.
          proj.transform.SetParent(_rubber.Holder.transform);
          _rubber.Set(_pointerWorldPosition);
        }
      }
    }


    private void Release_performed(InputAction.CallbackContext ctx)
    {
      if (proj != null)
      {
        Shoot();
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
      return new Vector3(worldPosition.x, worldPosition.y, 0);
    }

    private void Shoot()
    {
      proj.SetDynamic();
      proj.Rb.linearVelocity = (_pointerWorldPosition - _rubber.Center.position) * _rubber.Config.force * -1;
    }
  }
}
