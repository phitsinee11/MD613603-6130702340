using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

using System;

public class BMI : MonoBehaviour
{
    public InputField height;
    public InputField weight;
    public Text resultText;
    public void CalBmi(){
       float fHeight = float.Parse(height.text.ToString()); 
       float fWeight = float.Parse(weight.text.ToString());

       float fBmi = fWeight/(fHeight*fHeight);
       resultText.text = ""+fBmi;
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
