using UnityEngine;
//using UnityEngine.EventSystems;

namespace Arcade._Project.Pong
{
    public class PongScoringZone : MonoBehaviour
    {
        //public EventTrigger.TriggerEvent scoreTrigger;

        private void OnCollisionEnter2D(Collision2D col)
        {
            //’gives us the object that collided with our object
            PongBall ball = col.gameObject.GetComponent<PongBall>();

            if (ball != null)
            {
         //       BaseEventData eventData = new BaseEventData(EventSystem.current);
          //      scoreTrigger.Invoke(eventData);
            }
        }
    }
}
