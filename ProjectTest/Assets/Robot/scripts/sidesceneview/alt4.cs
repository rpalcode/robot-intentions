using UnityEngine;
using System.Collections;

public class alt4 : MonoBehaviour {
    public GameObject c1;
    public GameObject c2;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        c1.SetActive(true);
        c2.SetActive(false);
    if(Input.GetKeyDown("0"))
        {
            Application.LoadLevel(4);
        }
    if (Input.GetKeyDown("9"))
    {
        c1.SetActive(false);
        c2.SetActive(true);
    }

	}
}
