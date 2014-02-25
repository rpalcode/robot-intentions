using UnityEngine;
using System.Collections;

public class Front : MonoBehaviour {
  
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () 
    {
        transform.Translate(0, -5*Time.deltaTime, 0);

        if (Input.GetKeyDown("right"))
        {
            transform.Rotate(0, 0, -90);
        }
        if (Input.GetKeyDown("left"))
        {
            transform.Rotate(0, 0, 90);
        }

	}
}
