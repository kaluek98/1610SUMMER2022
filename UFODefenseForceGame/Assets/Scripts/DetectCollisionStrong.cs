using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionStrong : MonoBehaviour
{
    private int Hp = 18;
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Hp --; 
        if(Hp<=0)
        { 
        Destroy(gameObject);
        }
       
        
    }
}
