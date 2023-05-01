using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RayShoot : EntityProperty, IBoolCheck
{
    [SerializeField] protected LayerMask _whatLayer;
    [SerializeField] protected float _rayDis;
    [SerializeField] protected Vector3 _dirRay;

    protected bool RayBool;

    public bool isGround { get; set; }
    public bool isWall { get; set; }

    public bool IsGround()
    {
        isGround = Physics2D.Raycast(transform.position, _dirRay, _rayDis, _whatLayer);
        return isGround;
    }
}
