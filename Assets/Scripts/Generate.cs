using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Generate : MonoBehaviour {

	public GameObject bonus;
	public GameObject player;
	public GameObject ground;
	private float lastx;
	private float last_floor_z = -25;
	private float last_bonus_z = -25;
	void Start () {
		
	}

	
	// Update is called once per frame
	void Update () {
		Vector3 player_pos = player.transform.position;
		if (last_floor_z < player_pos.z) {
			last_floor_z += 25;
			Vector3 randvec = new Vector3 (0.0f, 0.0f, last_floor_z);
			Quaternion rot = ground.transform.rotation;
			Instantiate (ground, randvec ,rot);
			Debug.Log (randvec);
			float nextfloorZ = last_floor_z+25;
			randvec = new Vector3 (0.0f, 0.0f, nextfloorZ);
			rot = ground.transform.rotation;
			Instantiate (ground, randvec ,rot);
			Debug.Log (randvec);
		}
		if (last_bonus_z < player_pos.z) {
			last_bonus_z += 25;
			Vector3 randvec = new Vector3 (Random.Range(-10,10),1, last_bonus_z);
			Quaternion rot = new Quaternion (Random.Range (-10, 10), Random.Range (-20, 50), Random.Range (-15, 50), Random.Range (-40, 30));
			Instantiate (bonus, randvec ,rot);
		}
	}
}
