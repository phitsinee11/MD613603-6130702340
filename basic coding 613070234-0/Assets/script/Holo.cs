using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using UnityEngine.UI;



public class Holo : MonoBehaviour
{

    public InputField day;

    public InputField month;

    public InputField year;

    public Text resultText;


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

public void Calresalt(){

    resultText.text = day.text.ToString()+"/"+ 
    month.text.ToString()+"/"+year.text.ToString();

    int intYear = Int16.Parse(year.text.ToString())-543;
    int intDay = Int16.Parse(day.text.ToString());
    int intMonth = Int16.Parse(month.text.ToString());
DateTime dt = new DateTime(intYear, intMonth, intDay);

    resultText.text = resultText.text+" "+ dt.DayOfWeek;

if(intMonth==1){
    if(intDay<16){
        resultText.text = resultText.text+" "+ "ธนู";
    }else{
        resultText.text = resultText.text+" "+ "มังกร";
    }

}else if(intMonth==2){
    if(intDay<16){
    resultText.text = resultText.text+" "+ "มังกร";
}else{
    resultText.text = resultText.text+" "+ "กุมภ์";
}

}else if(intMonth==3){
    if(intDay<16){
    resultText.text = resultText.text+" "+ "กุมภ์";
}else{
    resultText.text = resultText.text+" "+ "มีน";
}

}else if(intMonth==4){
    if(intDay<16){
    resultText.text = resultText.text+" "+ "มีน";
}else{
    resultText.text = resultText.text+" "+ "เมษ";
}

}else if(intMonth==5){
    if(intDay<16){
    resultText.text = resultText.text+" "+ "เมษ";
}else{
    resultText.text = resultText.text+" "+ "พฤษก";
}

}else if(intMonth==6){
    if(intDay<16){
    resultText.text = resultText.text+" "+ "พฤษก";
}else{
    resultText.text = resultText.text+" "+ "เมถุน";
} 

}else if(intMonth==7){
    if(intDay<16){
    resultText.text = resultText.text+" "+ "เมถุน";
}else{
    resultText.text = resultText.text+" "+ "กรกฎ";
}

}else if(intMonth==8){
    if(intDay<16){
    resultText.text = resultText.text+" "+ "กรกฎ";
}else{
    resultText.text = resultText.text+" "+ "สิงห์";
}

}else if(intMonth==9){
    if(intDay<16){
    resultText.text = resultText.text+" "+ "สิงห์";
}else{
    resultText.text = resultText.text+" "+ "กันย์";
}

}else if(intMonth==10){
    if(intDay<16){
    resultText.text = resultText.text+" "+ "กันย์";
}else{
    resultText.text = resultText.text+" "+ "ตุล";
}

}else if(intMonth==11){
    if(intDay<16){
    resultText.text = resultText.text+" "+ "ตุล";
}else{
    resultText.text = resultText.text+" "+ "พิจิก";
}

}else if(intMonth==12){
    if(intDay<16){
    resultText.text = resultText.text+" "+ "พิจิก";
}else{
    resultText.text = resultText.text+" "+ "ธนู";
}
    }

}
}
