namespace Arcade._Project.Pong.GameStateMachine
{
    public abstract class GameState : Core.StateMachine.State<GameStateMachine.GameStateEnum>
    {
        protected GameStateContext Context;
        public GameState(GameStateContext context, GameStateMachine.GameStateEnum key) : base(key)
        {
            Context = context;
        }

    }
}