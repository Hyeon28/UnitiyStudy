using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Controller : MonoBehaviour
{
    private Animator animatior;

    private void Awake()
    {
        animatior = GetComponent<Animator>();
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            animatior.SetTrigger("isDie");
        }
    }
    public void OnDieEvent()
    {
        Debug.Log("End of Die Animation");
    }

}
