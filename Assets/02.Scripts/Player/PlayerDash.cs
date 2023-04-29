using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerDash : EntityProperty
{
    [Header("´ë½¬")]
    [SerializeField] private float _dashPower;
    [SerializeField] private float _dashCoolTime;

    public bool isDash = false;

    public float _currentDashTime;

    protected override void Awake()
    {
        _rigid = transform.parent.GetComponent<Rigidbody2D>();
        base.Awake();
    }
    public void OnDash(float inputX)
    {
        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isDash = true;
            _currentDashTime = _dashCoolTime;
            _rigid.velocity = Vector2.zero;
            _rigid.gravityScale = 0;
        }

        if (isDash)
        {
            _rigid.velocity = transform.right * inputX * _dashPower;
            _currentDashTime -= Time.deltaTime;
            if (_currentDashTime <= 0)
            {
                isDash = false;
                _rigid.gravityScale = 5;
            }
        }
    }
}
