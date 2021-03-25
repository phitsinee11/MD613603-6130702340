using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicAR : MonoBehaviour
{

    public AudioClip basicAudioClip;
    public string basicText = "ข้อความแสดงเมื่อ AR ถูกส่อง";
    public GameManager mGameManager;

    public bool setSound = false;
    public bool setText = false;
    // Start is called before the first frame update
    void Start()
    {
        mGameManager = GameObject.Find("GameManager").GetComponent<GameManager>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void Play()
    {
        if(setSound && !mGameManager.aSource.isPlaying)
        mGameManager.PlaySound(basicAudioClip);
        if(setText)
        mGameManager.displayText.text = basicText;
    }
}
