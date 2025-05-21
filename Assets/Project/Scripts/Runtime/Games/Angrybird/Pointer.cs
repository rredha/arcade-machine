using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.InputSystem.Controls;
using Arcade.Project.Runtime.Games.AngryBird.Cues;
using Arcade.Project.Runtime.Games.AngryBird.Interfaces;
using Arcade.Project.Runtime.Games.AngryBird.Utils.InputSystem;
using Arcade.Project.Runtime.Games.AngryBird.Configurations;

namespace Arcade.Project.Runtime.Games.AngryBird
{
  public class Pointer : MonoBehaviour
  {
    //private IVisualCue _changeColor;
    //[SerializeField] private ColorChangeCueConfiguration _config;
    private List<IVisualHint> _colorChangeHints = new List<IVisualHint>();

    private Camera _camera;
    private Color _defaultColor;
    private LayerMask _layerMask;

    private Collider2D _collider;
    private SpriteRenderer _spriteRenderer;

    private Vector3 _pointerWorldPosition;
    private Vector2 _pointerScreenPosition;

    private PlayerInputActions _playerInputActions;

    private Projectile proj;

    private void Awake()
    {
      _camera = Camera.main;
      _collider = GetComponent<Collider2D>();
      _collider.isTrigger = true;
      _spriteRenderer = GetComponent<SpriteRenderer>();
      _layerMask = LayerMask.GetMask("Selectables");

      // it work but it need to be implemented using IEnumerator
      _colorChangeHints.Add(new ColorChangeHintFactory().CreateVisualHint());
      _colorChangeHints.Add(new ColorChangeWithDelayFactory().CreateVisualHint());
      _colorChangeHints[0].Initialize(_spriteRenderer, Color.blue);
      _colorChangeHints[1].Initialize(_spriteRenderer, Color.red);

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
        //ChangeColor(Color.yellow);
        //

        foreach (IVisualHint hint in _colorChangeHints)
        {
          hint.OnHintEnabled();
        }
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

  }
}
