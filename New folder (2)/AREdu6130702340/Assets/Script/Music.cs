using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music : MonoBehaviour
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

    public void Play()
    {
        aSource.Play();
    }
}
