using System;
using System.Collections;
using UnityEngine;

namespace Arcade.Project.Core.StateMachine
{
    public abstract class State<TEnumState> where TEnumState : Enum
    {
        public State(TEnumState key)
        {
            StateKey = key;
        }

        public TEnumState StateKey { get; private set; }

        public abstract void EnterState();
        public abstract void ExitState();
        public abstract void UpdateState();
        public abstract TEnumState GetNextState();

        /*
        public abstract void OnTriggerEnter(Collider other);
        public abstract void OnTriggerStay(Collider other);
        public abstract void OnTriggerExit(Collider other);
        */
    }
}
