using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BasicColor : MonoBehaviour
{

    public Color baseColor;
    // Start is called before the first frame update
    void Start()
    {
        var baseRender = GetComponent<Renderer>();
        baseRender.material.SetColor("_Color", baseColor);
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
