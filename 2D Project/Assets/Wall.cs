using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject block;
    public int width = 10;
    public int height = 4;
    // Start is called before the first frame update
    void Start()
    
    {
        Debug.Log("I am alive!");
       
        for (int y=0; y<height; ++y)
        {
            for (int x=0; x<width; ++x)
            {
                Instantiate(block, new Vector2(x,y), Quaternion.identity);
            }
        }
        
    }

   
}
