using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class input : MonoBehaviour
{
    CharacterController controller;
    Vector2 movementVector;
    bool isSprinting = false;
    // Start is called before the first frame update
    void Start()
    {
        controller = GetComponent<CharacterController>();
    }

    // Update is called once per frame
    void Update()
    {

        Animator animator = GetComponentInChildren<Animator>();
        if (Input.GetKeyDown(KeyCode.W))
        {
            animator.SetFloat("characterSpeed", 2);
            movementVector.y += 1;
        }
        if (Input.GetKeyUp(KeyCode.W))
        {
            animator.SetFloat("characterSpeed", 0);
            movementVector.y -= 1;
        }

        if (Input.GetKeyDown(KeyCode.S))
        {
            animator.SetFloat("characterSpeed", 2);
            movementVector.y -= 1;
        }
        if (Input.GetKeyUp(KeyCode.S))
        {
            animator.SetFloat("characterSpeed", 0);
            movementVector.y += 1;
        }

        if (Input.GetKeyDown(KeyCode.A))
        {
            animator.SetFloat("characterSpeed", 2);
            movementVector.x += 1;
        }
        if (Input.GetKeyUp(KeyCode.A))
        {
            animator.SetFloat("characterSpeed", 0);
            movementVector.x -= 1;
        }

        if (Input.GetKeyDown(KeyCode.D))
        {
            animator.SetFloat("characterSpeed", 2);
            movementVector.x -= 1;
        }
        if (Input.GetKeyUp(KeyCode.D))
        {
            animator.SetFloat("characterSpeed", 0);
            movementVector.x += 1;
        }

        if (Input.GetKeyDown(KeyCode.LeftShift))
        {
            isSprinting = true;
        }
        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            isSprinting = false;
        }


        if (Input.GetKeyDown(KeyCode.E))
        {

            animator.SetBool("isPickingUp", true);
        }
        if (Input.GetKeyUp(KeyCode.E))
        {
            animator.SetBool("isPickingUp", false);
        }

        ProcessMove(new Vector2(movementVector.x, movementVector.y));


    }

    void ProcessMove(Vector2 Input)
    {
        Vector3 moveDirection = Vector3.zero;
        moveDirection.x = Input.x;
        moveDirection.z = Input.y;
        if(isSprinting)
        {
            controller.Move(transform.TransformDirection(moveDirection) * 8 * Time.deltaTime);
        }
        else
        {
            controller.Move(transform.TransformDirection(moveDirection) * 4 * Time.deltaTime);
        }
    }
}
