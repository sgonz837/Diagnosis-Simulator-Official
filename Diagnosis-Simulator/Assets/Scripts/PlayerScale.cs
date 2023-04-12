using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerScale : MonoBehaviour
{

    public InputActionProperty increaseHeight;
    public InputActionProperty decreaseHeight;
    public float heightScale = 1.0f;
    private void Update()
    {
        if (increaseHeight.action.WasPressedThisFrame())
        {
            heightScale += 0.1f; // Increase the height scale by 0.1
            transform.localScale = new Vector3(1, heightScale, 1); // Apply the new scale to the player object
            //menu.SetActive(!menu.activeSelf);
            //menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        }
        if (decreaseHeight.action.WasPressedThisFrame())
        {
            heightScale -= 0.8f; // Increase the height scale by 0.1
            transform.localScale = new Vector3(1, heightScale, 1); // Apply the new scale to the player object
            //menu.SetActive(!menu.activeSelf);
            //menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        }

    }
}
