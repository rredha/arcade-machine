namespace Utils

{
    public abstract class StateMachine
    {
        protected State State;


        public void SetState(State state)
        {
            State = state;
            State.Start();
        }

    }
}