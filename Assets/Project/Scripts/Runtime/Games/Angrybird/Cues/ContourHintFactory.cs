using UnityEngine;
using System.Collections;
using Arcade.Project.Runtime.Games.AngryBird.Interfaces;
using Arcade.Project.Runtime.Games.AngryBird.Configurations;

namespace Arcade.Project.Runtime.Games.AngryBird.Cues
{
  public class ContourHintFactory : MonoBehaviour, IVisualHintFactory
  {
    public IVisualHint CreateVisualHint()
    {
      return new Contour();
    }
  }
}
