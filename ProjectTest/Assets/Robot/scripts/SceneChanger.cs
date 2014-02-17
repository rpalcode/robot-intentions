using UnityEngine;
using System.Collections;

public class SceneChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp("q"))
        {
            Application.LoadLevel(0);
        }
        if (Input.GetKeyUp("w"))
        {
            Application.LoadLevel(1);
        }
        if (Input.GetKeyUp("e"))
        {
            Application.LoadLevel(2);
        }
	}
}
