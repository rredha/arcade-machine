using UnityEngine;
using System.Collections;
using Arcade.Project.Runtime.Games.AngryBird.Cues;
using Arcade.Project.Runtime.Games.AngryBird.Interfaces;

namespace Arcade.Project.Runtime.Games.AngryBird
{
    public class Projectile : MonoBehaviour
    {
        [SerializeField] private IVisualCue highlight;
        [SerializeField] private IVisualCue colorChange;

        public Rigidbody2D Rb {get; private set;}
        public Collider2D Col {get; private set;}
        private SpriteRenderer _spriteRenderer;
        private bool _isSelected;

        private void Awake()
        {
            Rb = GetComponent<Rigidbody2D>();
            Col = GetComponent<Collider2D>();
            _spriteRenderer = GetComponent<SpriteRenderer>();
            _isSelected = false;
        }


        public void SetStatic()
        {
            Col.enabled = false;
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
            colorChange.OnCueActivated(_spriteRenderer);
        }

        public void HoverActionPerform()
        {
            if (_isSelected) return;
            highlight.OnCueActivated(_spriteRenderer);
        }

    }
}
