using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    public float itemAmount = 0 ;
    
    public float xRange;

    public Transform blaster;
    
    public GameObject lazerBolt;

    public GameManager gameManager;

    void start()
    {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
    }

    
    void Update()
    {
        //Set HorizontalImput to recieve values from horizontal keys
        horizontalInput = Input.GetAxis("Horizontal");
        // Moves Player left and right
        transform.Translate(Vector3.right * horizontalInput * Time.deltaTime * speed);
        //keep player bound left
        if(transform.position.x < -xRange )
        {
            transform.position = new Vector3(-xRange,transform.position.y,transform.position.z);
        }
        //keep player bound right
        if(transform.position.x > xRange )
        {
            transform.position = new Vector3(xRange,transform.position.y,transform.position.z);
        }
        //If space bar is pressed fire lazerBolt
        if(Input.GetKeyDown(KeyCode.Space) && Time.timeScale == 1)
        {
            //create lazerBold at the blaster transform position maintaining the objects rotation
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }

    }
    private void OnTriggerEnter (Collider theCollision)
    {
        if (theCollision.gameObject.tag == "GoodItem")
        {
            Debug.Log("+1 item");
            Destroy(theCollision.gameObject);
            itemAmount++;
        }

        else 
        {
            Debug.Log("hit working");
            Destroy(theCollision.gameObject);
        }
    }

}
