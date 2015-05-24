using UnityEngine;
using System.Collections;

public class EnemyMovementLinear : MonoBehaviour {

	float timer = 0f;
	public float timer2;
	float MoveUp = 1f;
	float MoveLeft = 1f;
	float MoveRight = 1f;

	public int rotatespeed = 1f;
	public int movementspeed = 1f; 

	public GameObject Robotl;
	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {
		if (timer <= 0 ) {
			MoveUp = MoveUp * -1f;
			Robotl.GetComponent<Rigidbody>().velocity = new Vector3 (1f, 0f, 0f);
			Robotl.GetComponent<Rigidbody>().velocity = new Vector3 (0f, MoveUp, 0f);
			timer = 1.5f;
			
		}
	}

	void FixedUpdate () {
		timer -= .02f;

	
}
}