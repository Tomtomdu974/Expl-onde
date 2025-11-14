using UnityEngine;
using TMPro;
using System.Collections;

public class Transistor : MonoBehaviour
{
    [SerializeField] private GameObject transistorPrefab;

    IEnumerator spawnTransistor()
    {
        float spawnInterval = Random.Range(0.5f, 3f);
        yield return new WaitForSeconds(spawnInterval);
        GameObject go = Instantiate(transistorPrefab, transform.position, Quaternion.identity);
        go.GetComponent<Transistor>();
        StartCoroutine(spawnTransistor());
    }

    private void OnEnable()
    {
        StartCoroutine(spawnTransistor());
    }

    private void OnDisable()
    {
        StopAllCoroutines();
    }
}
