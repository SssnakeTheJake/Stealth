using UnityEngine;
using System.Collections;

public class AILiniearMovement : MonoBehaviour {


	public float timer = 1.5f;
	public float timer2 = 1.5f;
	public float MoveX;
	public GameObject Robot;

	// Use this for initialization
	void Start () {

	}
	// Update is called once per frame
	void Update () {
		float turnAround = 0f;
		if (timer <= 0) {
			if (timer2 <= 1f) {
				MoveX = MoveX * -1f;
				timer2 = 1.5f;
				turnAround = 180f;

			}
			//MoveUp = MoveUp * -1f;

			Robot.GetComponent<Rigidbody> ().velocity = new Vector3 (0f, 0f, MoveX);
			Robot.transform.eulerAngles = new Vector3 (Robot.transform.eulerAngles.x,Robot.transform.eulerAngles.y,turnAround);
			//Robotl.GetComponent<Rigidbody>().velocity = new Vector3 (0f, MoveUp, 0f);
			timer = 1.5f;
		}
	}
	void FixedUpdate(){
		timer -= .02f;
		timer2 -= .02f;
	}
}
