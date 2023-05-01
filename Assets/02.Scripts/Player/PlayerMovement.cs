using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : RayShoot
{
    [SerializeField] private float _playerSpeed;

    public float PlayerLocalScaleX;
    public float PlayerLocalScaleY;

    protected override void Awake()
    {
        _rigid = transform.parent.GetComponent<Rigidbody2D>();

        PlayerLocalScaleX = transform.parent.localScale.x;
        PlayerLocalScaleY = transform.parent.localScale.y;

        base.Awake();
    }
    public void OnMove(float x)
    {
        if (isGround)
        {
            _rigid.velocity = new Vector2(_playerSpeed * x,_rigid.velocity.y);

            transform.localScale = x switch
            {
                1  => new Vector3(PlayerLocalScaleX, PlayerLocalScaleY,0),
                -1 => new Vector3(-PlayerLocalScaleX,PlayerLocalScaleY,0),
                _  => transform.localScale
            };
        }
    }
}
