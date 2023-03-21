using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class Transportation_Menu_Script : MonoBehaviour
{
    public GameObject Transport_Menu;

    // Start is called before the first frame update
    void Start()
    {
        //Make Menu false
        Transport_Menu.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {

        /* 
         * on interaction:
         *  Make menu true
            //Transport_Menu.SetActive(true);
         *  pause game
         *  Have buttons unpause the game
        */
        
    }
}
