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
		if (Input.GetKeyUp("1"))
		{
			Application.LoadLevel(3);
		}
		if (Input.GetKeyUp("r"))
		{
			Application.LoadLevel(4);
		}
		if (Input.GetKeyUp("t"))
		{
			Application.LoadLevel(5);
		}
		if (Input.GetKeyUp("y"))
		{
			Application.LoadLevel(6);
		}
		if (Input.GetKeyUp("u"))
		{
			Application.LoadLevel(7);
		}
		if (Input.GetKeyUp("f"))
		{
			Application.LoadLevel(8);
		}
		if (Input.GetKeyUp("g"))
		{
			Application.LoadLevel(9);
		}
		if (Input.GetKeyUp("h"))
		{
			Application.LoadLevel(10);
		}
		if (Input.GetKeyUp("j"))
		{
			Application.LoadLevel(11);
		}
		if (Input.GetKeyUp("v"))
		{
			Application.LoadLevel(12);
		}
		if (Input.GetKeyUp("b"))
		{
			Application.LoadLevel(13);
		}
		if (Input.GetKeyUp("n"))
		{
			Application.LoadLevel(14);
		}
		if (Input.GetKeyUp("m"))
		{
			Application.LoadLevel(15);
		}
		if (Input.GetKeyUp("z"))
		{
			Application.LoadLevel(19);
		}
	}
}
