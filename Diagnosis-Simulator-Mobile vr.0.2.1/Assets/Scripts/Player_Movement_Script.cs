using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.CrossPlatformInput;
using UnityEngine.UI;

public class Player_Movement_Script : MonoBehaviour
{
    float directionX;
    float directionZ;
    float rotationX;
    float rotationY;

/*    public GameObject Slider;
    public Component Bar;*/
    
    public float speed;

    Rigidbody rb;

    float num;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //scrollbar = GetComponent<scrollbar>();
    }

    // Update is called once per frame
    void Update()
    {
        // Movement via buttion input using CrossPlatformInput engine
        directionX = CrossPlatformInputManager.GetAxis("Horizontal");
        directionZ = CrossPlatformInputManager.GetAxis("Vertical");

        // Rotating via buttion input using CrossPlatformInput engine
        rotationY = CrossPlatformInputManager.GetAxis("RotHorizontal");
        rotationX = CrossPlatformInputManager.GetAxis("RotVertical");

        // Making the camera move via rotation
        rb.transform.eulerAngles += new Vector3(-rotationX, rotationY, 0);

/*        //Scrollbar bar = Slider.GetComponent<Scrollbar>();
        //num = GameObject.Find("Scrollbar").GetComponentInChildren<Scrollbar>();
        Vector3 pos = transform.position;
        //print(Bar.Interactable);
        pos.y = Bar.Value * 20;
        transform.position = pos;*/


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
    }
    public static void ForceUpdateCanvases() 
    {
    
    
    }
}

