namespace Utils
{
    public abstract class State
    {
        protected StateMachine GameStateMachine;

        public State(StateMachine gameStateMachine)
        {
            GameStateMachine = gameStateMachine;
        }


        public abstract void Start();
    }
}