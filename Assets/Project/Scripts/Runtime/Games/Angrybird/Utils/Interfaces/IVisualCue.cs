using UnityEngine;

namespace Arcade.Project.Runtime.Games.AngryBird.Interfaces
{
    public interface IVisualCue
    {
        public void Cue(SpriteRenderer sp);
        public void OnCueActivated(SpriteRenderer sp);
        public void OnCueDisabled(SpriteRenderer sp);
        public void OnCueToggle(SpriteRenderer sp);
    }
}
