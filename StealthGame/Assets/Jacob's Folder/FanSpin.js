#pragma strict
var _rotationSpeed = 90;

function Update()

{

    transform.Rotate(0, 0, _rotationSpeed * Time.deltaTime, Space.World);
}