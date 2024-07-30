using UnityEngine;

namespace Arcade._Project.Pong.GameStateMachine
{
    public class PlayingState : GameState
    {
        public PlayingState(GameStateContext context, GameStateMachine.GameStateEnum key) : base(context, key)
        {
            GameStateContext Context = context;
        }

        private ScoringZone.GameResult _result = ScoringZone.GameResult.Init;
        public override void EnterState()
        {
        }

        public override void UpdateState()
        {
            var playerInputDirection = Context.PlayerPaddle.GetComponent<PlayerPaddle>().direction;
            Context.PlayerPaddle.GetComponent<PlayerPaddle>().MovePaddle(playerInputDirection);
            
            _result = Context.RightWall.GetComponent<ScoringZone>().Result;
            _result = Context.LeftWall.GetComponent<ScoringZone>().Result;
            Debug.Log(_result.ToString());

        }
        public override void ExitState()
        {
            Context.RightWall.GetComponent<ScoringZone>().Result = ScoringZone.GameResult.Init;
            Context.LeftWall.GetComponent<ScoringZone>().Result = ScoringZone.GameResult.Init;
        }


        public override GameStateMachine.GameStateEnum GetNextState()
        {
            switch (_result)
            {
               case ScoringZone.GameResult.Win:
                   return GameStateMachine.GameStateEnum.Win;
               case ScoringZone.GameResult.Lose:
                   return GameStateMachine.GameStateEnum.Lose;
               default:
                   return StateKey;
            }
        }

        public override void OnTriggerEnter(Collider other)
        {
        }

        public override void OnTriggerStay(Collider other)
        {
        }

        public override void OnTriggerExit(Collider other)
        {
        }
    }
}