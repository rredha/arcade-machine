using System;
using System.Collections;
using UnityEngine;
using Arcade.Project.Runtime.Games.AngryBird.Utils;

namespace Arcade.Project.Runtime.Games.AngryBird.Utils.GameState
{
  public class FinishState : GameState
  {
    private GameContext _context;
    public FinishState(GameContext context, GameStateMachine.EGameState key) : base(context, key)
    {
        GameContext _context = context;
    }

    public override void EnterState()
    {
      Debug.Log("Hello from finish state");
    }

    public override void ExitState()
    {

    }

    public override void UpdateState()
    {

    }

    public override GameStateMachine.EGameState GetNextState()
    {
      return GameStateMachine.EGameState.Finish;
    }

  }
}
