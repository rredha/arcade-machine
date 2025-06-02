using System;
using System.Collections;
using UnityEngine;
using Arcade.Project.Runtime.Games.AngryBird.Utils;

namespace Arcade.Project.Runtime.Games.AngryBird.Utils.PlayerState
{
  public class DropState : PlayerState
  {
    public DropState(PlayerContext context, PlayerStateMachine.EPlayerState key) : base(context, key)
    {
        PlayerContext Context = context;
    }

    public override void EnterState()
    {
      Debug.Log("Drop the projectile in the Slingshot");

    }

    public override void ExitState()
    {

    }

    public override void UpdateState()
    {

    }

    public override PlayerStateMachine.EPlayerState GetNextState()
    {
      return PlayerStateMachine.EPlayerState.Aim;
    }
  }
}
