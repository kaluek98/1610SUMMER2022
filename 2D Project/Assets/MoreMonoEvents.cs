using UnityEngine;
using UnityEngine.Events;

public class MoreMonoEvents : MonoBehaviour
{
    public UnityEvent collisionEvent, mousehoverEvent, mousehoverOffEvent, mouseclickEvent;

    private void OnTriggerEnter()
    {
        collisionEvent.Invoke();
    }
     private void OnMouseOver()
    {
        mousehoverEvent.Invoke();
    }
    private void OnMouseExit()
    {
        mousehoverOffEvent.Invoke();
    }
     private void OnMouseUpAsButton()
    {
        mouseclickEvent.Invoke();
    }
}
