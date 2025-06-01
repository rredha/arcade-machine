using System;
using System.Collections;
using UnityEngine;
using Arcade.Project.Core.StateMachine;
using Arcade.Project.Runtime.Games.AngryBird.Utils;

namespace Arcade.Project.Runtime.Games.AngryBird.Utils.GameState
{
  public class InitState : GameState
  {
    // Initialize and spawn game objects
    public InitState(GameContext context, GameStateMachine.EGameState key) : base(context, key)
    {
        GameContext Context = context;
    }
    private GameStateMachine.EGameState _nextState;

    public override void EnterState()
    {
      Context.Spawner.BirdLocation = Context.BirdSpawnPosition;
      Context.Spawner.ProjectileLocation = Context.ProjectileSpawnPosition;

      Context.Spawner.CoroutineStartBird();
      Context.Spawner.CoroutineStartProjectile();
    }

    public override void UpdateState()
    {
    }

    public override void ExitState()
    {
    }

    public override GameStateMachine.EGameState GetNextState()
    {
      bool isProjectileSelected = Context.Spawner.SpawnedProjectile.GetComponent<Projectile>().IsSelected;

      if (isProjectileSelected)
      {
        _nextState = GameStateMachine.EGameState.Play;
      }

      return _nextState;
    }
  }
}
