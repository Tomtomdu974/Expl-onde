using UnityEngine;

public class Scroller : MonoBehaviour
{
    [SerializeField] float moveSpeed = 0.5f;

    void Update()
    {
        transform.Translate(Vector3.forward * moveSpeed * Time.deltaTime);
    }
}
