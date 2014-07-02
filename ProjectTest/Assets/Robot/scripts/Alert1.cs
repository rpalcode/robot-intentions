using UnityEngine;
using System.Collections;

public class Alert1 : MonoBehaviour {
	public GameObject head;
	public GameObject jaw;
	public GameObject spine;
	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
		if(Time.timeSinceLevelLoad > 15 && Time.timeSinceLevelLoad < 15.3)
		{
			spine.transform.Rotate(0,-1,0);
		}
		if(Time.timeSinceLevelLoad > 15.3 && Time.timeSinceLevelLoad < 15.6)
		{
			head.transform.Rotate(0,-1,0);
		}
		if(Time.timeSinceLevelLoad > 16 && Time.timeSinceLevelLoad < 16.1)
		{
			jaw.transform.Rotate(5,0,0);
		}
	}
}
