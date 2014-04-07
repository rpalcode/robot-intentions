using UnityEngine;
using System.Collections;

public class optionalpaths : MonoBehaviour {
	public GameObject red;
	public GameObject blue;
	public GameObject green;
	public GameObject map;
   
	void Start () {
		red.SetActive(false);
		blue.SetActive(false);
		green.SetActive(false);
		map.SetActive(false);
	}

	// Update is called once per frame
	void Update () {

		//change paths

		if (Input.GetKeyDown("e"))
		{
			red.SetActive(true);
			blue.SetActive(false);
			green.SetActive(false);
			map.SetActive(false);
		}
		if (Input.GetKeyDown("d"))
		{
			red.SetActive(false);
			blue.SetActive(false);
			green.SetActive(true);
			map.SetActive(false);
		}
		if (Input.GetKeyUp("c"))
		{
			red.SetActive(false);
			green.SetActive(false);
			blue.SetActive(true);
			map.SetActive(false);
		}
		if (Input.GetKeyUp("w"))
		{
			red.SetActive(false);
			green.SetActive(false);
			blue.SetActive(false);
			map.SetActive(true);
		}

		//load levels

        if (Input.GetKeyDown("9"))
        {
            Application.LoadLevel(2);
        }
		if (Input.GetKeyDown("0"))
		{
			Application.LoadLevel(3);
		}

	}
}
