using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSpawner_1 : MonoBehaviour
{
    /*

    [SerializeField]
    private GameObject boxPrefab;
    회전하는 박스 생성
    private void Awake()
    {
        for (int i = 0; i < 10; i++) 
        {
            Vector3 position = new Vector3(-4.5f + i, 0, 0);
            Quaternion rotation = Quaternion.Euler(0, 0, i * 10);

            Instantiate(boxPrefab, position, rotation);
        }
    }
    

    격자무늬 생성
    private void Awake()
    {
        for (int y = 0; y < 10; ++y)
        {
            for (int x = 0; x < 10; ++x)
            {

                //대각선 비우기
                if(x == y || x + y == 9)
                {
                    continue;
                }
                

                Vector3 position = new Vector3(-4.5f + x, 4.5f-y, 0);

                Instantiate(boxPrefab, position, Quaternion.identity);
            }
        }
    }
    


    [SerializeField]
    private GameObject[] prefabArray;

    private void Awake()
    {
        for (int i = 0; i < 10; ++i)
        {
            int index = Random.Range(0, prefabArray.Length);
            Vector3 position = new Vector3(-4.5f + i, 0, 0);

            Instantiate(prefabArray[index], position, Quaternion.identity);
        }
    }
    */

    [SerializeField]
    private int objectSpawnerCount = 30;
    [SerializeField]
    private GameObject[] prefabArray;
  
   
    private void Awake()
    {
        for (int i = 0; i < objectSpawnerCount; ++i)
        {
            int index = Random.Range(0, prefabArray.Length);
            float x = Random.Range(-7.5f, 7.5f);
            float y = Random.Range(-4.5f, 4.5f);
            Vector3 position = new Vector3(x, y, 0);

            Instantiate(prefabArray[index], position, Quaternion.identity);
        }
    }
   
}
