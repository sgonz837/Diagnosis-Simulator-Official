using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Transportation_Menu_Script : MonoBehaviour
{
    public GameObject Transport_Menu;
    public GameObject Movement_Menu;
    public GameObject Organ;
    bool check = false;
    AudioSource m_MyAudioSource;


    // Start is called before the first frame update
    void Start()
    {
        //Make Menu false
        Transport_Menu.SetActive(check);
        Time.timeScale = 1;
        m_MyAudioSource = Organ.GetComponent<AudioSource>();
    }

    public void OnButtonPress()
    {
        check = !check;
        Transport_Menu.SetActive(!check);
        m_MyAudioSource.mute = !check;
        Movement_Menu.SetActive(check);
        Time.timeScale = Convert.ToInt32(check ? 1 : 0);
        
    }
}
