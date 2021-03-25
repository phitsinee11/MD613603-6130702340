using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Answer : MonoBehaviour
{
    public bool select;

    public bool rightAnswer;

    public Color selectColor;

    public Color unSelectColor;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown() {
        select = !select;
ChangeColor();
        
    }

    void ChangeColor()
{
if(select == true){
    var cubeRenderer = GetComponent<Renderer>();
       cubeRenderer.material.SetColor("_Color", selectColor);
    }else{
        var cubeRenderer = GetComponent<Renderer>();
       cubeRenderer.material.SetColor("_Color", unSelectColor);
    }

}

    
}
