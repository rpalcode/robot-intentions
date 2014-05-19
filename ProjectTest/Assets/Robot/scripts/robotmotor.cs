using UnityEngine;
using System.Collections;

public class robotmotor : MonoBehaviour {


	// Use this for initialization
	void Start () {
	
	}

	void scene4motor()
	{
		transform.Translate(0, -5 * Time.deltaTime, 0);
		
		if (Time.timeSinceLevelLoad > 3 && Time.timeSinceLevelLoad < 4)
		{
			transform.Rotate(0, 0, -45 * Time.deltaTime);
		}
		
		if (Time.timeSinceLevelLoad > 13 && Time.timeSinceLevelLoad < 14)
		{
			transform.Rotate(0, 0, 45 * Time.deltaTime);
			transform.Translate(0, -5 * Time.deltaTime, 0);
		}
		if (Time.timeSinceLevelLoad > 15 && Time.timeSinceLevelLoad < 16.25)
		{
			transform.Rotate(0, 0, -45 * Time.deltaTime);
			transform.Translate(0, -5 * Time.deltaTime, 0);
		}
	}

	void scene5motor()
	{
		if (Time.timeSinceLevelLoad > 2 && Time.timeSinceLevelLoad < 3)
		{
			transform.Rotate(0, 0, 90 * Time.deltaTime);
		}
		if (Time.timeSinceLevelLoad > 3 && Time.timeSinceLevelLoad < 5)
		{
			transform.Rotate(0, 0, -45 * Time.deltaTime);
			transform.Translate(0, -5 * Time.deltaTime, 0);
		}
		if (Time.timeSinceLevelLoad > 9 && Time.timeSinceLevelLoad < 11)
		{
			transform.Rotate(0, 0, -45 * Time.deltaTime);
			transform.Translate(0, -5 * Time.deltaTime, 0);
		}
		if (Time.timeSinceLevelLoad > 11 && Time.timeSinceLevelLoad < 18)
		{
			transform.Rotate(0, 0, 45 * Time.deltaTime);
			transform.Translate(0, -5 * Time.deltaTime, 0);
		}
	}

	void scene6motor()
	{
		if (Time.timeSinceLevelLoad > 3 && Time.timeSinceLevelLoad < 3.6)
		{
			transform.Rotate(0, 0, 90 * Time.deltaTime);
		}
		if (Time.timeSinceLevelLoad > 10 && Time.timeSinceLevelLoad < 10.25)
		{
			transform.Rotate(0, 0, 45 * Time.deltaTime);
			transform.Translate(0, -5 * Time.deltaTime, 0);
		}
	}


	// Update is called once per frame
	void Update () {


	}
}
