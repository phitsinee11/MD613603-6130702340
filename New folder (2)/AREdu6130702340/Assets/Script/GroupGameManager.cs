using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GroupGameManager : MonoBehaviour
{

    public int  maxAnswer = 4;
    public int cardCount;
    public List<GroupGame> cardList = new List<GroupGame>();

    public string debugText = "";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void addCard(){
        cardCount++;
    }

    public void delCard()
    {
        cardCount--;
    }

    public bool CheckCard()
    {
        
         
         cardCount = 0;
         int cType =-1;

       for(int i=0 ; i<transform.childCount ; i++)
       {
           if(transform.GetChild(i).gameObject.activeSelf)
           {
               cardCount++;

               if(cType == -1) cType =  transform.GetChild(i).GetChild(0).gameObject.GetComponent<GroupGame>().cardType;

             if(cType != transform.GetChild(i).GetChild(0).gameObject.GetComponent<GroupGame>().cardType){
                 
                 debugText = "" + " จับกลุ่มไม่ถูกต้อง";
                 return false;
             }
            
           }

       }
       

               if(cardCount != maxAnswer)
        {
            debugText = debugText + " จำนวนการ์ดที่ไม่ถูกต้อง : " + cardCount;
            return false;
        }
       return true;
    }


}
