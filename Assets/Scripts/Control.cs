using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class Control : MonoBehaviour {
	public Text count;
	public int counter = 0;
	private float X, Z;
	Rigidbody RD;
	float speed = 20;

	void Start () {
		RD = GetComponent<Rigidbody> ();
		counter = 0;
		count.text = "Score: " + counter.ToString();
	}

	void Update(){
		X = Input.GetAxis ("Horizontal");
		Z = Input.GetAxis ("Vertical");
		Vector3 vec = new Vector3 (X*speed, transform.position.y, Z*speed);
		RD.AddForce (vec);
	}
	void OnTriggerEnter(Collider other){
		if (other.gameObject.CompareTag ("Pick Up")) {
			DestroyObject (other.gameObject);
			counter++;
			count.text = "Score: " + counter.ToString ();
		}
	}
}
