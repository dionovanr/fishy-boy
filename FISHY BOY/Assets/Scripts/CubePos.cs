using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubePos : MonoBehaviour
{
    public GameObject player;
    Rigidbody rb;

    private void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = player.transform.position;
        //transform.Rotate(0, 0, 0, Space.Self);

    }
}
