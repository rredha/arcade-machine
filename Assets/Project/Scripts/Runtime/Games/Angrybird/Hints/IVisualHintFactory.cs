using UnityEngine;
using System.Collections;
using Arcade.Project.Runtime.Games.AngryBird.Interfaces;
using Arcade.Project.Runtime.Games.AngryBird.Configurations;

namespace Arcade.Project.Runtime.Games.AngryBird.Hints
{
  public interface IVisualHintFactory
  {
    public IVisualHint CreateVisualHint();
  }
}
