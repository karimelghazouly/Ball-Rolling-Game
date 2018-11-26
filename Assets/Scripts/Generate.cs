using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {

	public GameObject bonus;
	void Start () {
		for (int i = 0; i < 100; i++) {
			float x = Random.Range (-24, 24);
			float z = Random.Range (-24, 24);
			Vector3 randvec = new Vector3 (x, 0.5f, z);
			Quaternion rot = new Quaternion ( Random.Range (-24, 24),  Random.Range (-24, 25),  Random.Range (-25, 25), Random.Range (-25, 25));
			Instantiate (bonus, randvec, rot);
		}
	}

	
	// Update is called once per frame
	void Update () {
		
	}
}
