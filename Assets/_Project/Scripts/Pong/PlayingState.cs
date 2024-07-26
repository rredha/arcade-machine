using Arcade._Project.Core.StateMachine;
using UnityEngine;

namespace Arcade._Project.Pong
{
    public class PlayingState : State<GameStateMachine.GameStateEnum>
    {
        public PlayingState(GameStateMachine.GameStateEnum key) : base(key)
        {
        }

        public override void EnterState()
        {
            Debug.Log("We are in the EnterState of PlayingState");
        }

        public override void ExitState()
        {
            Debug.Log("We are in the ExitState of PlayingState");
        }

        public override void UpdateState()
        {
            Debug.Log("We are in the UpdateState of PlayingState");
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