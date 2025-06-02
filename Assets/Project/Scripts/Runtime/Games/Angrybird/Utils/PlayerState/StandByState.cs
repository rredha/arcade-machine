using System;
using System.Collections;
using UnityEngine;
using Arcade.Project.Core.StateMachine;
using Arcade.Project.Runtime.Games.AngryBird.Utils;
using Arcade.Project.Runtime.Games.AngryBird.Utils.GameState;

namespace Arcade.Project.Runtime.Games.AngryBird.Utils.PlayerState
{
  public class StandByState : PlayerState
  {
    public StandByState(PlayerContext context, PlayerStateMachine.EPlayerState key) : base(context, key)
    {
        PlayerContext Context = context;
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
      return PlayerStateMachine.EPlayerState.StandBy;
    }
  }
}
