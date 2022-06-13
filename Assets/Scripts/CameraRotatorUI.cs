using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;
using UnityEngine.UI;

public class CameraRotatorUI : MonoBehaviour
{
    public CameraRotator rotator;
    public Button button;

    void Start()
    {
        button.onClick.AddListener(() =>
        {
            SetText();
            rotator.SetModes();
        });
    }
    
    private void SetText()
    {
        switch (rotator.IsAuto)
        {
            case true:
                button.GetComponent<ButtonText>().text.text = "Ручной";
                break;
            case false:
                button.GetComponent<ButtonText>().text.text = "Авто";
                break;
        }
    }
}
