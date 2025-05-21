using UnityEngine;
using System.Collections;
using Arcade.Project.Runtime.Games.AngryBird.Interfaces;
using Arcade.Project.Runtime.Games.AngryBird.Configurations;
using Arcade.Project.Runtime.Games.AngryBird.Cues;

namespace Arcade.Project.Runtime.Games.AngryBird.Cues
{
  public class ColorChangeHintFactory : IVisualHintFactory
  {
    public IVisualHint CreateVisualHint()
    {
      return new ColorChangeWithDelay();
    }
  }
}
