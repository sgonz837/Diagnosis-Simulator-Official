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

    public void OnImageButtonClick()
    {
        // Handle the click event here
    }

    public void Symptom1ForwardButtonClick()
    {

        
        if (GameplayVariables.symptom1Int == 1)
        {
            textObject.text = "Nausea";
            GameplayVariables.symptom1Int = 2;
        } else if (GameplayVariables.symptom1Int == 2)
        {
            textObject.text = "Wheezing";
            GameplayVariables.symptom1Int = 3;
        } else if (GameplayVariables.symptom1Int == 3)
        {
            textObject.text = "Chest Pain";
            GameplayVariables.symptom1Int = 1;
        }
    }

    public void Symptom1BackwardButtonClick()
    {
        if (GameplayVariables.symptom1Int == 1)
        {
            textObject.text = "Wheezing";
            GameplayVariables.symptom1Int = 3;
        }
        else if (GameplayVariables.symptom1Int == 2)
        {
            textObject.text = "Chest Pain";
            GameplayVariables.symptom1Int = 1;
        }
        else if (GameplayVariables.symptom1Int == 3)
        {
            textObject.text = "Nausea";
            GameplayVariables.symptom1Int = 2;
        }
    }
    public void Symptom2ForwardButtonClick()
    {
        if (GameplayVariables.symptom2Int == 1)
        {
            textObject.text = "Fatigue";
            GameplayVariables.symptom2Int = 2;
        }
        else if (GameplayVariables.symptom2Int == 2)
        {
            textObject.text = "Rapid Breathing";
            GameplayVariables.symptom2Int = 3;
        }
        else if (GameplayVariables.symptom2Int == 3)
        {
            textObject.text = "Fainting";
            GameplayVariables.symptom2Int = 1;
        }
    }
    public void Symptom2BackwardButtonClick()
    {
        if (GameplayVariables.symptom2Int == 1)
        {
            textObject.text = "Rapid Breathing";
            GameplayVariables.symptom2Int = 3;
        }
        else if (GameplayVariables.symptom2Int == 2)
        {
            textObject.text = "Fainting";
            GameplayVariables.symptom2Int = 1;
        }
        else if (GameplayVariables.symptom2Int == 3)
        {
            textObject.text = "Fatigue";
            GameplayVariables.symptom2Int = 2;
        }
    }


    public void Symptom3ForwardButtonClick()
    {
        if (GameplayVariables.symptom3Int == 1)
        {
            textObject.text = "Swollen Liver";
            GameplayVariables.symptom3Int = 2;
        }
        else if (GameplayVariables.symptom3Int == 2)
        {
            textObject.text = "Dizziness";
            GameplayVariables.symptom3Int = 3;
        }
        else if (GameplayVariables.symptom3Int == 3)
        {
            textObject.text = "Chest Tightness";
            GameplayVariables.symptom3Int = 1;
        }
    }

    public void Symptom3BackwardButtonClick()
    {
        if (GameplayVariables.symptom3Int == 1)
        {
            textObject.text = "Dizziness";
            GameplayVariables.symptom3Int = 3;
        }
        else if (GameplayVariables.symptom3Int == 2)
        {
            textObject.text = "Chest Tightness";
            GameplayVariables.symptom3Int = 1;
        }
        else if (GameplayVariables.symptom3Int == 3)
        {
            textObject.text = "Swollen Liver";
            GameplayVariables.symptom3Int = 2;
        }
    }







}
