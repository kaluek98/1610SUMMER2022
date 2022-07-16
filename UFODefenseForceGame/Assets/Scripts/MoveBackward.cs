using UnityEngine;

public class MoveBackward : MonoBehaviour
{
    
   public float speed = 50.0f;

    
    void Update()
    {
        //move game object backward
       transform.Translate(Vector3.back * Time.deltaTime*speed); 
       
    }

}
