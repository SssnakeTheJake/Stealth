using UnityEngine;
using System.Collections;

public class RetryButton : MonoBehaviour {
	
	public void OnClick () {
		Application.LoadLevel ("JacobScene");
	}
}
