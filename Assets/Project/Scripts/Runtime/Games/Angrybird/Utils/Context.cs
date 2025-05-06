using UnityEngine;
using System.Collections;

namespace Arcade.Project.Runtime.Games.AngryBird
{
    public class Context : MonoBehaviour
    {
      public Context(Transform projectileLocation, GameObject projectilePrefab)
      {
        ProjectilePlaceholder = projectileLocation;
        ProjectilePrefab = projectilePrefab;
      }

      public readonly Transform ProjectilePlaceholder;
      public readonly GameObject ProjectilePrefab;
    }
}
