using UnityEngine;

namespace Arcade._Project.Pong.GameStateMachine
{
    public class PlayingState : GameState
    {
        public PlayingState(GameStateContext context, GameStateMachine.GameStateEnum key) : base(context, key)
        {
            GameStateContext Context = context;
        }

        public override void EnterState()
        {
            Debug.Log("Init - PlayingState");
        }

        public override void ExitState()
        {
            Debug.Log("Exit - PlayingState");
        }

        public override void UpdateState()
        {
            Debug.Log("Exit - PlayingState");
            Context.ComputerPaddle.GetComponent<ComputerPaddle>().FollowBall();
            var playerInputDirection = Context.PlayerPaddle.GetComponent<PlayerPaddle>().direction;
            Context.PlayerPaddle.GetComponent<PlayerPaddle>().MovePaddle(playerInputDirection);

        }

        public override GameStateMachine.GameStateEnum GetNextState()
        {
            return StateKey;
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