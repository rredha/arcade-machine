using System.Collections;
using UnityEngine;
using Arcade.Project.Runtime.Games.AngryBird.Utils;
using Arcade.Project.Runtime.Games.AngryBird.Utils.PlayerState;

namespace Arcade.Project.Runtime.Games.AngryBird.Utils.GameState
{
  public class PlayState : GameState
  {
    public PlayState(GameContext context, GameStateMachine.EGameState key) : base(context, key)
    {
        GameContext Context = context;
    }

    private GameStateMachine.EGameState _nextState;

    public override void EnterState()
    {
      //Context.PlayerStateMachine.SayHello();

    }

    public override void ExitState()
    {

    }

    public override void UpdateState()
    {
    }

    public override GameStateMachine.EGameState GetNextState()
    {
      bool isProjectileMoving = Context.Spawner.SpawnedProjectile.GetComponent<Projectile>().GetProjectileIsMoving();
      bool isProjectileInContactWithGround = Context.Spawner.SpawnedProjectile.GetComponent<Projectile>().GetProjectileInContactWithGround();
      if (!isProjectileMoving & isProjectileInContactWithGround)
      {
        _nextState = GameStateMachine.EGameState.Finish;
      } else
      {
        _nextState = GameStateMachine.EGameState.Play;
      }

      return _nextState;
    }
  }
}
