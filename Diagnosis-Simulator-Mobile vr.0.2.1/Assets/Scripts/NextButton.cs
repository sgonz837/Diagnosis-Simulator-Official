/* 
    Name: Sayan Gonzalez
 */

using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;


/*
    How to use: Attach to a ui object with a button component
                also go to the objects inspector page > button then u have to manually find the OnbuttonClick function to make this work            
    Description: Opens a inactive canvas and disables the current canvas to simulate that its switching between pages
 
 */
public class NextButton : MonoBehaviour
{
    public Transform head; //we will use the head x ,y z values to adjust the canavas to show directly in front of the player no matter where he is looking
    public float spawnDistance = 2; //the distance the canvas will open from the player
    public GameObject canvasToOpen; //attack the canvas you want to open
    public GameObject canvasToClose; //attach to the canvas you want to close

    public void OnButtonClick()
    {
        canvasToOpen.SetActive(!canvasToOpen.activeSelf); //we activate the inactive canvas
        //here we do math to calculate where the canvas should be at
        canvasToOpen.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance; 
        canvasToOpen.transform.LookAt(new Vector3(head.position.x, canvasToOpen.transform.position.y, head.position.z)); 
        canvasToOpen.transform.forward *= -1; 

        
        canvasToClose.SetActive(false);
    }
}
