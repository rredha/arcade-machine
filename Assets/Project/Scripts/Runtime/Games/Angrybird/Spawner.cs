using UnityEngine;
using System.Collections;
using Arcade.Project.Runtime.Games.AngryBird.Cues;
using Arcade.Project.Runtime.Games.AngryBird.Interfaces;

namespace Arcade.Project.Runtime.Games.AngryBird
{
  public class Spawner : MonoBehaviour, ISpawnableItem
  {
    [SerializeField] private Projectile Projectile;

    public IEnumerator Spawn(Transform location, Transform parent)
    {

      Instantiate(Projectile.gameObject,
                  location.position ,Quaternion.identity,
                  parent);
      yield return null;
    }

    public IEnumerator Spawn(Transform location, Transform parent, bool isStatic)
    {

      Instantiate(Projectile.gameObject,
                  location.position ,Quaternion.identity,
                  parent);
      if (isStatic) Projectile.SetStatic();
      yield return null;
    }

    public IEnumerator Spawn(Transform location, Transform parent, bool isStatic, float delay)
    {

      yield return new WaitForSeconds(delay);
      Instantiate(Projectile.gameObject,
                  location.position ,Quaternion.identity,
                  parent);
      if (isStatic) Projectile.SetStatic();
    }

    public IEnumerator Spawn(Transform location, Transform parent, float delay)
    {

      yield return new WaitForSeconds(delay);
      Instantiate(Projectile.gameObject,
                  location.position ,Quaternion.identity,
                  parent);
    }
  }
}
