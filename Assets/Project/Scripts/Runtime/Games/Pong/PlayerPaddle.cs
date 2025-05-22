using UnityEngine;
using UnityEngine.InputSystem;

namespace Arcade.Project.Runtime.Games.Pong
{
    public class PlayerPaddle : Paddle
    {
        private InputAction moveAction;
        public Vector2 direction { private set; get; }

        private void Start()
        {
          moveAction = InputSystem.actions.FindAction("Move");
        }
        public void ResetPosition(){
            tr.position = new Vector2 (-8.0f,0.0f);
        }

        private void Update()
        {
          Vector2 moveValue = moveAction.ReadValue<Vector2>();
          MovePaddle(moveValue);

        }

        public void MovePaddle(Vector2 dir)
        {
            if (dir.sqrMagnitude > 0) {
                _rigidbody.AddForce(dir * speed);
            }
        }
    }
}
