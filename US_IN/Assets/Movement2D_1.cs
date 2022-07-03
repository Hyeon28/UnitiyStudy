using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement2D_1 : MonoBehaviour
{
    private float moveSpeed = 5.0f;
    private Rigidbody2D rigid2D;

    private void Awake()
    {
        rigid2D = GetComponent<Rigidbody2D>();
    }
    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        float y = Input.GetAxisRaw("Vertical");

        rigid2D.velocity = new Vector3(x, y, 0) * moveSpeed;
    }
}
