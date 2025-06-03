using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Arcade.Project.Runtime.Games.AngryBird;
using Arcade.Project.Runtime.Games.AngryBird.Utils.PlayerState;

namespace Arcade.Project.Runtime.Games.AngryBird.Utils
{
  public class GameContext
  {
    private Spawner _spawner;
    private Pointer _pointer;

    private Projectile _projectile;
    private Birds _bird;

    private Transform _projectileSpawnPosition;
    private Transform _birdSpawnPosition;

    private List<Env> _environmentList = new List<Env>();
    private PlayerStateMachine _playerStateMachine;

    public GameContext
      (
       Spawner spawner,
       Pointer pointer,
       Projectile projectile, Birds bird,
       Transform projectileSpawnPosition, Transform birdSpawnPosition,
       List<Env> environmentList,
       PlayerStateMachine playerStateMachine
      )
      {
       _spawner = spawner;
       _pointer = pointer;

       _projectile = projectile;
       _bird = bird;

       _projectileSpawnPosition = projectileSpawnPosition;
       _birdSpawnPosition = birdSpawnPosition;

       _environmentList = environmentList;
       _playerStateMachine = playerStateMachine;
      }

    public Spawner Spawner => _spawner;
    public Pointer Pointer => _pointer;
    public Projectile Projectile => _projectile;
    public Birds Bird => _bird;

    public Transform ProjectileSpawnPosition => _projectileSpawnPosition;
    public Transform BirdSpawnPosition => _birdSpawnPosition;

    public List<Env> EnvironmentList => _environmentList;
    public PlayerStateMachine playerStateMachine => _playerStateMachine;
  }
}
