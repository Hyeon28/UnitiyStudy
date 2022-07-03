using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objectSpawner : MonoBehaviour
{
    [SerializeField]
    private GameObject boxPrefab;

    //instantiate : original 게임 오브젝트를 복제해서 생성
    private void Awake()
    {
        Quaternion rotation = Quaternion.Euler(0, 0, 45);
        //Instantiate(boxPrefab, new Vector3(3, 3, 0), rotation);

        GameObject clone = Instantiate(boxPrefab, Vector3.zero, rotation);

        clone.name = "box001";
        clone.GetComponent<SpriteRenderer>().color = Color.black;
        clone.transform.position = new Vector3(2, 1, 0);
        clone.transform.localScale = new Vector3(3, 2, 1);
    }
}
