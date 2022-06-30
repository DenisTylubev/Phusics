
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CamRotation : MonoBehaviour
{
    Quaternion origRoyayion;
    float angleHorizontal;
    public float mouseSpeed;
    private void Start()
    {
        origRoyayion = transform.rotation;
        Cursor.lockState = CursorLockMode.Locked;

    }
    private void FixedUpdate()
    {
        angleHorizontal += Input.GetAxis("Mouse X") * mouseSpeed;
        Quaternion rotationX = Quaternion.AngleAxis(angleHorizontal, Vector3.up);
        transform.rotation = origRoyayion  * rotationX;
    }
}
