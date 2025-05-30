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

    public override void EnterState()
    {

    }

    public override void ExitState()
    {

    }

    public override void UpdateState()
    {

    }

    public override GameStateMachine.EGameState GetNextState()
    {
      return StateKey;
    }

    public void SpawnWorldInteractbles()
    {
      SpawnProjectile();
      SpawnBird();
    }

    public void SpawnProjectile()
    {
      StartCoroutine(Spawner.Spawn(CenterOfTheScreen));
    }

    public void SpawnBird()
    {
      StartCoroutine(SpawnBirdAt(_birdSpawnPosition));
    }

    public IEnumerator SpawnBirdAt(Transform location)
    {

      Instantiate(_bird.gameObject,
                  _birdSpawnPosition.position ,Quaternion.identity);

      yield return null;
    }
  }
}
