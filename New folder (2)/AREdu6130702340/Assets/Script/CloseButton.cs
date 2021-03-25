using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CloseButton : MonoBehaviour
{

  public  YoutubePlayer y;

  public GameObject yplayer;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void StopYoutube(){
        y.Stop();
        yplayer.SetActive(false);

    }
}
