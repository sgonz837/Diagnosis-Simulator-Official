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

        GameplayVariables.disease1 = false;
        GameplayVariables.disease2 = false;
        GameplayVariables.disease3 = false;
        randomNumber = Random.Range(1, 3 + 1);

        Debug.Log("The Random Number: " + randomNumber);
    }
    
    public void Disease1()
    {
        GameplayVariables.symptom1Guess = 1;
        GameplayVariables.symptom2Guess = 2;
        GameplayVariables.symptom3Guess = 2;
        GameplayVariables.disease1 = true;

        Debug.Log("Disease: " + randomNumber);
    }

    public void Disease2()
    {

        GameplayVariables.disease2 = true;
        GameplayVariables.symptom1Guess = 1;
        GameplayVariables.symptom2Guess = 2;
        GameplayVariables.symptom3Guess = 3;

        //GameplayVariables.disease2 = true;
        Debug.Log("Disease: " + randomNumber);
    }

    public void Disease3()
    {

        GameplayVariables.disease3 = true;

        GameplayVariables.symptom1Guess = 3;
        GameplayVariables.symptom2Guess = 3;
        GameplayVariables.symptom3Guess = 1;

        //GameplayVariables.disease3 = true;
        Debug.Log("Disease: " + randomNumber);
    }
}
