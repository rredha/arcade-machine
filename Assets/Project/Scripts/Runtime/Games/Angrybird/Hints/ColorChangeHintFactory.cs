using UnityEngine;
using System.Collections;
using Arcade.Project.Runtime.Games.AngryBird.Interfaces;
using Arcade.Project.Runtime.Games.AngryBird.Configurations;
using Arcade.Project.Runtime.Games.AngryBird.Hints;

namespace Arcade.Project.Runtime.Games.AngryBird.Hints
{
  public class ColorChangeHintFactory : IVisualHintFactory
  {
    public IVisualHint CreateVisualHint()
    {
      return new ColorChangeWithDelay();
    }
  }
}
