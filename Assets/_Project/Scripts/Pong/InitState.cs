using Arcade._Project.Core.StateMachine;
using UnityEngine;

namespace Arcade._Project.Pong
{
    public class InitState : State<GameStateMachine.GameStateEnum>
    {
        /*
         * @brief : Initialise ball and paddles to initial position
         *          at the beginning and after a win or loss.
         */
        public InitState(GameStateMachine.GameStateEnum key)  : base(key)
        {
        }

        public override void EnterState()
        {
            GameManager.FindObjectOfType<Ball>().ResetPosition();
            GameManager.FindObjectOfType<PlayerPaddle>().ResetPosition();
            GameManager.FindObjectOfType<ComputerPaddle>().ResetPosition();
            
        }

        public override void ExitState()
        {
            Debug.Log("We are in the exit method of InitState");
            throw new System.NotImplementedException();
        }

        public override void UpdateState()
        {
            Debug.Log("We are in the update method of InitState");
        }

        public override GameStateMachine.GameStateEnum GetNextState()
        {
            throw new System.NotImplementedException();
        }

        public override void OnTriggerEnter(Collider other)
        {
            throw new System.NotImplementedException();
        }

        public override void OnTriggerStay(Collider other)
        {
            throw new System.NotImplementedException();
        }

        public override void OnTriggerExit(Collider other)
        {
            throw new System.NotImplementedException();
        }
    }
}