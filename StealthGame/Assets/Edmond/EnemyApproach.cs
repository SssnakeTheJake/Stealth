using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyApproach : MonoBehaviour {

	public GameObject gui;
	GameObject gooey;
	public KeyCode destroyer;
	bool kill;

	void Update () {
		if (Input.GetKeyDown (destroyer) && kill ) {
			Destroy (gooey.gameObject);
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter () {
		gooey = (GameObject) Instantiate (gui, new Vector3 (0f, 0f, 0f), Quaternion.identity);
		kill = true;

	}

	void OnTriggerExit () {
		Destroy (gooey.gameObject);
	}

}