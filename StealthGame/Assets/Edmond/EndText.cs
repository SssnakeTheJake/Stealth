using UnityEngine;
using System.Collections;
using UnityEngine.UI;
public class EndText : MonoBehaviour {
	public Button SpaceToStart;
	// Use this for initialization
	void Start () {
		SpaceToStart = SpaceToStart.GetComponent<Button>();
	}
	
	public void Pressed () {
		SpaceToStart.enabled = false;
	}
	public void NotPressed(){
		SpaceToStart.enabled = true;
	}
 
}
