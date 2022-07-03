using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement_2D : MonoBehaviour
{
    /* private void Awake() 
    {
    ���ο� ��ġ = ���� ��ġ + (����, �ӵ�)


    transform.position = transform.position + new Vector3(1, 0, 0) * 1;


    transform.position += Vector3.right * 1;

    Time.Deltatime : ���� Update() ������� ���� Update() ���۱����� �ð�(������Ʈ ������ �ð�)
    transform.position += Vector3.right * 1 * Time.deltaTime; 
    
    }*/

    private float moveSpeed = 5.0f;
    private Vector3 moveDirection = Vector3.zero;

    private void Update()
    {
        //Negative left, a = -1. Positive right, d : 1, Non : 0
        float x = Input.GetAxisRaw("Horizontal");
        //Negative down, s = -1. Positive Up, w : 1, Non : 0
        float y = Input.GetAxisRaw("Vertical");

        //�̵����� ����
        moveDirection = new Vector3(x, y, 0);

        transform.position += moveDirection * moveSpeed * Time.deltaTime;
    }
}

  

   


   
