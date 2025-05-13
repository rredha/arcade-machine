using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using Arcade.Project.Runtime.Games.AngryBird.Cues;
using Arcade.Project.Runtime.Games.AngryBird.Interfaces;
using Arcade.Project.Runtime.Games.AngryBird.Utils.InputSystem;

namespace Arcade.Project.Runtime.Games.AngryBird
{
  public class Pointer : MonoBehaviour
  {
    [SerializeField] private IVisualCue changeColorOnHover;
    [SerializeField] private IVisualCue changeColorOnSelection;

    private Camera _camera;
    private Collider2D _collider;
    private SpriteRenderer _spriteRenderer;
    private Vector3 _pointerWorldPosition;
    private Vector2 _pointerScreenPosition;
    private PlayerInputActions _playerInputActions;
    private Projectile proj;
    private Color _defaultColor;
    private LayerMask _layerMask;

    private void Awake()
    {
      _camera = Camera.main;
      _collider = GetComponent<Collider2D>();
      _collider.isTrigger = true;
      _spriteRenderer = GetComponent<SpriteRenderer>();
      _defaultColor = _spriteRenderer.color;
      _layerMask = LayerMask.GetMask("Selectables");

      _playerInputActions = new PlayerInputActions();
      _playerInputActions.Player.Enable();
      _playerInputActions.Player.Move.performed += Move_performed;
      _playerInputActions.Player.Select.performed += Select_performed;
      // dont forget to unsubscribe.
      //_playerInputActions.Player.Select.canceled += Select_canceled;
    }

    private void FixedUpdate()
    {
      transform.position = _pointerWorldPosition;
    }

    private void Select_performed(InputAction.CallbackContext ctx)
    {
      var collider = Physics2D.OverlapPoint(transform.position, _layerMask, -Mathf.Infinity, +Mathf.Infinity);
      if (collider == null) return;
      if (collider.TryGetComponent<Projectile>(out proj))
      {
        ChangeColor(Color.yellow);
        proj.SetStatic();
        proj.transform.SetParent(this.transform);
      }
    }

    /*
    private void Select_canceled(InputAction.CallbackContext ctx)
    {
      // bug : when entering the game and selecting, after the select is Move_performed -> object not set to an instance.
      // for now disabling this portion of code
      ResetColor();
      proj.SetDynamic();
      proj.transform.SetParent(null);
    }
    */

    private void Move_performed(InputAction.CallbackContext ctx)
    {
      // convert form screen to world position.
      _pointerWorldPosition = ScreenToWorldPosition(ctx.ReadValue<Vector2>());
    }

    private Vector3 ScreenToWorldPosition(Vector2 screenPosition)
    {
      var worldPosition = _camera.ScreenToWorldPoint(screenPosition);
      return new Vector3(worldPosition.x, worldPosition.y, 5);
    }

    private void ResetColor()
    {
        _spriteRenderer.color = _defaultColor;
    }

    private void ChangeColor(Color color)
    {
        _spriteRenderer.color = color;
    }
  }
}
