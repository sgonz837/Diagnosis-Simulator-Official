using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Transportation_Menu_Script : MonoBehaviour
{
    public GameObject Transport_Menu;
    bool check = false;

    // Start is called before the first frame update
    void Start()
    {
        //Make Menu false
        Transport_Menu.SetActive(check);
        Time.timeScale = 1;
    }

    // Update is called once per frame
    void Update()
    {
        // Replace with item interaction if needed
        if (Input.GetButtonDown("Cancel"))
        {
            check = !check;
            Transport_Menu.SetActive(!check);
            Time.timeScale = Convert.ToInt32(check ? 1 : 0);
        }
    }
}
