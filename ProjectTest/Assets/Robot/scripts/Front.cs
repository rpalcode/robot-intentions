using UnityEngine;
using System.IO;
using System.Collections;

public class Front : MonoBehaviour {
	public Camera camera01;
	public GameObject arrow;
	public int force=1;
	// Use this for initialization
	void Start () {
		arrow.renderer.material.color = Color.yellow;
	}
	
	// Update is called once per frame
	void Update () 
    {
		Time.timeScale=1;
		//Debug.Log (Time.timeSinceLevelLoad);
        transform.Translate(0, -5*force*Time.deltaTime, 0);

        if (Input.GetKey(KeyCode.RightArrow))
        {
            transform.Rotate(0,0, 22*force*Time.deltaTime);
        }
        if (Input.GetKey(KeyCode.LeftArrow))
        {
            transform.Rotate(0, 0, -22*force*Time.deltaTime);
        }

		if(Input.GetKeyUp(KeyCode.UpArrow))
			//if(force < 10)
				force+=1;
		if(Input.GetKeyUp(KeyCode.DownArrow))
			force/=2;
	}
}
