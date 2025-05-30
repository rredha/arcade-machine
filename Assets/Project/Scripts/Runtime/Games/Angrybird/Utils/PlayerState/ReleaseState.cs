using System;
using System.Collections;
using UnityEngine;
using Arcade.Project.Runtime.Games.AngryBird.Utils;

namespace Arcade.Project.Runtime.Games.AngryBird.Utils.PlayerState
{
  public class ReleaseState : PlayerState
  {
    public ReleaseState(GameContext context, PlayerStateMachine.EPlayerState key) : base(context, key)
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

    public override PlayerStateMachine.EPlayerState GetNextState()
    {
      return StateKey;
    }
  }
}
