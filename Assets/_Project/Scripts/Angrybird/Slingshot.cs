using System.Collections;
using UnityEngine;

public class Slingshot : MonoBehaviour
{
  /* Slingshot :
      It has data related to it's geometry (scriptableObject use case ?)
      Handles aiming, shooting
      Should at least have a boolean value representing if its
        loaded
        empty
      Should not be responsible for spawning projectiles
    Depends on :
      Projectile
  */
    [SerializeField]
    private LineRenderer[] lineRenderers;

    [SerializeField]
    private Transform[] rubberPositions;

    [SerializeField]
    private Transform center;

    [SerializeField] private SlingshotConfiguration configuration;

    [SerializeField]
    private GameObject projectilePrefab;

    [SerializeField]
    private Transform projectilePlaceholder;

    private GameObject _projectileGameObject;
    private Projectile _projectile;

    private Vector3 _currentPosition;
    private bool _isMouseDown;
    private Camera _camera;

    private void Awake()
    {
      _camera = Camera.main;
      StartCoroutine(SpawnProjectile());
    }
    private void Start()
    {
      lineRenderers[0].positionCount = 2;
      lineRenderers[1].positionCount = 2;

      lineRenderers[0].SetPosition(0, rubberPositions[0].position);
      lineRenderers[1].SetPosition(0, rubberPositions[1].position);
    }

    private void Update()
    {
      if (_isMouseDown)
      {
        Vector3 mousePosition = Input.mousePosition;
        mousePosition.z = 10; // why ??

        if (_camera) _currentPosition = _camera.ScreenToWorldPoint(mousePosition);
        _currentPosition = center.position + Vector3.ClampMagnitude(_currentPosition - center.position,
                                                                           configuration.maxLength);

        _currentPosition = new Vector3(
                      _currentPosition.x,
          Mathf.Clamp(_currentPosition.y, configuration.bottomBoundary, 1000)
          );

        _projectileGameObject.transform.position = _currentPosition;
        SetRubber(_currentPosition);

        if (_projectile.Col)
        {
          _projectile.Col.enabled = true;
        }
      } else
      {
        ResetRubber();
      }
    }

    #region Input

    private void OnMouseDown()
    {
      _isMouseDown = true;
    }

    private void OnMouseUp()
    {
      _isMouseDown = false;
      Shoot();
      // detach from the placeholder gameobject
      _projectile.transform.SetParent(transform.parent);
      ResetRubber();
      StartCoroutine(SpawnProjectile(3.0f));
    }

    #endregion

    #region Rubber
    private void SetRubber(Vector3 position)
    {
      lineRenderers[0].SetPosition(1, position);
      lineRenderers[1].SetPosition(1, position);
      projectilePlaceholder.transform.position.Set(position.x,
                                                   position.y,
                                                   0);
      if (_projectileGameObject)
      {
        Vector3 dir = position - center.position;

        _projectileGameObject.transform.position.Set
        (
          position.x + dir.normalized.x,
          position.y + dir.normalized.y,
          0
        );

        _projectileGameObject.transform.right = -dir.normalized;
      }
    }
    private void ResetRubber()
    {
      _currentPosition = projectilePlaceholder.position;
      SetRubber(_currentPosition);
    }
    #endregion

    private void Shoot()
    {
      if (!_projectileGameObject) return;

      _projectile.SetProjectileDynamic();
      _projectile.Rb.linearVelocity = (_currentPosition - center.position) * configuration.force * -1;
    }
    private IEnumerator SpawnProjectile()
    {
      _projectileGameObject = Instantiate(projectilePrefab,
                    projectilePlaceholder.position ,Quaternion.identity,
                    projectilePlaceholder);
      _projectile = _projectileGameObject.GetComponent<Projectile>();
      _projectile.SetProjectileStatic();
      yield return null;
    }
    private IEnumerator SpawnProjectile(float delay)
    {
      yield return new WaitForSeconds(delay);
      _projectileGameObject = Instantiate(projectilePrefab,
                    projectilePlaceholder.position ,Quaternion.identity,
                    projectilePlaceholder);
      _projectile = _projectileGameObject.GetComponent<Projectile>();
      _projectile.SetProjectileStatic();
    }
}
