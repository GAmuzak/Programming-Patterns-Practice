using System.Collections;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerActionHandler : MonoBehaviour
{
    [SerializeField] private float moveCoolDown=1;
    
    private GameManager gameManager;
    private Vector3 movementInput;
    private bool canMove=true;
    
    private void Start()
    {
        gameManager=GameManager.Instance;
    }
    
    public void OnMovementInput(InputAction.CallbackContext ctx)
    {
        Vector2 movementInput2d = ctx.ReadValue<Vector2>();
        movementInput2d=movementInput2d.normalized;
        movementInput = new Vector3(movementInput2d.x*10, 0, movementInput2d.y*10);
        UpdatePosition();
    }

    private void UpdatePosition()
    {
        if (!canMove) return;
        Debug.Log("HELLOOOOOO");
        Vector3 playerPos = transform.position;
        playerPos=new Vector3(playerPos.x+ (movementInput.x),playerPos.y,playerPos.z+ (movementInput.z));
        transform.position = playerPos;
        canMove = false;
        StartCoroutine(MoveCoolDown());
    }

    private IEnumerator MoveCoolDown()
    {
        yield return new WaitForSeconds(moveCoolDown);
        canMove = true;
    }
}
