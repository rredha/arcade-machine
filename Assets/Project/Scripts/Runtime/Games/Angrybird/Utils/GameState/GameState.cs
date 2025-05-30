using System;
using System.Collections;
using UnityEngine;
using Arcade.Project.Core.StateMachine;
using Arcade.Project.Runtime.Games.AngryBird.Utils;

namespace Arcade.Project.Runtime.Games.AngryBird.Utils.GameState
{
  public abstract class GameState : State<GameStateMachine.EGameState>
  {
    protected GameContext Context;

    public GameState(GameContext context, GameStateMachine.EGameState statekey) : base(statekey)
    {
      Context = context;
    }
  }
}
