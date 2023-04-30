using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class SceneButtonBehaviour : MonoBehaviour
{
    public int area;
    public void OnButtonPress()
    {
        if (area == -1) 
        {
            Application.Quit();
        }
        else 
        {
            //in public outside of code, adjust values to send the character to whichever scene they need to be in
            SceneManager.LoadScene(area);
        }
        

    }
}
