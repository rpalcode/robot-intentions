using UnityEngine;
using System.Collections;

public class optionalpaths : MonoBehaviour {

    void OnGUI()
    {
       GUI.Box(new Rect(250, 900, 200, 270), "Please pick a path.\n4.Top(Red)\n5.Mid(Green)\n6.Bottom(Blue)");
	   GUI.Box(new Rect(850, 900, 200, 270), "Please pick a path.\n4.Top(Red)\n5.Mid(Green)\n6.Bottom(Blue)");

	}

	void Start () {
        
	}

	// Update is called once per frame
	void Update () {
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
