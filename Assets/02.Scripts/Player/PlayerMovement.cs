using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : LayShoot
{
    [SerializeField] private float _playerSpeed;

    protected override void Awake()
    {
        _rigid = transform.parent.GetComponent<Rigidbody2D>();
        base.Awake();
    }
    public void OnMove(float x)
    {        
        if(isGround)
        {
            _rigid.velocity = new Vector2(_playerSpeed * x,_rigid.velocity.y);
        }
    }
}
