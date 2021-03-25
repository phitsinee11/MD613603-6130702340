using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TouchSound : MonoBehaviour
{
    AudioSource aSound;

    public AudioClip aClip;
    // Start is called before the first frame update
    void Start()
    {
        aSound = GameObject.Find("GameManager").GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnMouseDown() {
        aSound.PlayOneShot(aClip);
    }
}
