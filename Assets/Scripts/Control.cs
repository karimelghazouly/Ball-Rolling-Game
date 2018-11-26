using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Control : MonoBehaviour {

	Rigidbody RD;
	float speed = 10;
	void Start () {
		RD = GetComponent<Rigidbody> ();
	}

	void FixedUpdate () {
		float X = Input.GetAxis ("Horizontal");
		float Z = Input.GetAxis ("Vertical");
		Vector3 vec = new Vector3 (X,0.0f,Z);
		RD.AddForce (vec * speed);
	}
	void OnTriggerEnter(Collider other){
		if(other.gameObject.CompareTag("Pick Up"))
			DestroyObject (other.gameObject);
	}
}
