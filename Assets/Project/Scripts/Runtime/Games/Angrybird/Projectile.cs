using UnityEngine;
using System.Collections;
//using Arcade.Project.Runtime.Games.AngryBird.Cues;
using Arcade.Project.Runtime.Games.AngryBird.Interfaces;

namespace Arcade.Project.Runtime.Games.AngryBird
{
  // projectile is better suited to be event based.
    public class Projectile : MonoBehaviour
    {
      /*
        [SerializeField] private IVisualCue highlight;
        [SerializeField] private IVisualCue colorChange;
      */

      private LayerMask _environmentLayer;
      public Rigidbody2D Rb {get; private set;}
      public Collider2D Col {get; private set;}
      private SpriteRenderer _spriteRenderer;
      private bool _isSelected;

      private void Awake()
      {
        _environmentLayer = LayerMask.GetMask("Environment");
        Rb = GetComponent<Rigidbody2D>();
        Col = GetComponent<Collider2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _isSelected = false;
      }


      public void SetStatic()
      {
        Col.enabled = true;
        Rb.bodyType = RigidbodyType2D.Kinematic;
      }

      public void SetDynamic()
      {
        Col.enabled = true;
        Rb.bodyType = RigidbodyType2D.Dynamic;
      }

      public void SelectActionPerform()
      {
        if (!_isSelected) return;
        //colorChange.OnCueActivated(_spriteRenderer);
      }

      public void HoverActionPerform()
      {
        if (_isSelected) return;
       // highlight.OnCueActivated(_spriteRenderer);
      }

      private void OnCollisionEnter2D(Collision2D col)
      {
        // simply disable collider so it wont get activated when checking for bird free.
        // simplest implementation is to check when the projectile no longer moves.
        // also check if an environment has been moved to disable it.
        Debug.Log(col.gameObject.layer + _environmentLayer.ToString());
        if (col.gameObject.layer == _environmentLayer)
        {
          Collider2D collisionCollider;
          collisionCollider = col.gameObject.GetComponent<Collider2D>();
          Debug.Log(col.gameObject.name);
          collisionCollider.enabled = false;
        }
      }

    }
}
