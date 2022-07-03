using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSpawner_2 : MonoBehaviour
{
    [SerializeField]
    private int objectSpawnerCount = 30;
    [SerializeField]
    private GameObject[] prefabArray;
    [SerializeField]
    private Transform[] spawnPointArray;
    private int currentObjectCount;
    private float objectSpawnTime = 0.0f;
    /*
    private void Awake()
    {
        for (int i = 0; i < objectSpawnerCount; ++i)
        {
            int prefabIndex = Random.Range(0, prefabArray.Length);
            int spawnIndex = Random.Range(0, spawnPointArray.Length);

            Vector3 position = spawnPointArray[spawnIndex].position;
            GameObject clone = Instantiate(prefabArray[prefabIndex], position, Quaternion.identity);

            Vector3 moveDirection = (spawnIndex == 0 ? Vector3.right : Vector3.left);
            clone.GetComponent<Movement2D>().Setup(moveDirection);
        }
    }
    */
    
    //0.5초마다 생성
    private void Update()
    {
        //spawncount 개수만큼만 생성
        if (currentObjectCount + 1 > objectSpawnerCount)
        {
            return;
        }

        objectSpawnTime += Time.deltaTime;

        if (objectSpawnTime >= 0.5f)
        {
            int prefabIndex = Random.Range(0, prefabArray.Length);
            int spawnIndex = Random.Range(0, spawnPointArray.Length);

            Vector3 position = spawnPointArray[spawnIndex].position;
            GameObject clone = Instantiate(prefabArray[prefabIndex], position, Quaternion.identity);

            Vector3 moveDirection = (spawnIndex == 0 ? Vector3.right : Vector3.left);
            clone.GetComponent<Movement2D>().Setup(moveDirection);

            currentObjectCount++;
            objectSpawnTime = 0.0f;
        }
    }

}
