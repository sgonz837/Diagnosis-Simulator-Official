using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class PatientInfo : MonoBehaviour
{

    public TextMeshProUGUI Name;
    public TextMeshProUGUI DBD;
    public TextMeshProUGUI Age;
    public TextMeshProUGUI Gender;
    public TextMeshProUGUI Weight;
    public TextMeshProUGUI Height;
    public TextMeshProUGUI Reason;
    // Start is called before the first frame update
    void Start()
    {
        patientChangeText();
    }


    public void patientChangeText()
    {
        if(GameplayVariables.disease1 == true)
        {
            Debug.Log("Patient 1");
            patient1();
        } else if (GameplayVariables.disease2 == true)
        {
            Debug.Log("Patient 2");
            patient2();
        } else if (GameplayVariables.disease3== true)
        {
            Debug.Log("Patient 3");
            patient3();
        }
    }

    public void patient1()
    {
        Name.text = "John Doe";
        DBD.text = "March 21 1991";
        Age.text = "32";
        Gender.text = "Male";
        Weight.text = "155 Pounds";
        Height.text = "5'8";
        Reason.text = "Patient States that He feels pain in his chest and Feels Fatigue all the time. After a quick analysis, we noticed patient has a swollen liver";
    }

    public void patient2()
    {
        Name.text = "Mary Doe";
        DBD.text = "November 15 1974";
        Age.text = "59";
        Gender.text = "Female";
        Weight.text = "135";
        Height.text = "5'5";
        Reason.text = "Patient states that they feel chest pain, Feels fatigue and is dizzy";
    }

    public void patient3()
    {
        Name.text = "Kevin";
        DBD.text = "June 07 2001";
        Age.text = "21";
        Gender.text = "Male";
        Weight.text = "180 pounds";
        Height.text = "6'0";
        //Reason.text = "Patient was taken to the hospital after faiting. Patient is rapidly breathing and states that she feels fatigue and is dizzy";
        Reason.text = "Patient is Wheezing,Rapid Breathing and feels tightness in their chest";
    }

}
