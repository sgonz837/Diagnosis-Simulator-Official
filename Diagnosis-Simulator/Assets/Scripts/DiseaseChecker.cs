using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class DiseaseChecker : MonoBehaviour
{
    public TextMeshProUGUI disease;


    // Update is called once per frame
    void Update()
    {
        checkConditions();
    }

    public void checkConditions()
    {
        if(GameplayVariables.symptom1Int == 1 && GameplayVariables.symptom2Int == 2 && GameplayVariables.symptom3Int == 2)
        {
            disease.text = "Chronic Heart Disease";
        } else if(GameplayVariables.symptom1Int == 1 && GameplayVariables.symptom2Int == 2 && GameplayVariables.symptom3Int == 3)
        {
            disease.text = "Heart Mumur";
        } else if(GameplayVariables.symptom1Int == 3 && GameplayVariables.symptom2Int == 3 && GameplayVariables.symptom3Int == 1)
        {
            disease.text = "Asthma";
        }
    }
}
