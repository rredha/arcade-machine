using System;
using System.Collections;
using UnityEngine;
using Arcade.Project.Core.StateMachine;
using Arcade.Project.Runtime.Games.AngryBird.Utils;

namespace Arcade.Project.Runtime.Games.AngryBird.Utils.PlayerState
{
  public abstract class PlayerState : State<PlayerStateMachine.EPlayerState>
  {
    protected GameContext Context;

    public PlayerState(GameContext context, PlayerStateMachine.EPlayerState statekey) : base(statekey)
    {
      Context = context;
    }
  }
}
