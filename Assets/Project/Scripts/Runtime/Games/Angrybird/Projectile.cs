using UnityEngine;
using System.Collections;
//using Arcade.Project.Runtime.Games.AngryBird.Cues;
using Arcade.Project.Runtime.Games.AngryBird.Interfaces;

namespace Arcade.Project.Runtime.Games.AngryBird
{
  // projectile is better suited to be event based.
    public class Projectile : MonoBehaviour
    {
      private LayerMask _environmentLayer;
      private LayerMask _groundLayer;
      public Rigidbody2D Rb {get; private set;}
      public Collider2D Col {get; private set;}
      private SpriteRenderer _spriteRenderer;
      public bool IsSelected {get; private set;}
      public bool IsMoving {get; private set;}
      public bool IsInContactWithGround {get; private set;}

      private void Awake()
      {
        _environmentLayer = LayerMask.GetMask("Environment");
        _groundLayer = LayerMask.GetMask("Ground");
        _spriteRenderer = GetComponent<SpriteRenderer>();

        Rb = GetComponent<Rigidbody2D>();
        Col = GetComponent<Collider2D>();

        IsSelected = false;
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

      public void SetProjectileSelected()
      {
        IsSelected = true;
      }

      // TO FIX
      // Minor bug regarding linear velocity.

      public bool GetProjectileIsMoving()
      {
        const float THRESHHOLD = 0.5f;
        if (Rb.linearVelocity.magnitude <= THRESHHOLD)
        {
          return false;
          //IsMoving = false;
        } else
        {
          return true;
          //IsMoving = true;
        }
      }

      public bool GetProjectileInContactWithGround()
      {
        if (Col.IsTouchingLayers(_groundLayer))
        {
          //IsInContactWithGround = true;
          return true;
        }else
        {
          return false;
          //IsInContactWithGround = false;
        }

      }
    }
}
