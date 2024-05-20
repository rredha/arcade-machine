using System;
using System.Collections.Generic;
using UnityEngine;

namespace Arcade._Project.Core.StateMachine
{
    public abstract class StateMachine<TEnumState> : MonoBehaviour where TEnumState : Enum
    {
        /* State Machine is responsible for setting the other states.
         * States are stored in {key,value} pair
         */
        protected Dictionary<TEnumState, State<TEnumState>> States = new Dictionary<TEnumState, State<TEnumState>>();
        protected State<TEnumState> CurrentState;

        protected bool IsTransitionState = false;
        void Start()
        {
            CurrentState.EnterState();
        }
        void Update()
        {
            TEnumState nextStateKey = CurrentState.GetNextState();
            
            if (!IsTransitionState && nextStateKey.Equals(CurrentState.StateKey))
            {
                CurrentState.UpdateState();
            } else if (!IsTransitionState)
            {
                TransitionToState(nextStateKey);
            }

        }
        public void TransitionToState(TEnumState stateKey)
        {
            IsTransitionState = true;
            CurrentState.ExitState();
            CurrentState = States[stateKey];
            CurrentState.EnterState();
            IsTransitionState = false;
        }

        // should it be oncolliderenter ?
        private void OnTriggerEnter(Collider other)
        {
            CurrentState.OnTriggerEnter(other);
        }

        private void OnTriggerStay(Collider other)
        {
            CurrentState.OnTriggerStay(other);
        }

        private void OnTriggerExit(Collider other)
        {
            CurrentState.OnTriggerExit(other);
        }
    }
}
