using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    // Start is called before the first frame updatedsadadadaferewrec
    private void Awake()
    {
        Debug.Log("My First Script Awake function");
    }
    void Start()
    {
        Debug.Log("My First Script Start function");
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) || Input.GetMouseButtonDown(0)) 
        {
            Debug.Log("Update Input F is pressed");
        }

        if (Input.GetKey(KeyCode.F))
        {
            Debug.Log("Update Input F");
        }

        if (Input.GetKeyUp(KeyCode.F)) 
        {
            Debug.Log("Update Input F is released");
        }
    }

}
