using UnityEngine;
using System.IO;
using System.Collections;

public class Front : MonoBehaviour {
	public Camera camera01;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
		Time.timeScale=1;
		Debug.Log (Time.timeSinceLevelLoad);
        transform.Translate(0, -5*Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0, 0, -90*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, 90*Time.deltaTime);
        }


	}
}
