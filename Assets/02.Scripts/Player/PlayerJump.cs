using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : LayShoot
{
    [SerializeField] private float _jumpForce;
    public void OnJump()
    {
        if(isGround && Input.GetKeyDown(KeyCode.Space))
        {
            _rigid.velocity = new Vector2(_rigid.velocity.x, _jumpForce);
        }
    }
}
