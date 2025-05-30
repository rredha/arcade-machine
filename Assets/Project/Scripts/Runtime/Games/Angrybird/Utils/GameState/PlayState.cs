using System.Collections;
using UnityEngine;
using Arcade.Project.Runtime.Games.AngryBird.Utils;

namespace Arcade.Project.Runtime.Games.AngryBird.Utils.GameState
{
  public class PlayState : GameState
  {
    public PlayState(GameContext context, GameStateMachine.EGameState key) : base(context, key)
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
  }
}
