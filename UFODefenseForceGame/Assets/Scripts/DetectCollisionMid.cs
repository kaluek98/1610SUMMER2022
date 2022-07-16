using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionMid : MonoBehaviour
{
    private int Hp = 4;
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
