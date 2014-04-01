using UnityEngine;
using System.Collections;

public class optionalpaths : MonoBehaviour {
	public GameObject red;
	public GameObject blue;
	public GameObject green;
	public GameObject map;
   /* void OnGUI()
    {
       GUI.Box(new Rect(250, 900, 200, 270), "Please pick a path.\n4.Top(Red)\n5.Mid(Green)\n6.Bottom(Blue)");
	   GUI.Box(new Rect(850, 900, 200, 270), "Please pick a path.\n4.Top(Red)\n5.Mid(Green)\n6.Bottom(Blue)");

	}
*/
	void Start () {
		red.SetActive(false);
		blue.SetActive(false);
		green.SetActive(false);
		map.SetActive(true);
	}

	// Update is called once per frame
	void Update () {

		//change paths

		if (Input.GetKeyDown("q"))
		{
			red.SetActive(true);
			blue.SetActive(false);
			green.SetActive(false);
			map.SetActive(false);
		}
		if (Input.GetKeyDown("w"))
		{
			red.SetActive(false);
			blue.SetActive(false);
			green.SetActive(true);
			map.SetActive(false);
		}
		if (Input.GetKeyUp("e"))
		{
			red.SetActive(false);
			green.SetActive(false);
			blue.SetActive(true);
			map.SetActive(false);
		}
		if (Input.GetKeyUp("r"))
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
        if (Input.GetKeyUp("4"))
        {
            Application.LoadLevel(4);
        }
        if (Input.GetKeyUp("5"))
        {
            Application.LoadLevel(7);
        }
        if (Input.GetKeyUp("6"))
        {
            Application.LoadLevel(10);
        }
	}
}
