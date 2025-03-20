using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{

    private float xAxis;
    private float yAxis;

    public float xAxisTurnRate = 360f;
    public float yAxisTurnRate = 360f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    public void LateUpdate()
    {
        float xAxisInput = Input.GetAxis("Mouse Y");
        float yAxisInput = Input.GetAxis("Mouse X");

        xAxis -= xAxisInput * xAxisTurnRate * Time.deltaTime;
        xAxis = Mathf.Clamp(xAxis, -90f, 80f);
        yAxis += yAxisInput * yAxisTurnRate * Time.deltaTime;

        Quaternion newRotation = Quaternion.Euler(xAxis, yAxis, 0f);

        Camera.main.transform.rotation = newRotation;
    }
}
