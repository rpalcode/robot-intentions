using UnityEngine;
using System.Collections;

public class rotateCam : MonoBehaviour 
{
	OVRCameraController camera;
	public Camera cam1;
	public Camera cam2;
	public GameObject rotater;
	// Use this for initialization
	void Start () 
	{

	}

	// Update is called once per frame
	void Update () 
	{
		if(Input.GetKeyUp("l"))
		{
			Debug.Log("rotating! :D");
			transform.Rotate(0,45,0);
		}
	}
}
