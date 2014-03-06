using UnityEngine;
using System.Collections;

public class optionalpaths : MonoBehaviour {

    void OnGUI()
    {
       GUI.Box(new Rect(200, 100, 200, 270), "Please pick a path.\n4.Top(Red)\n5.Mid(Green)\n6.Bottom(Blue)");
    }

	void Start () {
        
	}

	// Update is called once per frame
	void Update () {

        if (Input.GetKeyUp("4"))
        {
            Application.LoadLevel(3);
        }
        if (Input.GetKeyUp("5"))
        {
            Application.LoadLevel(4);
        }
        if (Input.GetKeyUp("6"))
        {
            Application.LoadLevel(5);
        }
	}
}
