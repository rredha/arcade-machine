using UnityEngine;
using System.Collections;
using Arcade.Project.Runtime.Games.AngryBird.Interfaces;

namespace Arcade.Project.Runtime.Games.AngryBird
{
    public class Birds : MonoBehaviour
    {
      public Rigidbody2D Rb {get; private set;}
      public Collider2D Col {get; private set;}
      private SpriteRenderer _spriteRenderer;
      private bool _isFree;

      private void Awake()
      {
        Rb = GetComponent<Rigidbody2D>();
        Col = GetComponent<Collider2D>();
        _spriteRenderer = GetComponent<SpriteRenderer>();
        _isSelected = false;
      }
    }
}
