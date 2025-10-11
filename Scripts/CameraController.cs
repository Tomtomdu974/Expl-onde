using UnityEngine;

public class CameraController : MonoBehaviour
{
    [SerializeField] private Transform followTarget;
    [SerializeField] private Transform lookAtTarget;
    [SerializeField] private float followSpeed = 5f;

    private void LateUpdate()
    {
        Vector3 targetPosition = followTarget.position;

        transform.position = Vector3.Lerp(transform.position, targetPosition, followSpeed * Time.deltaTime);

        transform.LookAt(lookAtTarget);
    }
}
