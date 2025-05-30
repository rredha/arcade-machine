using System;
using System.Collections;
using UnityEngine;
using Arcade.Project.Runtime.Games.AngryBird.Utils;

namespace Arcade.Project.Runtime.Games.AngryBird.Utils.GameState
{
  public class FinishState : GameState
  {
    public FinishState(GameContext context, GameStateMachine.EGameState key) : base(context, key)
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

    public void CheckIfEnvironmentMoved()
    {
      for (int i = 0; i < _environmentList.Count; i++)
      {
        has_env_moved[i] = _environmentList[i].DidItReallyMove();
      }
    }
  }
}
