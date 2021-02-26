using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class cameraCTL : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void LateUpdate()
    {
        Vector3 mousePos = Input.mousePosition;
        Debug.Log(mousePos);
        if(mousePos.x < 200)
        {
            KeyDown_A();
        }
        if(mousePos.x > 1080)
        {
            KeyDown_D();
        }
        if(mousePos.y < 200)
        {
            KeyDown_S();
        }
        if(mousePos.y > 520)
        {
            KeyDown_W();
        }
//        if(mousePos.x > )
/*        if(Input.GetKeyDown(KeyCode.W))
        {
            KeyDown_W();
        }
        if(Input.GetKeyDown(KeyCode.A))
        {
            KeyDown_A();
        }
        if(Input.GetKeyDown(KeyCode.S))
        {
            KeyDown_S();
        }
        if(Input.GetKeyDown(KeyCode.D))
        {
            KeyDown_D();
        }*/

    }
    void KeyDown_A()
    {
        Debug.Log("A");
        transform.position = transform.position + ( new Vector3(-1.0f, 0.0f, 0.0f) );
    }
    void KeyDown_S()
    {
        Debug.Log("S");
        transform.position = transform.position + ( new Vector3(0.0f, -1.0f, 0.0f) );
    }
    void KeyDown_W()
    {
        Debug.Log("W");
        transform.position = transform.position + ( new Vector3(0.0f, 1.0f, 0.0f) );
    }
    void KeyDown_D()
    {
        Debug.Log("D");
        transform.position = transform.position + ( new Vector3(1.0f, 0.0f, 0.0f) );
    }
}
