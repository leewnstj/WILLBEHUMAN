using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class LayShoot : MonoBehaviour, ICheckLayerName
{
    [SerializeField] protected Direction _direction;
    [SerializeField] protected LayerMask _whatCheck;
    [field : SerializeField] protected float _layDistance { get; private set; }
    public bool isGround { get ; set; }

    protected Vector2 _dir;
    protected Rigidbody2D _rigid;

    protected virtual void Awake()
    {
        _rigid = GetComponent<Rigidbody2D>();

        switch (_direction)
        {
            case Direction.Left:
                _dir = Vector2.left;
                break;
            case Direction.Right:
                _dir = Vector2.right;
                break;
            case Direction.Up:
                _dir = Vector2.up;
                break;
            case Direction.Down:
                _dir = Vector2.down;
                break;
        }
    }

    protected virtual void Update()
    {

        ShootLayer();

    }

    public virtual void ShootLayer()
    {
        isGround = Physics2D.Raycast(transform.position, _dir, _layDistance, _whatCheck);
    }
}
