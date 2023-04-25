using System.Collections;
using System.Collections.Generic;
using System.Security.Cryptography;
using UnityEngine;

public class GameplayLoop : MonoBehaviour
{

    //variables
    int randomNumber;

    // Start is called before the first frame update
    void Start()
    {

        GameplayVariables.startGame = true;

        Randomizer();

        GamePlayLoop();

        /*
        if (GameplayVariables.startGame == true)
        {
            Randomizer();
        }
        */
        //Randomizer();
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GamePlayLoop()
    {

        if(randomNumber == 1)
        {
            Disease1();
        } else if(randomNumber == 2)
        {
            Disease2();
        } else if(randomNumber == 3)
        {
            Disease3();
        }

    }

    public void Randomizer()
    {
        randomNumber = Random.Range(1, 3 + 1);

        Debug.Log("The Random Number: " + randomNumber);
    }
    
    public void Disease1()
    {
        GameplayVariables.symptom1Guess = 1;
        GameplayVariables.symptom2Guess = 1;
        GameplayVariables.symptom3Guess = 1;

        Debug.Log("Disease: " + randomNumber);
    }

    public void Disease2()
    {
        GameplayVariables.symptom1 = " ";
        GameplayVariables.symptom2 = " ";
        GameplayVariables.symptom3 = " ";
        Debug.Log("Disease: " + randomNumber);
    }

    public void Disease3()
    {
        GameplayVariables.symptom1 = " ";
        GameplayVariables.symptom2 = " ";
        GameplayVariables.symptom3 = " ";
        Debug.Log("Disease: " + randomNumber);
    }
    

}
