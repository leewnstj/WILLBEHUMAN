using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputAgent : MonoBehaviour
{
    public UnityEvent<float> PlayerDefault;
    public UnityEvent PlayerJump;
    public UnityEvent<float> PlayerDash;

    private float x;

    private void Update()
    {
        PlayerOnMove();
        PlayerOnJump();
        PlayerOnDash();
    }

    private void PlayerOnDash()
    {
        PlayerDash?.Invoke(x);
    }

    private void PlayerOnMove()
    {
        x = Input.GetAxisRaw("Horizontal");
        PlayerDefault?.Invoke(x);
    }

    private void PlayerOnJump()
    {
        PlayerJump?.Invoke();
    }
}
