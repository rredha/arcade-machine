using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;
using Arcade.Project.Runtime.Games.AngryBird;

namespace Arcade.Project.Runtime.Games.AngryBird
{
  public class GameManager : MonoBehaviour
  {
    public static GameManager Instance;
    [SerializeField] private Spawner Spawner;
    [SerializeField] private Birds _bird;
    [SerializeField] private Transform _birdSpawnPosition;
    [SerializeField] private Transform CenterOfTheScreen;
    [SerializeField] private List<Environment> _environmentList = new List<Environment>();
    private bool[] has_env_moved = new bool[3];

    private void Awake()
    {
      // new game
      SpawnWorldInteractbles();
    }

    private void FixedUpdate()
    {
      CheckIfEnvironmentMoved();
    }

    public void CheckIfEnvironmentMoved()
    {
      for (int i = 0; i < _environmentList.Count; i++)
      {
        has_env_moved[i] = _environmentList[i].HasMoved;
      }
    }

    public void SpawnWorldInteractbles()
    {
      SpawnProjectile();
      SpawnBird();
    }

    public void SpawnProjectile()
    {
      StartCoroutine(Spawner.Spawn(CenterOfTheScreen));
    }

    public void SpawnBird()
    {
      StartCoroutine(SpawnBirdAt(_birdSpawnPosition));
    }

    public IEnumerator SpawnBirdAt(Transform location)
    {

      Instantiate(_bird.gameObject,
                  _birdSpawnPosition.position ,Quaternion.identity);

      yield return null;
    }
  }
}
