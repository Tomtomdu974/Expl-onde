using UnityEngine;
using System.Collections;

public class Obstacle : MonoBehaviour
{
    [SerializeField] private Material[] materials;


private void Start()
    {
        materials = new Material[3];
    }

    public void setup(Color color)
    {
        //Debug.Log("Setting up obstacle color" + color);
    }
}
