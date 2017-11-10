using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Checkpoint : MonoBehaviour {

    public Transform flagTf;

    private Transform tf;
    private bool taken = false;


	// Use this for initialization
	void Start () {

        tf = GetComponent<Transform>();
        //flagTf = GetComponentInParent<Transform>(); Fix and get transform privately. Or not.
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnTriggerEnter(Collider other)
    {
        if (!taken)
        {
            taken = true;
            RespawnControl respawnControl = other.GetComponent<RespawnControl>();
            respawnControl.spawnPoint = tf;

            flagTf.Rotate(0.0f,180f,0.0f,Space.Self);
        }
    }
}
