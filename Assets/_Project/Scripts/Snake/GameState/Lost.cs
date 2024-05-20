using Arcade._Project.Core.StateMachine;
using UnityEngine;

namespace Arcade._Project.Snake.GameState
{
    public class Lost:State<LevelManager.LevelState>
    {
        /*
        public Lost(LevelManager.LevelState key) : base(key)
        {
        }
        */

        public override void EnterState()
        {
            Debug.Log("Hello From Init State");
        }

        public override void ExitState()
        {
            Debug.Log("Exiting Lost State");
        }

        public override void UpdateState()
        {
            throw new System.NotImplementedException();
        }

        public override LevelManager.LevelState GetNextState()
        {
            return LevelManager.LevelState.Init;
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

        public Lost(LevelManager.LevelState key, Transform snakeHead, Transform segmentPrefab) : base(key, snakeHead, segmentPrefab)
        {
        }
    }
}