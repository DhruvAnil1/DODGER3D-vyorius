using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player2 : MonoBehaviour
{
    [SerializeField] WheelCollider frontRight;
    [SerializeField] WheelCollider frontLeft;
    [SerializeField] WheelCollider backRight;
    [SerializeField] WheelCollider backLeft;

    public float acceleration = 500f;
    public float breakingForce = 300f;
    public float maxTurnAngle = 15f;

    private float currentAcceleration = 0f;
    private float currentBreakForce = 0f;
    private float currentTurnAngle = 0f;

    private void FixedUpdate()
    {

        currentAcceleration = acceleration * Input.GetAxis("Vertical1");


        if (Input.GetKey(KeyCode.Space))
            currentBreakForce = breakingForce;
            else
            currentBreakForce = 0f;

            frontRight.motorTorque = currentAcceleration;
            frontLeft.motorTorque = currentAcceleration;

            frontRight.brakeTorque = currentBreakForce;
            frontLeft.brakeTorque = currentBreakForce;
            backRight.brakeTorque = currentBreakForce;
            backLeft.brakeTorque = currentBreakForce;

            currentTurnAngle = maxTurnAngle * Input.GetAxis("Horizontal1");
            frontLeft.steerAngle = currentTurnAngle;
            frontRight.steerAngle = currentTurnAngle;
    }
}
