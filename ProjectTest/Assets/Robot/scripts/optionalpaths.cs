using UnityEngine;
using System.Collections;

public class optionalpaths : MonoBehaviour {
	public GameObject red;
	public GameObject blue;
	public GameObject green;
	public GameObject map;
	public int path=0;
	public Camera camera01;
   
	void Start () {
		red.SetActive(false);
		blue.SetActive(false);
		green.SetActive(false);
		map.SetActive(false);
		Time.timeScale=0;
	}

	// Update is called once per frame
	void Update () {
		//change paths


		if (Input.GetKeyDown("e") || Input.GetKeyDown("d") || Input.GetKeyDown("c"))
		{
			path=1;
		}
		if(path==1)
		{
			red.SetActive(true);
			blue.SetActive(false);
			green.SetActive(false);
			map.SetActive(false);
			Time.timeScale=1;
			if(Time.timeSinceLevelLoad>5)
			{
				camera01.enabled = false;
			}

		}
		if (path==1)
		{
			red.SetActive(false);
			blue.SetActive(false);
			green.SetActive(true);
			map.SetActive(false);
			Time.timeScale=1;
			if(Time.timeSinceLevelLoad>5)
			{
				camera01.enabled = false;
			}
		}
		if (path==1)
		{
			red.SetActive(false);
			green.SetActive(false);
			blue.SetActive(true);
			map.SetActive(false);
			Time.timeScale=1;
			if(Time.timeSinceLevelLoad>5)
			{
				camera01.enabled = false;
			}
		}
		/* if (Input.GetKeyUp("w"))
		{
			red.SetActive(false);
			green.SetActive(false);
			blue.SetActive(false);
			map.SetActive(true);
			Time.timeScale=1;
			if(Time.timeSinceLevelLoad>5)
			{
				camera01.enabled = false;
			}
		}
*/ 
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
