using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovingPlatform : MonoBehaviour
{
    public Vector3[] points;
    public int point_num = 0;
    private Vector3 currentTarget;

    public float tolerance, speed, delayTime;
    private float delayStart;
    public bool automatic;
    public Transform player;


    // Start is called before the first frame update
    void Start()
    {
        if (points.Length > 0)
        {
            currentTarget = points[0];
        }
        tolerance = speed * Time.deltaTime;
    }

    // Update is called once per frame
    void Update()
    {
        if (transform.position != currentTarget)
        {
            MovePlatform();
        }
        else
        {
            UpdateTarget();
        }
    }

    void MovePlatform()
    {
        Vector3 heading = currentTarget - transform.position;
        transform.position += (heading / heading.magnitude) * speed * Time.deltaTime;
        if (heading.magnitude < tolerance)
        {
            transform.position = currentTarget;
            delayStart = Time.time;
        }
    }

    void UpdateTarget()
    {
        if (automatic)
        {
            if(Time.time - delayStart > delayTime)
            {
                NextPlatform();
            }
        }
    }

    void NextPlatform()
    {
        point_num++;
        if(point_num >= points.Length)
        {
            point_num = 0;
        }
        currentTarget = points[point_num];
    }

    private void OnTriggerEnter(Collider other)
    {
        other.transform.parent = transform;
        if (player.gameObject.tag == "Lantai")
        {
            other.transform.parent = null;
        }
    }

    private void OnTriggerExit(Collider other)
    {
            other.transform.parent = null;
    }

}
