using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour
{
    public GameObject player;
    public float x, y, z;

    private void Update()
    {
        transform.position = player.transform.position + new Vector3(x, y, z);
        transform.LookAt(player.transform.position);
    }
}
