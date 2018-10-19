using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class moveScript : MonoBehaviour {

	public bool hover = true;

	public Rigidbody rb;

	// Use this for initialization
	void Start () {
		rb = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {

		if(rb.IsSleeping())
			rb.WakeUp();

		if(hover)
			rb.useGravity = false;
		else
			rb.useGravity = true;

		if(Input.GetKey("w")){
			rb.AddForce(transform.right * 10f);
		} else if(Input.GetKey("s")){
			rb.AddForce(transform.right * -10f);
		} 

	}

	void OnTriggerEnter(Collider other)
	{
		if(hover) {
			rb.AddForce(transform.up * 10f);
		}
	}
	void OnTriggerExit(Collider other)
	{
		if(hover) {
			rb.Sleep();
		}
	}
}
