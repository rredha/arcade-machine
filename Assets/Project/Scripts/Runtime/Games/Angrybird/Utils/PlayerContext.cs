using UnityEngine;
using System.Collections;
using System.Collections.Generic;
using Arcade.Project.Runtime.Games.AngryBird;

namespace Arcade.Project.Runtime.Games.AngryBird.Utils
{
  public class PlayerContext
  {
    private Pointer _pointer;
    private Projectile _projectile;

    public PlayerContext
      (
       Pointer pointer,
       Projectile projectile
      )
      {
       _pointer = pointer;
       _projectile = projectile;
      }

    public Pointer Pointer => _pointer;
    public Projectile Projectile => _projectile;
  }
}
