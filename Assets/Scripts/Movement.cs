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
        prevPosition = _player.transform.position;
        Transform playerTransform = _player.transform;
        Vector3 playerPos = playerTransform.position;
        playerPos=new Vector3(playerPos.x+ (_movementInput.x),playerPos.y,playerPos.z+ (_movementInput.z));
        playerTransform.position = playerPos;
    }

    private void MoveBack()
    {
        _player.transform.position = prevPosition;
    }
}
