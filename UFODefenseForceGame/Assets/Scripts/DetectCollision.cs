using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollision : MonoBehaviour
{
    public ScoreManager scoreManager; //Store reference to score manager

    public int scoreToGive;

     void Start()
    {
        scoreManager = GameObject.Find("ScoreManager").GetComponent<ScoreManager>(); // find ScoreManager gameobject and refrence ScoreManager script component
    }

    void OnTriggerEnter(Collider other)
    {
        scoreManager.IncreaseScore(scoreToGive); // increase score
        Destroy(gameObject);
        Destroy(other.gameObject);
    }
}
