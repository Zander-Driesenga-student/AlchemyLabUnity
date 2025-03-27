using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    FirstPersonCamera firstPersonCamera;
    CharacterMovment characterMovement;
    PlayerInteraction playerInteraction;

    // Start is called before the first frame update
    void Start()
    {
        firstPersonCamera = FindAnyObjectByType<FirstPersonCamera>();
        characterMovement = FindAnyObjectByType<CharacterMovment>();
        playerInteraction = FindAnyObjectByType<PlayerInteraction>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleCameraInput();
        HandleCharacterMovement();
        HandleInteractionInput();
    }

    void HandleCameraInput()
    {
        firstPersonCamera.AddXAxisInput(Input.GetAxis("Mouse Y") * Time.deltaTime);
        firstPersonCamera.AddYAxisInput(Input.GetAxis("Mouse X") * Time.deltaTime);
        

    }
    
    void HandleCharacterMovement()
    {
        float forwardInput = Input.GetAxis("Vertical");
        float rightInput = Input.GetAxis("Horizontal");

        characterMovement.AddMoveInput(forwardInput, rightInput);
    }

    void HandleInteractionInput()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            playerInteraction.TryInteract();
        }
    }
}
