using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class InputAgent : MonoBehaviour
{
    public UnityEvent<float> PlayerDefault;
    public UnityEvent PlayerJump;

    private void Update()
    {
        PlayerDefaultResource();
        PlayerOnJump();
    }

    private void PlayerDefaultResource()
    {
        float x = Input.GetAxisRaw("Horizontal");
        PlayerDefault?.Invoke(x);
    }

    private void PlayerOnJump()
    {
        PlayerJump?.Invoke();
    }
}
