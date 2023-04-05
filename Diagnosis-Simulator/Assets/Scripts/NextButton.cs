using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    public Transform head;
    public float spawnDistance = 2;
    public GameObject canvasToOpen;
    public GameObject canvasToClose;

    public void OnButtonClick()
    {
        //GameObject canvas = GameObject.Find(canvasToOpen.name);
        //canvas.SetActive(true);
        canvasToOpen.SetActive(!canvasToOpen.activeSelf);
        canvasToOpen.transform.position = head.position + new Vector3(head.forward.x, 0, head.forward.z).normalized * spawnDistance;
        canvasToOpen.transform.LookAt(new Vector3(head.position.x, canvasToOpen.transform.position.y, head.position.z));
        canvasToOpen.transform.forward *= -1;


        canvasToClose.SetActive(false);
    }
}
