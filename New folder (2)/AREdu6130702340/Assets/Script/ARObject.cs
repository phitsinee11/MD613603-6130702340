using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ARObject : MonoBehaviour {
    public string objectType = "basic";


   // public int subType = 0;

    public GameManager gameManager;
    // Start is called before the first frame update
    void Start () {
        gameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        if(!gameManager.testMode)
        gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update () {

    }

    public void InitAR () {
        gameObject.SetActive(true);
        if (objectType == "basic") {
            GameObject pool = GameObject.Find("BasicARPool");
            transform.parent = pool.transform;
            transform.GetChild(0).GetComponent<BasicAR>().Play();

        } else if (objectType == "multichoice") {
             GameObject pool = GameObject.Find("MultiChoicePool");
            transform.parent = pool.transform;
            transform.GetChild(0).GetComponent<MultipleChoices>().Play();

        } else if (objectType == "youtube") {
            GameObject pool = GameObject.Find("YoutubePool");
            transform.parent = pool.transform;
            transform.GetChild(0).GetComponent<YoutubeAR>().Play();

        } else if (objectType == "GroupGame") {

            GameObject pool = GameObject.Find("MultiChoicePool");
            transform.parent = pool.transform;
            transform.GetChild(0).GetComponent<GroupGame>().Play();

        }
    }

    public void StopYoutube(){
        
    }
}