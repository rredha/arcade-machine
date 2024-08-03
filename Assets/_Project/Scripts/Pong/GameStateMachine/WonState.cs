using UnityEngine;

namespace Arcade._Project.Pong.GameStateMachine
{
    public class WonState : GameState
    {
        public WonState(GameStateContext context, GameStateMachine.GameStateEnum key) : base(context, key)
        {
            GameStateContext Context = context;
        }

        public override void EnterState()
        {
            Debug.Log("You Won");
            Context.RightWall.GetComponent<ScoringZone>().Result = ScoringZone.GameResult.Init;
            Context.LeftWall.GetComponent<ScoringZone>().Result = ScoringZone.GameResult.Init;
        }

        public override void ExitState()
        {
        }

        public override void UpdateState()
        {
        }

        public override GameStateMachine.GameStateEnum GetNextState()
        {
            return GameStateMachine.GameStateEnum.Init;
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