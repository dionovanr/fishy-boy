using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectReSpawn : MonoBehaviour
{

    public GameObject Balok;
    public Transform spawnPosition;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.name == "DZ3" || col.gameObject.tag == "Lantai")
        {
 
            StartCoroutine(RespawnObject());
            //Balok.SetActive(false);
        }   
    }

    IEnumerator RespawnObject()
    {
        yield return new WaitForSeconds(1);
        Instantiate(Balok, spawnPosition.position, Quaternion.identity);
    }
}
