using UnityEngine;

namespace Arcade.Project.Runtime.Games.AngryBird.Interfaces
{
    public interface IVisualCue
    {
        public void Cue(GameObject gameObject);
        public void OnCueActivated(GameObject gameObject);
        public void OnCueDisabled(GameObject gameObject);
        public void OnCueToggle(GameObject gameObject);
    }
}
