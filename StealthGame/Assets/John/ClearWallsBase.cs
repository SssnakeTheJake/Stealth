using UnityEngine;
using System.Collections;

public class ClearWallsBase : MonoBehaviour {

	public KeyCode flipLens;
	bool LensFlip = false;
	float timer = 1f;
	bool LensDown = false;
	Color red = Color.red;
	Color white = Color.white;
	public Light lt;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if (LensDown) {
			lt.color = red;
		} else {
			lt.color = white;
		}

		if (Input.GetKey (flipLens) && LensFlip) {
			GameObject wall = GameObject.Find("Plane_003");
			Renderer waller = wall.GetComponent<Renderer>();
			waller.enabled = LensDown;

			GameObject wall1 = GameObject.Find("Plane_004");
			Renderer waller1 = wall1.GetComponent<Renderer>();
			waller1.enabled = LensDown;

			GameObject wall2 = GameObject.Find("Plane_005");
			Renderer waller2 = wall2.GetComponent<Renderer>();
			waller2.enabled = LensDown;

			GameObject wall3 = GameObject.Find("Plane_006");
			Renderer waller3 = wall3.GetComponent<Renderer>();
			waller3.enabled = LensDown;

			GameObject wall4 = GameObject.Find("Plane_009");
			Renderer waller4 = wall4.GetComponent<Renderer>();
			waller4.enabled = LensDown;

			GameObject wall5 = GameObject.Find("Plane_010");
			Renderer waller5 = wall5.GetComponent<Renderer>();
			waller5.enabled = LensDown;

			GameObject wall6 = GameObject.Find("Plane_011");
			Renderer waller6 = wall6.GetComponent<Renderer>();
			waller6.enabled = LensDown;

			GameObject wall7 = GameObject.Find("Plane_015");
			Renderer waller7 = wall7.GetComponent<Renderer>();
			waller7.enabled = LensDown;

			GameObject wall8 = GameObject.Find("Plane_016");
			Renderer waller8 = wall8.GetComponent<Renderer>();
			waller8.enabled = LensDown;

			GameObject wall9 = GameObject.Find("Plane_017");
			Renderer waller9 = wall9.GetComponent<Renderer>();
			waller9.enabled = LensDown;

			LensDown = !LensDown;
			LensFlip = false;
		}

	}

	void FixedUpdate() {
		timer -= .02f;
		if (timer <= 0f) {
				LensFlip = true;
				timer = 1f;
		}
	}
}
