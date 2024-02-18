
using UnityEngine;

public class GroundTile : MonoBehaviour
{
    GroundSpawn groundSpawn;
    void Start()
    {
        groundSpawn = GameObject.FindObjectOfType<GroundSpawn>();
        SpawnObstacle();
    }
    private void OnTriggerExit(Collider other)
    {
        groundSpawn.SpawnTile();
        Destroy(gameObject, 0.5f);
    }
   
    void Update()
    {
        
    }
    public GameObject obstaclePrefab;

    void SpawnObstacle()
    {
        int obstacleSpawmIndex = Random.Range(2, 5);
        Transform spawnPoint = transform.GetChild(obstacleSpawmIndex).transform;
        Instantiate(obstaclePrefab, spawnPoint.position, Quaternion.identity, transform);

    }
}
