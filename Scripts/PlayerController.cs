using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float moveSpeed = 5f;
    private CharacterController characterController;

    void Start()
    {
        characterController = GetComponent<CharacterController>();
    }

    public void Move(Vector2 moveDirection)
    {
        Vector3 move = transform.right * moveDirection.y;
        move = move * moveSpeed * Time.deltaTime;
        characterController.Move(move);
    }
}