using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Submit : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void SubmitBtn()
    {
        if (GameplayVariables.symptom1Guess == GameplayVariables.symptom1Int && GameplayVariables.symptom2Guess == GameplayVariables.symptom2Int && GameplayVariables.symptom3Guess == GameplayVariables.symptom3Int)
        {
            //take to main screen for now
            Debug.Log("Win");
        }
        else
        {
            Debug.Log("False");
            Debug.Log("symp1" + GameplayVariables.symptom1Int + "symp2" + GameplayVariables.symptom2Int + "symp3" + GameplayVariables.symptom3Int + "symp1I" + GameplayVariables.symptom1Guess + "symp2I" + GameplayVariables.symptom2Guess + "symp3I" + GameplayVariables.symptom3Guess);
            //message letting them know trhey its not right
        }



    }
}
