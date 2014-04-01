using UnityEngine;
using System.Collections;

public class Front : MonoBehaviour {
	public Camera camera01;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
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

		if (Input.GetKeyDown("p"))
		{
			Time.timeScale =0;
			camera01.enabled = false;
		}
		if (Input.GetKeyDown("o"))
		{
			camera01.enabled = true;

			Time.timeScale =1;
		}

	}
}
