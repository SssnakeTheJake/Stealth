using UnityEngine;
using System.Collections;

public class NightVision : MonoBehaviour {
	bool isNightVision = false;
	public KeyCode TurnNightVisionOn;
	float timer = 0f;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

		if (Input.GetKey (TurnNightVisionOn) && timer <= 0) {
			if(isNightVision == true){
							
			}

		}
	}
	void FixedUpdate(){

	}
}
