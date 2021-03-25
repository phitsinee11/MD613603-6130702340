using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    int score = 5;
Rigidbody rb;

public bool isLeft = false;

public bool isRight = false;

    // Start is called before the first frame update
    void Start()
    {
rb = gameObject.GetComponent<Rigidbody>();

        int money = 1000;
    if (score>10){
        Debug.Log("Win");
    }
    else
    {
        Debug.Log("Lose");
    }
    for (int i = 0;i<10;i++){
Debug.Log(i);
    }
    while (money>0){
        money = money -10;
        Debug.Log(money);
    }
    
    }

    // Update is called once per frame
    void Update()
    {
    //  Test(); 
    if (Input.GetKeyDown("w"))
        {
            Debug.Log("w");
            rb.AddForce(Vector3.forward*100);
        }    
        if (Input.GetKeyDown("a"))
        {
            Debug.Log("a");
            rb.AddForce(Vector3.left*100);
        }    
        if (Input.GetKeyDown("d"))
        {
            Debug.Log("d");
            rb.AddForce(Vector3.right*100);
        }    
        if (Input.GetKeyDown("s"))
        {
            Debug.Log("s");
            rb.AddForce(Vector3.back*100);
        }    
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("space");
            rb.AddForce(Vector3.up*100);
        }    

if(isLeft){
    rb.AddForce(Vector3.left*100);
}

if (isRight){
    rb.AddForce(Vector3.right*100);
}

    }

    void Test()
    {
        score =score+1;
Debug.Log("Test"+score); 

    }

public void Jump(){
    rb.AddForce(Vector3.up*100);
}

public void Left(bool b){
isLeft=b;
}

public void Right(bool b){
isRight=b;
}

}
