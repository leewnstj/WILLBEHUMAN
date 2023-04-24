using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMove : EntityProperty, IPlayerSize
{
    [SerializeField] private float _playerSpeed = 5f;

    [field:SerializeField] public float LocalScaleX { get; set; }
    [field:SerializeField] public float LocalScaleY { get; set; }

    public void OnMovement(float x)
    {
            _rigid.velocity = new Vector2(x * _playerSpeed, _rigid.velocity.y);

            transform.localScale = x switch
            {
                1  => new Vector3(LocalScaleX, LocalScaleY),
                -1 => new Vector3(-LocalScaleX, LocalScaleY),
                _  => transform.localScale
            };
    }
}
