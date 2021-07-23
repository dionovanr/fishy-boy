using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FreeCam : MonoBehaviour
{
    public float camRotation = 1f;
    public Transform Player, Camera;
    float mouseX, mouseY;
    public Transform PlayerCollision;

    private void LateUpdate()
    {

        CamControl();

    }

    void CamControl()
    {
        mouseX += Input.GetAxis("Mouse X") * camRotation;
        mouseY -= Input.GetAxis("Mouse Y") * camRotation;
        mouseY = Mathf.Clamp(mouseY, -35, 60);

        transform.LookAt(Camera);

        Camera.rotation = Quaternion.Euler(mouseY, mouseX, 0f);
       
    }
}
