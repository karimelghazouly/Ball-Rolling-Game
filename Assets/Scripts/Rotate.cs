using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotate : MonoBehaviour {

	private Vector3 rot = new Vector3(45,30,10);
	void Update()
	{
		transform.Rotate (rot * Time.deltaTime);
	}
		
}
