using System;
using System.Collections.Generic;
using UnityEngine;
using Arcade._Project.Core.StateMachine;
using Arcade._Project.Snake.GameState;

namespace Arcade._Project.Snake
{
    public class LevelManager : StateMachine<LevelManager.LevelState>
    {
        private void Awake()
        {
            InitialiazeStates();
            Debug.Log("State Initialilzed successfully");
        }

        public enum LevelState
        {
            Init,
            Playing,
            Lost
        }

        private void InitialiazeStates()
        {
            States.Add(LevelState.Init, new Init(LevelState.Init, snakeHead, segmentPrefab));
            States.Add(LevelState.Playing, new Playing(LevelState.Playing, snakeHead, segmentPrefab));
            States.Add(LevelState.Lost, new Lost(LevelState.Lost, snakeHead, segmentPrefab));
            CurrentState = States[LevelState.Init];
        }
        [SerializeField] private Transform segmentPrefab; // a prefab for the snake head !
        [SerializeField] private Transform snakeHead;
    }
}