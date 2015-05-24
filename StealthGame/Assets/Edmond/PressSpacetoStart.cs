using UnityEngine;
using System.Collections;

public class PressSpacetoStart : MonoBehaviour {
	public KeyCode space;
	void Update () {
		if (Input.GetKey (space)) {
			Application.LoadLevel("JacobScene");
		}
	}
 
}
