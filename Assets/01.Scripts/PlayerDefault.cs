using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDefault : EntityProperty
{
    [Header("�뽬")]
    [SerializeField] private float _dashPower;
    [SerializeField] private float _dashCoolTime;

    public bool isDash = false;

    public float _currentDashTime;
    private float _dashDis;

    [Header("����")]
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
            _dashDis = (int)inputX;
        }    

        if (isDash)
        {
            _rigid.velocity = transform.right * _dashDis * _dashPower;
            _currentDashTime -= Time.deltaTime;
            if (_currentDashTime <= 0)
            {
                Debug.Log("DF");
                isDash = false;
                _rigid.gravityScale = 5;
            }
        }
    }

    public void OnJump()
    {
        RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.down, _jumpLayDis, _groundLayer);

        if(hit)
        {
            _rigid.velocity = new Vector2(_rigid.velocity.x, _jumpPower);
        }
    }
}