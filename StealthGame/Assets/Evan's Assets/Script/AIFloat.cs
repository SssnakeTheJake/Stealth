using UnityEngine;
using System.Collections;

public class AIFloat : MonoBehaviour {

	public float timer = 1.5f;
	//public float timer2 = 1.5f;
	public float MoveY;
	public GameObject Robot;
	
	// Use this for initialization
	void Start () {
		Robot = Robot.GetComponent<GameObject> ();
	}
	// Update is called once per frame
	void Update () {
		if (timer <= 0) {
			//if (timer2 <= 1f) {
				//MoveX = MoveX * -1f;
				//timer2 = 0f;
			//}
			MoveY = MoveY * -1f;
			//Robot.GetComponent<Rigidbody> ().velocity = new Vector3 (MoveRight, 0f, 0f);
			Robot.GetComponent<Rigidbody>().velocity = new Vector3 (0f, MoveY, 0f);
			//timer = 1.5f;
		}
	}
	void FixedUpdate(){
		timer -= .02f;
		//timer2 -= .02f;
	}
}
