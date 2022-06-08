using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class ButtonController : MonoBehaviour
{
    public Text buttonText;
    public UnityAction ClickOnButton;

    void Start()
    {
        ClickOnButton += SetText;
        GetComponent<Button>().onClick.AddListener(() =>
        {
            ClickOnButton.Invoke();
        });
        SetText();
    }
    
    private void SetText()
    {
        switch (buttonText.text == "Авто")
        {
            case true:
                buttonText.text = "Ручной";
                break;
            case false:
                buttonText.text = "Авто";
                break;
        }
    }
}
