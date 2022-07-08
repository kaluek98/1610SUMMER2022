using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float horizontalInput;
    public float speed;
    
    public float xRange;

    public Transform blaster;
    
    public GameObject lazerBolt;

    
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
        if(Input.GetKeyDown(KeyCode.Space))
        {
            //create lazerBold at the blaster transform position maintaining the objects rotation
            Instantiate(lazerBolt, blaster.transform.position, lazerBolt.transform.rotation);
        }
    }
//delete any object with a trigger that hits player
    private void OnTriggerEnter(Collider other)
    {
        Destroy(other.gameObject);
    }
}
