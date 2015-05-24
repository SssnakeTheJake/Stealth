using UnityEngine;
using System.Collections;

public class AIShootScript : MonoBehaviour {

	public GameObject Bullet;
	
	
	//public KeyCode shoot;
	
	public float Timer;
	float TimeSet = .6f;
	
	void Start () {
		
	}
	
	void Update () {
		//GameObject player = GameObject.Find ("FirstPersonCharacter");
		//float playerX = player.transform.position.x;
		float disX = transform.position.x;
		float DegValX = ((transform.eulerAngles.y * Mathf.PI) / 180);
		float factorX = Mathf.Sin (DegValX);
		float factorZ = Mathf.Cos (DegValX);
		
		//GameObject cameraPivot = GameObject.Find ("GrundHolder1");
		//float rotUp = cameraPivot.transform.rotation.eulerAngles.x;
		
		//float rotUpRad = ((rotUp * Mathf.PI) / 180);
		//float factorYUp = Mathf.Sin (rotUpRad);
		//float factorYOut = Mathf.Cos (rotUpRad);
		Vector3 fwd = transform.TransformDirection(Vector3.forward);
		if (Physics.Raycast(transform.position, fwd, 1000) && Timer <= 0 /*&& (playerX == disX || playerX == disX-5f || playerX == disX - 5f)*/) {
			
			Timer = TimeSet;
			GameObject bullet = (GameObject)Instantiate (Bullet, transform.position, /*Quaternion.Euler(Vector3(0, 0, 90))*/ transform.rotation);
			
			bullet.GetComponent<Rigidbody>().velocity = new Vector3(20f * factorX /** factorYOut*/, /*-45f * factorYUp*/-1f , 20f * factorZ /** factorYOut*/);
			Application.LoadLevel ("Game Over");
			
		}
	}
	
	void FixedUpdate(){
		Timer -= .02f;
	}
}
