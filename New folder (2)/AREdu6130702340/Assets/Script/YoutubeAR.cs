using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class YoutubeAR : MonoBehaviour
{

    public string youtubeid;

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

    public void Play()
    {
        if(!yplayer.activeSelf){
        yplayer.SetActive(true);
        y.Play(youtubeid);
        }

       //PopupYoutube.FullYoutubeView(youtubeid);
       // PopupYoutube.CustomYoutubeView(youtubeid,true,false,true,800,400);
    }


    public void Stop()
    {
        y.Stop();
        yplayer.SetActive(false);
       //PopupYoutube.FullYoutubeView(youtubeid);
       // PopupYoutube.CustomYoutubeView(youtubeid,true,false,true,800,400);
    }

}
