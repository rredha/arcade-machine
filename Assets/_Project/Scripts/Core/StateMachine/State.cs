using System.Collections;

namespace Arcade._Project.Core.StateMachine
{
    public abstract class State
    {
        protected StateMachine StateMachine;

        public State(StateMachine stateMachine)
        {
            StateMachine = stateMachine;
        }


        public abstract void Start();
    }
}