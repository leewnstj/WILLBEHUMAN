using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EntityProperty : MonoBehaviour
{
    protected Rigidbody2D _rigid;

    protected virtual void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();
    }
}
