#pragma strict

var blah : KeyCode;

function Update() {

if(Input.GetKeyDown(blah)) {

transform.localScale += new Vector3(-.5f, -.5f, -.5f);

}

if(Input.GetKeyUp(blah)) {

transform.localScale += new Vector3(.5f, .5f, .5f);

}
}