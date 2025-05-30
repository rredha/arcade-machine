using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Arcade.Project.Runtime.Games.AngryBird;
using Arcade.Project.Runtime.Games.AngryBird.Utils.PlayerState;
using Arcade.Project.Runtime.Games.AngryBird.Utils.GameState;

namespace Arcade.Project.Runtime.Games.AngryBird.Utils
{
  public class GameManager : MonoBehaviour
  {
    public static GameManager Instance;
    private Arcade.Project.Runtime.Games.AngryBird.Utils.PlayerState.PlayerState _playerState;
    private Arcade.Project.Runtime.Games.AngryBird.Utils.GameState.GameState _gameState;
    private GameContext _gameContext;
    [SerializeField] private Spawner _spawner;
    [SerializeField] private Birds _bird;
    [SerializeField] private Transform _birdSpawnPosition;
    [SerializeField] private Transform _centerOfTheScreen;
    [SerializeField] private List<Env> _environmentList = new List<Env>();
    private bool[] has_env_moved = new bool[3];

    private void Awake()
    {
      // new game
      _gameContext = new GameContext(_environmentList, _spawner, _bird, _birdSpawnPosition, _centerOfTheScreen);
      SpawnWorldInteractbles();
    }

    private void FixedUpdate()
    {
      CheckIfEnvironmentMoved();
    }


  }
}
