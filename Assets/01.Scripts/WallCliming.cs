using UnityEngine;

public class WallCliming : EntityProperty
{
    [SerializeField] private float _layerDis;
    [SerializeField] private LayerMask _whatGround;
    [SerializeField] private float _wallJumpPower;

    public bool isWall;

    public void WallCheck(float x)
    {
        isWall = Physics2D.Raycast(transform.position, Vector2.right * x, _layerDis, _whatGround);

        if(isWall && _rigid.velocity.y != 0)
        {
            _rigid.velocity = new Vector2(0, 0);
            _rigid.gravityScale = 0.3f;
        }
        else
        {
            _rigid.gravityScale = _currentGravityScale;
        }
    }

    public void WallJump()
    {
        if(isWall && Input.GetKeyDown(KeyCode.Space)) 
        {
            
        }
    }
}
