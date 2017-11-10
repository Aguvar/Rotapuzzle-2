using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Springer : MonoBehaviour {

    public float springSpeed;
    public float triggerTime;
    public float connectedAnchorHeight;
    public float springForce;
    public float resetTime;

    private bool springed = false;
    private AudioSource aSource;

    // Use this for initialization
    void Start () {
        aSource = GetComponent<AudioSource>();
	}
	
	// Update is called once per frame
	void Update () {
		
	}

    private void OnCollisionEnter(Collision collision)
    {
        GameObject collidedObject = collision.gameObject;
        if (collidedObject.tag == "Ball" & !springed)
        {
            springed = true;

            Rigidbody rb = collidedObject.GetComponent<Rigidbody>();

            StartCoroutine(SpringUp(rb));
            aSource.Play((ulong)triggerTime);
        }
    }

    IEnumerator SpringUp(Rigidbody rb)
    {
        yield return new WaitForSeconds(triggerTime);

        rb.AddForce(new Vector3(0.0f, springForce, 0.0f));

        yield return new WaitForSeconds(resetTime);

        springed = false;

    }
}
