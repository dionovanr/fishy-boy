using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleSpawner : MonoBehaviour
{
    public Transform Object;
    public float waktu;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(SpawnObject());
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator SpawnObject()
    {
        yield return new WaitForSeconds(waktu);
        Instantiate(Object, transform.position, Quaternion.identity);
        StartCoroutine(SpawnObject());
    }
}
