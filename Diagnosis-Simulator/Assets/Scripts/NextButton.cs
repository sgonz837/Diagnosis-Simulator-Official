using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NextButton : MonoBehaviour
{
    public GameObject canvasToOpen;

    public void OnButtonClick()
    {
        GameObject canvas = GameObject.Find(canvasToOpen.name);
        canvas.SetActive(true);
        gameObject.SetActive(false);
    }
}
