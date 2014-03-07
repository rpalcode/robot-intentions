using UnityEngine;
using System.Collections;

public class alt5 : MonoBehaviour {
    private GameObject c1;
    private GameObject c2;
    public int camSwitch;
	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
       // int camSwitch = 0;
        if (camSwitch == 0)
        {
            c1.SetActive(true);
            c2.SetActive(false);
        }
        if (Input.GetKeyDown("0"))
        {
            Application.LoadLevel(6);
        }
        if (Input.GetKey("9"))
        {
            camSwitch=1;
        }

        if(camSwitch==1)
        {
            c1.SetActive(false);
            c2.SetActive(true);
        }
	}
}
