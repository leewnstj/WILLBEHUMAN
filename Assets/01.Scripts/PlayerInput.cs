using System;
using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;
using UnityEngine.Events;

public class PlayerInput : MonoBehaviour
{
    public UnityEvent<float> OnMoveEvent;
    public UnityEvent<float> OnDashEvent;

    private float x;

    private void Update()
    {
        Movement();
        Dash();
    }

    private void Movement()
    {
        x = Input.GetAxisRaw("Horizontal");
        OnMoveEvent?.Invoke(x);
    }

    private void Dash()
    {
        OnDashEvent?.Invoke(x);
    }
}
