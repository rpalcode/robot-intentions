using UnityEngine;
using System.Collections;

public class backto4front : MonoBehaviour {
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
    if(Input.GetKeyDown("0"))
    {
        Application.LoadLevel(4);
    }
    if (Input.GetKeyDown("9"))
    {
        Application.LoadLevel(5);
    }
	}
}
