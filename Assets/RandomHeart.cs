using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RandomHeart : MonoBehaviour
{
    [SerializeField] Mover prefabToSpawn;
    [SerializeField] Vector3 velocityOfSpawnedObject;
    [Tooltip("Minimum time between consecutive spawns, in seconds")]
    [SerializeField] float minTimeBetweenSpawns = 5f;
    [Tooltip("Maximum time between consecutive spawns, in seconds")]
    [SerializeField] float maxTimeBetweenSpawns = 20f;
    [Tooltip("Maximum distance in X between spawner and spawned objects, in meters")]
    [SerializeField] float maxXDistance = 3f;
    [Tooltip("Maximum distance in Y between spawner and spawned objects, in meters")]
    [SerializeField] float maxYDistance = 3f;
    void Start()
    {
        this.StartCoroutine(SpawnRoutine());    // co-routines
        // _ = SpawnRoutine();                   // async-await
    }

    IEnumerator SpawnRoutine()
    {// co-routines
        while (true)
        {
            float timeBetweenSpawnsInSeconds = Random.Range(minTimeBetweenSpawns, maxTimeBetweenSpawns);
            yield return new WaitForSeconds(timeBetweenSpawnsInSeconds);       // co-routines
            // await Task.Delay((int)(timeBetweenSpawnsInSeconds*1000));       // async-await
            Vector3 positionOfSpawnedObject = new Vector3(
                transform.position.x + Random.Range(-maxXDistance, +maxXDistance),
                transform.position.y + Random.Range(-maxYDistance, +maxYDistance),
                transform.position.z);
            GameObject newObject = Instantiate(prefabToSpawn.gameObject, positionOfSpawnedObject, Quaternion.identity);
            newObject.GetComponent<Mover>().SetVelocity(velocityOfSpawnedObject);
        }
    }
}
