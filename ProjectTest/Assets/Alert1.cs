using UnityEngine;
using System.Collections;

public class Alert1 : MonoBehaviour {
	public GameObject head;
	public GameObject jaw;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeSinceLevelLoad > 16 && Time.timeSinceLevelLoad < 16.03)
		{
			head.transform.Rotate(0,-22,0);
			jaw.transform.Rotate(22,0,0);
		}
	}
}
