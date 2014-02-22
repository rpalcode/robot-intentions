using UnityEngine;
using System.Collections;

public class SceneChanger : MonoBehaviour {

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp("1"))
        {
            Application.LoadLevel(0);
        }
        if (Input.GetKeyUp("2"))
        {
            Application.LoadLevel(1);
        }
        if (Input.GetKeyUp("3"))
        {
            Application.LoadLevel(2);
        }
	}
}
