using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Generate : MonoBehaviour {
	List<GameObject>Grounds;
	public GameObject bonus, player, ground, wall;
	private float lastx;
	private float last_floor_z = 0, last_bonus_z = -25, last_wall = -10, wall_width, last_check = -25;
	private int idx = 0;
	private Vector3 randvec;
	Quaternion rot;
	void Start () {
		Grounds = new List<GameObject> ();
		InvokeRepeating("DestoryGround", 10.0f,10.0f);
	}
		
	void Update () {
		Vector3 player_pos = player.transform.position;
		if (last_check < player_pos.z) GenGround();
		if (last_bonus_z < player_pos.z) GenBonus();
		if (last_wall < player_pos.z) GenWall ();
	}

	void GenGround()
	{
		last_floor_z += 50;
		last_check = last_check + 25;
		randvec = new Vector3 (0.0f, 0.0f, last_floor_z);
		rot = ground.transform.rotation;
		GameObject one = (GameObject)Instantiate (ground, randvec, rot);
		last_floor_z += 50;
		randvec = new Vector3 (0.0f, 0.0f, last_floor_z);
		rot = ground.transform.rotation;
		GameObject two = (GameObject)Instantiate (ground, randvec ,rot);
		Grounds.Add (one);
		Grounds.Add (two);
	}

	void GenBonus()
	{
		last_bonus_z += 50;
		randvec = new Vector3 (Random.Range(-20,20),1.5f, last_bonus_z);
		rot = new Quaternion (Random.Range (-10, 10), Random.Range (-20, 50), Random.Range (-15, 50), Random.Range (-40, 30));
		Instantiate (bonus, randvec ,rot);
	}

	void DestoryGround()
	{
		Debug.Log ("aa");
		DestroyObject (Grounds [idx]);
		idx++;
	}

	void GenWall()
	{
		last_wall += 50;
		wall_width = Random.Range (3, 10);
		randvec = new Vector3 (Random.Range (-25 + 1 + wall_width, 25 - wall_width - 1), 0.5f, last_wall);
		rot = wall.transform.rotation;
		GameObject new_wall = Instantiate (wall, randvec ,rot);
		new_wall.transform.localScale = new Vector3 (wall_width, 1.0f, 0.2f);
	}
}
