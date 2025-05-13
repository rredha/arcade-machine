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
    [SerializeField] private IVisualCue contour;

    [SerializeField] private SlingshotConfiguration config;

    [SerializeField] private LineRenderer[] lineRenderers;
    [SerializeField] private Transform[] rubberPositions;
    [SerializeField] private Transform center;
    [SerializeField] private Transform projectilePlaceholder;

    private PlayerInputActions _playerInputActions;
    private Vector3 _pointerWorldPosition;
    private Vector2 _pointerScreenPosition;


    private Vector3 _currentPosition;
    private Camera _camera;

    private void Awake()
    {
      _camera = Camera.main;
      _playerInputActions = new PlayerInputActions();
      _playerInputActions.Player.Enable();
      _playerInputActions.Player.Aim.performed += Aim_performed;
    }

    private void Start()
    {
      lineRenderers[0].positionCount = 2;
      lineRenderers[1].positionCount = 2;

      lineRenderers[0].SetPosition(0, rubberPositions[0].position);
      lineRenderers[1].SetPosition(0, rubberPositions[1].position);
    }

    private void Aim_performed(InputAction.CallbackContext ctx)
    {
      // convert form screen to world position.
      _pointerWorldPosition = ScreenToWorldPosition(ctx.ReadValue<Vector2>());

      /*
      if (_camera) _currentPosition = _camera.ScreenToWorldPoint(mousePosition);
      _currentPosition = center.position + Vector3.ClampMagnitude(_currentPosition - center.position,
                                                                         config.maxLength);

      _currentPosition = new Vector3(
                    _currentPosition.x,
        Mathf.Clamp(_currentPosition.y, config.bottomBoundary, 1000)
        );
        */
    }

    private Vector3 ScreenToWorldPosition(Vector2 screenPosition)
    {
      var worldPosition = _camera.ScreenToWorldPoint(screenPosition);
      return new Vector3(worldPosition.x, worldPosition.y, 0);
    }

    private void FixedUpdate()
    {
      SetRubber(_pointerWorldPosition);
      /*
      if (_isMouseDown)
      {
        var mousePosition = Input.mousePosition;
        mousePosition.z = 10;

        if (_camera) _currentPosition = _camera.ScreenToWorldPoint(mousePosition);
        _currentPosition = center.position + Vector3.ClampMagnitude(_currentPosition - center.position,
                                                                           config.maxLength);

        _currentPosition = new Vector3(
                      _currentPosition.x,
          Mathf.Clamp(_currentPosition.y, config.bottomBoundary, 1000)
          );
      }
      */
    }



      private void SetRubber(Vector3 position)
      {
        lineRenderers[0].SetPosition(1, position);
        lineRenderers[1].SetPosition(1, position);

        /*
        projectilePlaceholder.transform.position.Set(position.x,
                                                     position.y,
                                                     0);
        */
      }

    private void Shoot()
    {
      /*
      if (!Projectile.gameObject) return;

      Projectile.SetDynamic();
      Projectile.Rb.linearVelocity = (_currentPosition - center.position) * config.force * -1;
    }
    */
    }
      /*
      private void OnMouseDown()
      {
        _isMouseDown = true;
      }

      private void OnMouseUp()
      {
        _isMouseDown = false;
        Shoot();

        ResetRubber();
        //StartCoroutine(Projectile.Spawn(new Context(projectilePlaceholder,projectilePrefab),3.0f));
      }

      */

        /*
        if (Projectile.gameObject)
        {
          Vector3 dir = position - center.position;

          Projectile.gameObject.transform.position.Set
          (
            position.x + dir.normalized.x,
            position.y + dir.normalized.y,
            0
          );

          Projectile.transform.right = -dir.normalized;
        }
        */
      /*
      private void ResetRubber()
      {
        _currentPosition = projectilePlaceholder.position;
        SetRubber(_currentPosition);
      }
      */
        /*
        Projectile.transform.position = _currentPosition;
        SetRubber(_currentPosition);

        if (Projectile.Col)
        {
          Projectile.Col.enabled = true;
        }
      } else
      {
        ResetRubber();
      }
      */
  }
}
