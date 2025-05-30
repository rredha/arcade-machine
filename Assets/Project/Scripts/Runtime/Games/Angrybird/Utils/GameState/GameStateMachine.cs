using System;
using System.Collections.Generic;
using UnityEngine;
using Arcade.Project.Core.StateMachine;
using Arcade.Project.Runtime.Games.AngryBird.Utils;

namespace Arcade.Project.Runtime.Games.AngryBird.Utils.GameState
{
  public class GameStateMachine : StateManager<GameStateMachine.EGameState>
  {
    public enum EGameState
    {
      Init,
      Play,
      Finish,
    }

    //private List<Environment> _environmentList = new List<Environment>();

    private GameContext _context;

    private void Awake()
    {
     // _context = new GameContext(_environmentList);
    }
  }
}
