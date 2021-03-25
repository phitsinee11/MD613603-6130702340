using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class QuizCheckbox : MonoBehaviour
{
    public bool checkbox;
    public bool rightAnswer;
    public Color checkColor;
    public Color unCheckColor;
    // Start is called before the first frame update
    void Start()
    {
        ChangeColor();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeCheckbox()
    {
        checkbox = !checkbox;
        ChangeColor();
    }

    private void OnMouseDown() {
        ChangeCheckbox();
    }

    void ChangeColor()
    {
       Renderer  cubeRenderer = GetComponent<Renderer>();
        if(checkbox){
        cubeRenderer.material.SetColor("_Color", checkColor);
        }else{
            cubeRenderer.material.SetColor("_Color", unCheckColor);
        }
       
    }

    public bool CheckAnswer()
    {
        return rightAnswer == checkbox;
    }
}
