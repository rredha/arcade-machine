using UnityEngine;
using System.Collections;
using Arcade.Project.Runtime.Games.AngryBird.Interfaces;

namespace Arcade.Project.Runtime.Games.AngryBird
{
  public class Spawner : MonoBehaviour
  {
    public Projectile Projectile;
    public Birds Bird;

    public Transform ProjectileLocation;
    public Transform BirdLocation;

    public GameObject SpawnedProjectile;

    public void CoroutineStartBird()
    {
      StartCoroutine(SpawnBird(BirdLocation));
    }

    public void CoroutineStartProjectile()
    {
      StartCoroutine(SpawnProjectile(ProjectileLocation));
    }

    public IEnumerator SpawnProjectile(Transform location)
    {

      SpawnedProjectile = Instantiate(Projectile.gameObject,
                  location.position ,Quaternion.identity);
      yield return null;
    }

    public IEnumerator SpawnBird(Transform location)
    {

      Instantiate(Bird.gameObject,
                  location.position ,Quaternion.identity);
      yield return null;
    }
  }
}
