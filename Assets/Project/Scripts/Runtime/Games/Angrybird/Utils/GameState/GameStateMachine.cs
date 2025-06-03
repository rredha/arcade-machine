using System;
using System.Collections.Generic;
using UnityEngine;
using Arcade.Project.Core.StateMachine;
using Arcade.Project.Runtime.Games.AngryBird.Utils;
using Arcade.Project.Runtime.Games.AngryBird.Utils.PlayerState;

namespace Arcade.Project.Runtime.Games.AngryBird.Utils.GameState
{
  public class GameStateMachine : StateManager<GameStateMachine.EGameState>
  {
    public enum EGameState
    {
      Init,
      Play,
      Finish,
    }


    private GameContext _gameContext;

    [SerializeField] private Spawner _spawner;
    [SerializeField] private Pointer _pointer;

    [SerializeField] private Projectile _projectile;
    [SerializeField] private Birds _bird;

    [SerializeField] private Transform _projectileSpawnPosition;
    [SerializeField] private Transform _birdSpawnPosition;

    [SerializeField] private List<Env> _environmentList = new List<Env>();
    [SerializeField] private PlayerStateMachine _playerStateMachine;

    private void Awake()
    {
      _gameContext = new GameContext
       (
         _spawner,
         _pointer,
         _projectile, _bird,
         _projectileSpawnPosition, _birdSpawnPosition,
         _environmentList,
         _playerStateMachine
       );
      CreateStateMachine();
    }
    private void CreateStateMachine()
    {
      States.Add(GameStateMachine.EGameState.Init, new InitState(_gameContext, GameStateMachine.EGameState.Init));
      States.Add(GameStateMachine.EGameState.Play, new PlayState(_gameContext, GameStateMachine.EGameState.Play));
      States.Add(GameStateMachine.EGameState.Finish, new FinishState(_gameContext, GameStateMachine.EGameState.Finish));
      CurrentState = States[GameStateMachine.EGameState.Init];
    }

    private void Update()
    {
    }

  }
}
