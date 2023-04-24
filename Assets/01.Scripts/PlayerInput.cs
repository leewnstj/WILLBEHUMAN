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
    public UnityEvent OnJumpEvent;
    public UnityEvent<float> OnWallClimingEvent;

    private float x;

    private void Update()
    {
        Movement();
        Dash();
        Jump();
        WallCheck();
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

    private void Jump()
    {
        OnJumpEvent?.Invoke();
    }

    private void WallCheck()
    {
        OnWallClimingEvent?.Invoke(x);
    }
}
