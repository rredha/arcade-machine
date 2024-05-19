using UnityEngine;

namespace Arcade._Project.Core.StateMachine
{
    public abstract class StateMachine : MonoBehaviour
    {
        protected State State;


        public void SetState(State state)
        {
            State = state;
            State.Start();
        }

    }
}
