using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class EnemyApproach : MonoBehaviour {

	public GameObject gui;
	GameObject gooey;

	// Use this for initialization
	void OnTriggerEnter () {
		gooey = (GameObject) Instantiate (gui, new Vector3 (0f, 0f, 0f), Quaternion.identity);

	}

	void OnTriggerExit () {
		Destroy (gooey.gameObject);
	}

}
