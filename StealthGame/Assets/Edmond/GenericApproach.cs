using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class GenericApproach : MonoBehaviour {

	public KeyCode destroyer;
	bool kill;

	void Update () {
		if (Input.GetKeyDown (destroyer) && kill ) {
			Destroy (gameObject);
		}
	}

	void OnTriggerEnter () {
		kill = true;

	}

}