using UnityEngine;
using UnityEngine.Events;

public class MonoEventsBehavior : MonoBehaviour
{
    public UnityEngine startEvent, awakeEvent, disableEvent;
    
    private void Awake()
    {
     awakeEvent.Invoke();   
    }
    private void Start();
    {
        startEvent.Invoke();
    }
    private void Disable();
    {
        disableEvent.Invoke();
    }

 
