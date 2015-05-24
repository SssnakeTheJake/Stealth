using UnityEngine;
using System.Collections;

public class PressSpace : MonoBehaviour {

	void Update () {
		if (Input.GetKeyDown ("space")) {
			Application.Quit();
		}
	}
 
}
