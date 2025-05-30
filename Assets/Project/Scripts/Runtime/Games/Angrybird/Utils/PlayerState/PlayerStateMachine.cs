using System;
using System.Collections.Generic;
using UnityEngine;
using Arcade.Project.Core.StateMachine;
using Arcade.Project.Runtime.Games.AngryBird.Utils;

namespace Arcade.Project.Runtime.Games.AngryBird.Utils.PlayerState
{
  public class PlayerStateMachine : StateManager<PlayerStateMachine.EPlayerState>
  {
    public enum EPlayerState
    {
      Pick,
      Drop,
      Aim,
    }

    //private List<Environment> _environmentList = new List<Environment>();

    private GameContext _context;

    private void Awake()
    {
     // _context = new GameContext(_environmentList);
    }
  }
}
