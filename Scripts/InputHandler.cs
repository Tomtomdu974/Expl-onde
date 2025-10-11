using UnityEngine;
using UnityEngine.InputSystem;

public class InputHandler : MonoBehaviour
{
    [SerializeField] PlayerController playerController;

    private InputAction moveAction;
    private InputAction lookAction;

    void Start()
    {
        moveAction = InputSystem.actions.FindAction("Move");
        lookAction = InputSystem.actions.FindAction("Look");
    }

    void Update()
    {
        Vector2 moveDirection = moveAction.ReadValue<Vector2>();

        Vector2 lookDirection = lookAction.ReadValue<Vector2>();

        playerController.Move(moveDirection);
    }
}
