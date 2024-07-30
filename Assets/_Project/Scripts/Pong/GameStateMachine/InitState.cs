using UnityEngine;

namespace Arcade._Project.Pong.GameStateMachine
{
    public class InitState : GameState
    {
        public InitState(GameStateContext context, GameStateMachine.GameStateEnum key) : base(context, key)
        {
            GameStateContext Context = context;
        }

        public override void EnterState()
        {
            Debug.Log("Init - EnterState");
        }


        public override void UpdateState()
        {
            Debug.Log("Init - UpdateState");
        }
        public override void ExitState()
        {
            
            Debug.Log("Init - ExitState");
        }

        public override GameStateMachine.GameStateEnum GetNextState()
        {
            return GameStateMachine.GameStateEnum.Playing;
            //return StateKey;
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