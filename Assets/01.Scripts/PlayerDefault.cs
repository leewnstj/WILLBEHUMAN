using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDefault : EntityProperty
{
    [Header("대쉬")]
    [SerializeField] private float _dashPower;
    [SerializeField] private float _dashCoolTime;

    public bool isDash = false;

    public float _currentDashTime;

    [Header("점프")]
    [SerializeField] private float _jumpPower;
    [SerializeField] private float _jumpLayDis;
    [SerializeField] private LayerMask _groundLayer;

    public void OnDash(float inputX)
    {
        if(Input.GetKeyDown(KeyCode.LeftShift))
        {
            isDash = true;
            _currentDashTime = _dashCoolTime;
            _rigid.velocity = Vector2.zero;
            _rigid.gravityScale = 0;
        }    

        if (isDash)
        {
            _rigid.velocity = transform.right * transform.localScale.x * _dashPower;
            _currentDashTime -= Time.deltaTime;
            if (_currentDashTime <= 0)
            {
                isDash = false;
                _rigid.gravityScale = 5;
            }
        }
    }

    public void OnJump()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, _jumpLayDis, _groundLayer);

        if(hit && Input.GetKeyDown(KeyCode.Space))
        {
            _rigid.velocity = new Vector2(_rigid.velocity.x, _jumpPower);
        }
    }
}
