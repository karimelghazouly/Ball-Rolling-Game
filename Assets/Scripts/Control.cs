using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Control : MonoBehaviour {
	public Text count;
	public int counter = 0;
	Rigidbody RD;
	float speed = 10;
	void Start () {
		RD = GetComponent<Rigidbody> ();
		counter = 0;
		count.text = "Score: " + counter.ToString();
	}

	void Update () {
		float X = Input.GetAxis ("Horizontal");
		float Z = Input.GetAxis ("Vertical");
		Vector3 vec = new Vector3 (X,0.0f,Z);
		RD.AddForce (vec * speed);
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Pick Up")) {
			DestroyObject (other.gameObject);
			counter++;
			count.text = "Score: " + counter.ToString ();
		}
	}
}
