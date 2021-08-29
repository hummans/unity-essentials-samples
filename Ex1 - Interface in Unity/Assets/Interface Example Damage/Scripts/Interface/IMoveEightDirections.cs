using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IMoveEightDirections
{
    public int _movementSpeed {get; set;}
    public Vector2 _moveDirection{get;set;}

    public void MovePlayer();
}
