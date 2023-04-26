using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;

public class Player_Movement_Script : MonoBehaviour
{
    float directionX;
    float directionZ;
    float rotationX;
    float rotationY;
    public float speed;
    Rigidbody rb;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //CrossPlatformInputManager.GetAxisRaw("Horizontal");
    }

    // Update is called once per frame
    void Update()
    {
        // Movement via buttion input using CrossPlatformInput engine
        directionX = CrossPlatformInputManager.GetAxisRaw("Horizontal");
        directionZ = CrossPlatformInputManager.GetAxisRaw("Vertical");

        // Rotating via buttion input using CrossPlatformInput engine
        rotationY = CrossPlatformInputManager.GetAxisRaw("RotHorizontal");
        rotationX = CrossPlatformInputManager.GetAxisRaw("RotVertical");

        // Making the camera move via rotation
        rb.transform.eulerAngles += new Vector3(-rotationX, rotationY, 0);
        

        
        if (directionZ > 0)
        {
            //Move the Rigidbody forwards constantly at speed you define (the blue arrow axis in Scene view)
            rb.velocity = transform.forward * speed;
        }
        else if (directionZ < 0)
        {
            //Move the Rigidbody backwards constantly at the speed you define (the blue arrow axis in Scene view)
            rb.velocity = -transform.forward * speed;
        }
        else if (directionX > 0)
        {
            //Move the Rigidbody right constantly at speed you define (the red arrow axis in Scene view)
            rb.velocity = transform.right * speed;
        }
        else if (directionX < 0)
        {
            //Move the Rigidbody left constantly at the speed you define (the red arrow axis in Scene view)
            rb.velocity = -transform.right * speed;
        }
        else
        {
            rb.velocity = transform.forward * 0;
            rb.velocity = transform.right * 0;
        }
        print(directionX);
        print(directionZ);
    }
    
}
