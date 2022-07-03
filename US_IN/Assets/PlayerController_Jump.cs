using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController_Jump : MonoBehaviour
{
    private Move2D_Jump move2D_Jump;

    private void Awake()
    {
        move2D_Jump = GetComponent<Move2D_Jump>();
    }
    private void Update()
    {
        float x = Input.GetAxisRaw("Horizontal");
        move2D_Jump.Move(x);

        if(Input.GetKeyDown(KeyCode.Space))
        {
            move2D_Jump.Jump();
        }
        
        
        if(Input.GetKey(KeyCode.Space))
        {
            move2D_Jump.isLongjump = true; 
        }
        else
        {
            move2D_Jump.isLongjump = false;
        }
    }
}
