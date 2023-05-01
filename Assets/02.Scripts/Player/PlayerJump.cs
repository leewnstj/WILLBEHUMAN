using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerJump : RayShoot
{
    [SerializeField] private float _jumpForce;

    protected override void Awake()
    {
        base.Awake();
        _rigid = transform.parent.GetComponent<Rigidbody2D>();
    }
    public void OnJump()
    {
        if(Input.GetKeyDown(KeyCode.Space) && IsGround())
        {
            _rigid.velocity = new Vector2(_rigid.velocity.x, _jumpForce);
        }
    }
}
