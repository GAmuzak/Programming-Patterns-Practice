using UnityEngine;

public class Movement : Actionable
{
    private readonly PlayerActionHandler _player;
    private readonly Vector3 _movementInput;
    private Vector3 prevPosition;
    public Movement(PlayerActionHandler player, Vector3 movementInput)
    {
        _player = player;
        _movementInput = movementInput;
    }

    public override void Execute()
    {
        Move();
    }

    public override void Undo()
    {
        MoveBack();
    }
    
    private void Move()
    {
        Transform playerTransform = _player.transform;
        prevPosition = playerTransform.position;
        playerTransform.position = new Vector3(prevPosition.x+ (_movementInput.x),prevPosition.y,prevPosition.z+ (_movementInput.z));
        
    }

    private void MoveBack()
    {
        _player.transform.position = prevPosition;
    }
}
