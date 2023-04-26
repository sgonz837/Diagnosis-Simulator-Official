/* 
    Name: Sayan Gonzalez
    Description: Opens a inactive canvas if the player presses the associated button
                then adjusts it to the players head
 */


using UnityEngine;
using UnityEngine.InputSystem;
public class Clipboard : MonoBehaviour
{
    public Transform head;
    public float spawnDistance = 2;
    public GameObject menu;
    public InputActionProperty showButton;

    private void Start()
    {
        
    }

    private void Update()
    {
        if (showButton.action.WasPressedThisFrame())
        {
            menu.SetActive(!menu.activeSelf);
            menu.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        }
        menu.transform.LookAt(new Vector3(head.position.x, menu.transform.position.y, head.position.z));
        menu.transform.forward *= -1;
    }
}
