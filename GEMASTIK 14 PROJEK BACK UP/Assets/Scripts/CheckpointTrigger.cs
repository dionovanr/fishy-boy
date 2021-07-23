using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckpointTrigger : MonoBehaviour
{
    public Transform Checkpoint;
    GameObject Player;

    // Start is called before the first frame update
    void Start()
    {
        Player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private void OnTriggerEnter(Collider col)
    {
        if (col.gameObject.tag == "Player"  || Player.gameObject.tag == "Obstacle")
        {
            Player.transform.position = Checkpoint.position;
            Player.transform.rotation = Checkpoint.rotation;
        }
    }
}
