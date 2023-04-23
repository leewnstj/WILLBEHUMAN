using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class EntityProperty : MonoBehaviour
{
    protected Rigidbody2D _rigid;
    protected Animator _anim;

    protected virtual void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
        _anim = GetComponent<Animator>();
    }
}

public interface IPlayerSize
{
    public float LocalScaleX { get; set; }
    public float LocalScaleY { get; set; }
}
