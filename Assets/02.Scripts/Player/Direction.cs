using UnityEngine;

public enum Direction
{
    Left,
    Right,
    Up,
    Down
}

public interface ICheckLayerName
{
    public bool isGround { get; set; }
}