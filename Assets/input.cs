using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        Animator animator = GetComponent<Animator>();
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetFloat("characterSpeed", 2);
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetFloat("characterSpeed", 0);
        }


        if (Input.GetKeyDown(KeyCode.E))
        {

            animator.SetBool("isPickingUp", true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            animator.SetBool("isPickingUp", false);
        }

    }
}
