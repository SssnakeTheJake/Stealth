using UnityEngine;
using System.Collections;

public class AIRectangularMovement : MonoBehaviour {


	public float timer = 1.5f;
	public float timer2 = 1.5f;
	public float MoveX;
	public GameObject Robot;
	int i;
	bool isSquareComplete;
	
	// Use this for initialization
	void Start () {

		i = 0;
	}
	// Update is called once per frame
	void Update () {
		float turnAround = 0f;

		if (timer <= 0) {
			if (timer2 <= 1f) {
				turnAround = 90f;
				timer2 = 1.5f;
				if(!isSquareComplete){
					if(i == 2){
						MoveX = MoveX *-1;

					}
				}

				if(i>=4){
					isSquareComplete = true;
					MoveX = MoveX *-1;
					i =0;
				}
				i++;

			}
			//MoveUp = MoveUp * -1f;
			Robot.transform.eulerAngles = new Vector3(Robot.transform.eulerAngles.x,Robot.transform.eulerAngles.y,turnAround);
			//Robot.GetComponent<Rigidbody> ().velocity = new Vector3 (0f, 0f, MoveX);
			if(i==0)
				Robot.GetComponent<Rigidbody> ().velocity = new Vector3 (0f, 0f, MoveX);
			if(i==1)
				Robot.GetComponent<Rigidbody> ().velocity = new Vector3 (MoveX, 0f,0f );
			if(i==2)
				Robot.GetComponent<Rigidbody> ().velocity = new Vector3 (0f, 0f,MoveX );
			if(i==3)
				Robot.GetComponent<Rigidbody> ().velocity = new Vector3 (MoveX, 0f,0f );
			//Robotl.GetComponent<Rigidbody>().velocity = new Vector3 (0f, MoveUp, 0f);
		
			timer = 1.5f;
		}
	}
	void FixedUpdate(){
		timer -= .02f;
		timer2 -= .02f;
		if(!isSquareComplete){
			if(i == 2){
				MoveX = MoveX *-1;
				
			}
		}
		
		if(i>=4){
			isSquareComplete = true;
			MoveX = MoveX *-1;
			i =0;
		}
		i++;
	}
}
