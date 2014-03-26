#pragma strict

function test()
{
 transform.Translate(Vector3.forward * Time.deltaTime);
 Debug.Log(Time.deltaTime);
// if(Time.time>=5 && Time.time<=6) { Debug.Log("ITS BEEN 5 SECONDS!"); }
  transform.Translate(-Vector3.forward * Time.deltaTime);
}


function Start () {

}

function Update () {
	test();
}