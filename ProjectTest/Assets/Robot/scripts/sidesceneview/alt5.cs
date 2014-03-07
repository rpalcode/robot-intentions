using UnityEngine;
using System.Collections;

public class alt5 : MonoBehaviour {
  
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
       // int camSwitch = 0;

        if (Input.GetKeyDown("0"))
        {
            Application.LoadLevel(6);
        }
       
	}
}
