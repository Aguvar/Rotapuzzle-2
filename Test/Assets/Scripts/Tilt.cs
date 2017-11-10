using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tilt : MonoBehaviour {

    public float interpolationStep;
    private Rigidbody rb;

	// Use this for initialization
	void Start () {

        rb = GetComponent<Rigidbody>();

	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void FixedUpdate()
    {
        float tiltZ = Input.GetAxis("Horizontal");

        float tiltX = Input.GetAxis("Vertical");

        rb.rotation = Quaternion.Lerp(rb.rotation,Quaternion.Euler(tiltX * -30, 0.0f, tiltZ * 30), interpolationStep * Time.fixedDeltaTime);
        
    }
}
