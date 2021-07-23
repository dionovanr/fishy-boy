using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyFollow : MonoBehaviour
{
    private Transform player;
    private float distance;
    public float speed;
    public float jarak;

    private void Start()
    {
        player = GameObject.FindGameObjectWithTag("Player").transform;
    }

    private void Update()
    {
        KejarPlayer();
    }

    void KejarPlayer()
    {
        distance = Vector3.Distance(player.position, transform.position);

        if (distance <= jarak)
        {
            transform.LookAt(player);
            GetComponent<Rigidbody>().AddForce(transform.forward * speed);
        }
    }
}
