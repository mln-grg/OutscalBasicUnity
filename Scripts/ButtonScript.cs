using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;
using UnityEngine.SceneManagement;


public class ButtonScript : MonoBehaviour
{
    public Button button;
    public string newScene;
    void Start()
    {
        button.onClick.AddListener(OnButtonClick);
    }

    private void OnButtonClick()
    {
        Debug.Log("ButtonPressed");
        SceneManager.LoadScene(newScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
