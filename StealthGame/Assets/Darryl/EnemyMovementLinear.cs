using UnityEngine;
using System.Collections;

public class EnemyMovementLinear : MonoBehaviour {

	float timer = 1f;
	float timer2 = 0f;
	//public float timer2;
	public float MoveUp = 1f;
	public float MoveRight = 1f;
	public float MoveLeft = 1f;

	public int rotatespeed = 1;
	public int movementspeed = 1; 

	public GameObject Robotl;
	// Use this for initialization
	void Start () {
	
	}
	// Update is called once per frame
	void Update () {

		if (timer <= 0 ) {
			if(timer2 >= 1f){
				MoveRight = MoveRight * -1f;
				timer2 = 0f;
			}

	
			//MoveUp = MoveUp * -1f;
			Robotl.GetComponent<Rigidbody>().velocity = new Vector3 (MoveRight, 0f, 0f);
			//Robotl.GetComponent<Rigidbody>().velocity = new Vector3 (0f, MoveUp, 0f);
			timer = 1.5f;

		}
	}

	void FixedUpdate () {
		timer -= .02f;
		timer2 += .02f;

	
}
}