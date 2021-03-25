using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    AudioSource aSource;
    // Start is called before the first frame update
    void Start()
    {
        aSource = gameObject.GetComponent<AudioSource>();
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void PlayOneShot(AudioClip clip)
    {
        aSource.PlayOneShot(clip);

    }

    public void Play()
    {

        aSource.Play();
    }
}
