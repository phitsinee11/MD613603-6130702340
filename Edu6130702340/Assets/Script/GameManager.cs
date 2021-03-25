using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public GameObject nowObject;

    public Text resultText;

    public AudioClip rightSound;

    public AudioClip wrongSound;
    
    public void CheckAnswer(){

        int c = nowObject.transform.childCount;

        for(int i = 0;i<c;i++){
            Answer n = nowObject.transform.GetChild(i).GetComponent<Answer>();
            if(n.rightAnswer != n.select){
               resultText.text = " ตอบผิด";
            gameObject.GetComponent<AudioSource>().PlayOneShot(wrongSound);

               return; 

            }
        }
         resultText.text = " ถูกต้องนะค้าบ";
         gameObject.GetComponent<AudioSource>().PlayOneShot(rightSound);
    }
}
