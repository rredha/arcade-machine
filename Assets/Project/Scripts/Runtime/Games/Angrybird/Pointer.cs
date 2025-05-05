using UnityEngine;
using Arcade.Project.Runtime.Games.AngryBird.Cues;
using Arcade.Project.Runtime.Games.AngryBird.Interfaces;

namespace Arcade.Project.Runtime.Games.AngryBird
{
  public class Pointer : MonoBehaviour
  {
      [SerializeField] private IVisualCue highlight;

      private Camera _camera;
      private Collider2D _collider;
      [SerializeField] private Collider2D otherCollider;

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
          _mousePosScreen = Input.mousePosition;
          if (_camera) _mousePosScreen.z = 10;
          _mousePosWorld = _camera.ScreenToWorldPoint(_mousePosScreen);

         // if (_collider.IsTouching(otherCollider));

          /*
          if (Physics2D.IsTouching(_collider, _otherCollider)) ;
          var numberOfContacts = Physics2D.OverlapPoint(_mousePosWorld, new ContactFilter2D().NoFilter(), _overlapColliders);
          if (numberOfContacts != null ) ;
          */

          transform.position = _mousePosWorld;
      }
  }
}
