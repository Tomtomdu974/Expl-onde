using UnityEngine;

public class GameController_1 : MonoBehaviour
{
    public static GameController_1 Instance;

    [SerializeField] private GameObject[] Lanes_2Prefabs;
    [SerializeField] private GameObject[] LanesOfStage;

    private GameObject Sphere;

    private float LaneSize;
    private int NumberOfLanes = 3;

    private void Awake()
    {
        if (Instance != null)
        {
            Destroy(gameObject);
        }

        Instance = this;
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Sphere = GameObject.Find("Sphere");

        LanesOfStage = new GameObject[NumberOfLanes];

        for (int i = 0; i < NumberOfLanes; i++)
        {
            int n = Random.Range(0, Lanes_2Prefabs.Length);
            LanesOfStage[i] = Instantiate(Lanes_2Prefabs[n]);
        }

        LaneSize = LanesOfStage[0].GetComponent<Transform>().Find("Lane_1").localScale.z; // Récupère la scale Z du Lane

        float pos = Sphere.transform.position.z + LaneSize / 2 - 1.5f;
        foreach (var lane in LanesOfStage)
        {
            lane.transform.position = new Vector3(0, 0, pos);
            pos += LaneSize;
        }
    }

    // Update is called once per frame
    void Update()
    {

    }

    private void OnDestroy()
    {
        Instance = null;
    }
}
