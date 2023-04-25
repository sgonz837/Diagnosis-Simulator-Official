using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class ClipboardGameplay : MonoBehaviour
{

    //public Text textObject;
    public TextMeshProUGUI textObject;


    //int symptom1 = 1;
    //int symptom2 = 1;
    //int symptom3 = 1;
    //public Text textObject;
    //public Text textObject;
    //public Text textObject;
    //public Text textObject;
    //public Text textObject;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void Symptoms()
    {
        
    }

    public void OnImageButtonClick()
    {
        // Handle the click event here
    }

    public void Symptom1ForwardButtonClick()
    {
       // int count = 1;
        
        if (GameplayVariables.symptom1Int == 1)
        {
            textObject.text = "New Text";
            GameplayVariables.symptom1Int = 2;
        } else if (GameplayVariables.symptom1Int == 2)
        {
            textObject.text = "New Text 2";
            GameplayVariables.symptom1Int = 3;
        } else if (GameplayVariables.symptom1Int == 3)
        {
            textObject.text = "NewText3";
            GameplayVariables.symptom1Int = 1;
        }
    }

    public void Symptom1BackwardButtonClick()
    {
        if (GameplayVariables.symptom1Int == 1)
        {
            textObject.text = "New Text";
            GameplayVariables.symptom1Int = 3;
        }
        else if (GameplayVariables.symptom1Int == 2)
        {
            textObject.text = "New Text 2";
            GameplayVariables.symptom1Int = 1;
        }
        else if (GameplayVariables.symptom1Int == 3)
        {
            textObject.text = "NewText3";
            GameplayVariables.symptom1Int = 2;
        }
    }
    public void Symptom2ForwardButtonClick()
    {
        if (GameplayVariables.symptom2Int == 1)
        {
            textObject.text = "New Text";
            GameplayVariables.symptom2Int = 2;
        }
        else if (GameplayVariables.symptom2Int == 2)
        {
            textObject.text = "New Text 2";
            GameplayVariables.symptom2Int = 3;
        }
        else if (GameplayVariables.symptom2Int == 3)
        {
            textObject.text = "NewText3";
            GameplayVariables.symptom2Int = 1;
        }
    }
    public void Symptom2BackwardButtonClick()
    {
        if (GameplayVariables.symptom2Int == 1)
        {
            textObject.text = "New Text";
            GameplayVariables.symptom2Int = 3;
        }
        else if (GameplayVariables.symptom2Int == 2)
        {
            textObject.text = "New Text 2";
            GameplayVariables.symptom2Int = 1;
        }
        else if (GameplayVariables.symptom2Int == 3)
        {
            textObject.text = "NewText3";
            GameplayVariables.symptom2Int = 2;
        }
    }


    public void Symptom3ForwardButtonClick()
    {
        if (GameplayVariables.symptom3Int == 1)
        {
            textObject.text = "New Text";
            GameplayVariables.symptom3Int = 2;
        }
        else if (GameplayVariables.symptom3Int == 2)
        {
            textObject.text = "New Text 2";
            GameplayVariables.symptom3Int = 3;
        }
        else if (GameplayVariables.symptom3Int == 3)
        {
            textObject.text = "NewText3";
            GameplayVariables.symptom3Int = 1;
        }
    }

    public void Symptom3BackwardButtonClick()
    {
        if (GameplayVariables.symptom3Int == 1)
        {
            textObject.text = "New Text";
            GameplayVariables.symptom3Int = 3;
        }
        else if (GameplayVariables.symptom3Int == 2)
        {
            textObject.text = "New Text 2";
            GameplayVariables.symptom3Int = 1;
        }
        else if (GameplayVariables.symptom3Int == 3)
        {
            textObject.text = "NewText3";
            GameplayVariables.symptom3Int = 2;
        }
    }

    public void Submit() 
    { 
        if(GameplayVariables.symptom1Guess == GameplayVariables.symptom1Int && GameplayVariables.symptom2Guess == GameplayVariables.symptom2Int && GameplayVariables.symptom3Guess == GameplayVariables.symptom3Int)
        {

        }
        else
        {

        }
    
    
    
    }





}
