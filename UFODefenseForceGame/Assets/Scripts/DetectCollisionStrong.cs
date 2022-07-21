using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisionStrong : MonoBehaviour
{
    public ScoreManager scoreManager; //Store reference to score manager
    public int scoreToGive;
    private int Hp = 22;

    void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // find ScoreManager gameobject and refrence ScoreManager script component
    }
    void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
        Hp --; 
        if(Hp<=0)
        { 
        Destroy(gameObject);
        scoreManager.IncreaseScore(scoreToGive); // increase score
        }
       
        
    }
}
