using UnityEngine;
using Arcade._Project.Core.UI;

namespace Arcade.Project.Runtime.Games.Pong.GameStateMachine
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
            Context.PlayerPaddle.GetComponent<PlayerPaddle>().ResetPosition();
            Context.ComputerPaddle.GetComponent<ComputerPaddle>().ResetPosition();
            Context.Ball.GetComponent<Ball>().ResetPosition();
            Countdown.Enable();
        }


        // ReSharper disable Unity.PerformanceAnalysis
        public override void UpdateState()
        {
            //Debug.Log("Init - UpdateState");
            Countdown.Begin();
            Countdown.Disable();
        }
        public override void ExitState()
        {
            //Debug.Log("Init - ExitState");
            Context.Ball.GetComponent<Ball>().LaunchBall();
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
