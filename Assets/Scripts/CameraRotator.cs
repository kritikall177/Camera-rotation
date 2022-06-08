using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class CameraRotator : MonoBehaviour
{
    public GameObject button;
    private bool _modes = true;
    private const float Duration = 30f;

    private Rigidbody _rigidbody;

    private void Start()
    {
        _rigidbody = GetComponent<Rigidbody>();
        Rotate360();
        button.GetComponent<ButtonController>().ClickOnButton += SetModes;
    }
    
    void Update()
    {
        if (!_modes)
        {
            transform.DOKill();
            var directionForce = new Vector3(0.0f, -Input.GetAxisRaw("Horizontal"), 0.0f);
            _rigidbody.AddTorque(directionForce, ForceMode.Force);
        }
    }

    private void SetModes()
    {
        switch (_modes)
        {
            case true:
                _modes = false;
                break;
            case false:
                _modes = true;
                Rotate360();
                break;
        }
    }

    private void Rotate360()
    {
        transform.DORotate(new Vector3(0, -360, 0), Duration, RotateMode.FastBeyond360).SetLoops(-1, LoopType.Restart);
    }
}
