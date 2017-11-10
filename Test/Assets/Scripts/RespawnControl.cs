using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RespawnControl : MonoBehaviour {

    public Transform spawnPoint;

    private Rigidbody rb;
    private Transform thisTransform;

	// Use this for initialization
	void Start () {

        thisTransform = GetComponent<Transform>();
        rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetButton("Cancel")) //Revise and debug
        {
            Respawn();
        }

	}

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.tag == "Hazard")
        {
            Respawn();
        }
    }

    private void Respawn()
    {
        thisTransform.position = spawnPoint.position;
        rb.velocity = Vector3.zero;
        rb.angularVelocity = Vector3.zero;
    }
}
