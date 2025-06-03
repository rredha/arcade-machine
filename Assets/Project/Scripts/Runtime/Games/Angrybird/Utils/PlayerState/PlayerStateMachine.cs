using System;
using System.Collections.Generic;
using UnityEngine;
using Arcade.Project.Core.StateMachine;
using Arcade.Project.Runtime.Games.AngryBird.Utils;
using Arcade.Project.Runtime.Games.AngryBird.Utils.GameState;

namespace Arcade.Project.Runtime.Games.AngryBird.Utils.PlayerState
{
  public class PlayerStateMachine : StateManager<PlayerStateMachine.EPlayerState>
  {
    public enum EPlayerState
    {
      StandBy,
      Pick,
      Drop,
      Aim,
    }

    private PlayerContext _context;

    [SerializeField] private Pointer _pointer;
    [SerializeField] private Projectile _projectile;

    private void Awake()
    {
      _context = new PlayerContext
       (
         _pointer,
         _projectile
       );
      CreatePlayerStateMachine();
    }

    private void CreatePlayerStateMachine()
    {
      States.Add(PlayerStateMachine.EPlayerState.StandBy, new StandByState(_context, PlayerStateMachine.EPlayerState.StandBy));
      States.Add(PlayerStateMachine.EPlayerState.Pick, new PickState(_context, PlayerStateMachine.EPlayerState.Pick));
      States.Add(PlayerStateMachine.EPlayerState.Drop, new DropState(_context, PlayerStateMachine.EPlayerState.Drop));
      States.Add(PlayerStateMachine.EPlayerState.Aim, new AimState(_context, PlayerStateMachine.EPlayerState.Aim));
    }

    public void RunPlayerStateMachine()
    {
      CurrentState = States[PlayerStateMachine.EPlayerState.StandBy];
    }

    public void SayHello()
    {
      Debug.Log("Hello");
    }
  }
}
