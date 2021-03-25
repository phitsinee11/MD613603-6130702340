using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MultipleChoices : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public bool CheckAnswer()
    {
         int count = transform.childCount;
 for(int i = 0; i < count; i++)
 {
     Transform child = transform.GetChild(i);
     if(child.GetComponent<QuizCheckbox>().CheckAnswer() == false){
         return false;
     }

 }
 return true;

    }

    public void Play() {
        
    }
}
