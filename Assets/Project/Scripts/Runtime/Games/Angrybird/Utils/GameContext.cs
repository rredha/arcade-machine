using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Arcade.Project.Runtime.Games.AngryBird;

namespace Arcade.Project.Runtime.Games.AngryBird.Utils
{
  public class GameContext : MonoBehaviour
  {
    private List<Env> _environmentList = new List<Env>();
    private Spawner _spawner;
    private Birds _bird;
    private Transform _birdSpawnPosition;
    private Transform _centerOfTheScreen;

    GameContext(List<Env> environmentList, Spawner spawner, Birds bird, Transform birdSpawnPosition, Transform centerOfTheScreen)
    {
     _environmentList = environmentList;
     _spawner = spawner;
     _bird = bird;
     _birdSpawnPosition = birdSpawnPosition;
     _centerOfTheScreen = centerOfTheScreen;
    }

    public List<Env> EnvironmentList => _environmentList;
    public Spawner Spawner => _spawner;
    public Birds Bird => _bird;
    public Transform BirdSpawnPosition => _birdSpawnPosition;
    public Transform CenterOfTheScreen => _centerOfTheScreen;
  }
}
