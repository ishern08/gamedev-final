using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FirstPersonCamera : MonoBehaviour
{
    private float xAxis;
    private float yAxis;
    float xAxisTurnRate = 360f;
    float yAxisTurnRate = 360f;
    public float clampAmount = 90f;
    // Start is called before the first frame update
    void Start()
    {
        Cursor.lockState = CursorLockMode.Locked;
    }

    private void OnDisable()
    {
        Cursor.lockState = CursorLockMode.None;
    }

    // Update is called once per frame
    
    void LateUpdate()
    {
        Quaternion newRotation = Quaternion.Euler(xAxis, yAxis, 0f);

        Camera.main.transform.rotation = newRotation;
    }


    public void AddXAxisInput(float input)
    {
        xAxis -= input * xAxisTurnRate;
        xAxis = Mathf.Clamp(xAxis, -clampAmount, clampAmount);
    }

    public void AddYAxisInput(float input)
    {
        yAxis += input * yAxisTurnRate;
    }
}