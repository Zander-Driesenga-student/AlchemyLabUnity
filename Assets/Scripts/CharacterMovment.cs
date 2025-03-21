using JetBrains.Annotations;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEngine;

public class CharacterMovment : MonoBehaviour
{
    CharacterController characterController;

    public float moveSpeed = 5f;
    float sprint;
    float baseSpeed;
    public bool canSprint;
    private Vector3 moveDirection;
    // Start is called before the first frame update
    void Start()
    {
        characterController = FindAnyObjectByType<CharacterController>();
        baseSpeed = moveSpeed;
        sprint = moveSpeed * 2;
    }

    // Update is called once per frame
    void Update()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float rightInput = Input.GetAxis("Horizontal");


        moveDirection.Normalize();
        moveDirection.y = -1f;
        
        if (Input.GetKey(KeyCode.LeftShift) & canSprint)
        {
            moveSpeed = sprint;
        }

        characterController.Move(moveDirection * moveSpeed * Time.deltaTime);

        if (Input.GetKeyUp(KeyCode.LeftShift))
        {
            moveSpeed = baseSpeed;
        }
    }
    public void AddMoveInput(float forwardInput, float rightInput)
    {
        Vector3 forward = Camera.main.transform.forward;
        Vector3 right = Camera.main.transform.right;

        forward.y = 0f;
        right.y = 0f;

        forward.Normalize();
        right.Normalize();

        moveDirection = (forwardInput * forward) + (rightInput * right);
    }
}
