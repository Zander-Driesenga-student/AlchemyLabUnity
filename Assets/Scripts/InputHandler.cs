using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputHandler : MonoBehaviour
{
    FirstPersonCamera firstPersonCamera;
    CharacterMovment characterMovment;

    // Start is called before the first frame update
    void Start()
    {
        firstPersonCamera = FindAnyObjectByType<FirstPersonCamera>();
        characterMovment = FindAnyObjectByType<CharacterMovment>();
    }

    // Update is called once per frame
    void Update()
    {
        HandleCameraInput();
        HandleCharacterMovement();
    }

    void HandleCameraInput()
    {
        firstPersonCamera.AddXAxisInput(Input.GetAxis("Mouse Y") * Time.deltaTime);
        firstPersonCamera.AddYAxisInput(Input.GetAxis("Mouse X") * Time.deltaTime);

    }
    
    void HandleCharacterMovement()
    {

    }
}
