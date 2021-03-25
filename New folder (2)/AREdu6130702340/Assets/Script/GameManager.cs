using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{

    public bool testMode;
    public GameObject checkButton;

    public GameObject RightPanel;

    public GameObject WrongPanel;

    public GameObject nowObject;

    public int gameType;

    public AudioSource aSource;

    public AudioClip rightSound;

    public AudioClip wrongSound;

    public string rightText;

    public string wrongText;

    public Text displayText;

    public GameObject MainCamera;

    public GameObject ArSession;

    public GameObject ArSessionOrigin;

    
    // Start is called before the first frame update
    void Start()
    {
        if(testMode){

MainCamera.SetActive(true);
ArSession.SetActive(false);
ArSessionOrigin.SetActive(false);

        } else
        {
            MainCamera.SetActive(false);
ArSession.SetActive(true);
ArSessionOrigin.SetActive(true);

        }
        
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }


    public void GetCheckButton()
    {
        checkButton.SetActive(true);
    }

        public void HideCheckButton()
    {
        checkButton.SetActive(false);
    }

    public void CheckAnswer(){

        if(nowObject.GetComponent<ARObject>().objectType == "multichoice"){
          bool check =   nowObject.transform.GetChild(0).GetComponent<MultipleChoices>().CheckAnswer();

          if(check == true){
               // RightPanel.SetActive(true);
              //  WrongPanel.SetActive(false)
              displayText.text = "ถูกต้อง";
                PlayWin();
          }else{
             //   WrongPanel.SetActive(true);
              //  RightPanel.SetActive(false);
              displayText.text = "ตอบผิด";
                PlayLose();

                
          }
        }
else if(nowObject.GetComponent<ARObject>().objectType == "GroupGame"){

    GroupGameManager mGroupGameManager = GameObject.Find("GroupGameManager").GetComponent<GroupGameManager>();
              if(mGroupGameManager.CheckCard() == true){
               // RightPanel.SetActive(true);
              //  WrongPanel.SetActive(false)
              displayText.text = "ถูกต้อง";
                PlayWin();
          }else{
             //   WrongPanel.SetActive(true);
              //  RightPanel.SetActive(false);
              displayText.text = "ตอบผิด " +mGroupGameManager.debugText;
                PlayLose();
          }

}else{
    displayText.text = "การ์ดไม่อยู่ในประเภทตรวจคำตอบ : " +  nowObject.GetComponent<ARObject>().objectType ;
}


        

    }

    public void PlayWin()
    {
        aSource.PlayOneShot(rightSound);
    }

        public void PlayLose()
    {
        aSource.PlayOneShot(wrongSound);
    }

        public void PlaySound( AudioClip aClip)
    {
        aSource.PlayOneShot(aClip);
    }

        public void PlayMusic()
    {
        aSource.Play();
    }
    
}
