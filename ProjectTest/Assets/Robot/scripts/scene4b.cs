using UnityEngine;
using System.Collections;

public class scene4b : MonoBehaviour {
    public GameObject straight;
    public GameObject left;
    public GameObject right;
    public GameObject robot;
	public Camera camera01;

	public GameObject one;
	public GameObject two;
	public GameObject three;
	public GameObject four;

	void StartSide()
	{
		straight.SetActive(false);
		left.SetActive(false);
		right.SetActive(false);

		one.SetActive(false);
		two.SetActive(false);
		three.SetActive(false);
		four.SetActive(false);
	}

    private void option1()
    {

		if (Input.GetKeyDown("p"))
		{
			Time.timeScale =0;
			camera01.enabled = false;
		}
		if (Input.GetKeyDown("o"))
		{
			camera01.enabled = true;
			
			Time.timeScale =1;
		}

		StartSide();
		Debug.Log(Time.timeSinceLevelLoad);

		if (Time.timeSinceLevelLoad > 0 && Time.timeSinceLevelLoad < 3)
		{
			one.SetActive(true);
			two.SetActive(false);
			three.SetActive(false);
			four.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 3 && Time.timeSinceLevelLoad < 4)
		{
			one.SetActive(false);
			two.SetActive(true);
			three.SetActive(false);
			four.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 4 && Time.timeSinceLevelLoad < 13)
		{
			one.SetActive(false);
			two.SetActive(true);
			three.SetActive(false);
			four.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 13 && Time.timeSinceLevelLoad < 14)
		{
			one.SetActive(false);
			two.SetActive(false);
			three.SetActive(true);
			four.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 14 && Time.timeSinceLevelLoad < 15)
		{
			one.SetActive(false);
			two.SetActive(false);
			three.SetActive(true);
			four.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 15 && Time.timeSinceLevelLoad < 17)
		{
			one.SetActive(false);
			two.SetActive(false);
			three.SetActive(false);
			four.SetActive(true);
		}
		if (Time.timeSinceLevelLoad > 17 && Time.timeSinceLevelLoad < 18)
		{			
			one.SetActive(false);
			two.SetActive(false);
			three.SetActive(false);
			four.SetActive(true);
		}

		transform.Translate(0, -5 * Time.deltaTime, 0);
		/*
		if (Time.timeSinceLevelLoad > 2 && Time.timeSinceLevelLoad < 4) {  }
		if (Time.timeSinceLevelLoad > 4 && Time.timeSinceLevelLoad > 8) {  }
		if (Time.timeSinceLevelLoad > 11 && Time.timeSinceLevelLoad < 14) {  }
		if (Time.timeSinceLevelLoad > 13 && Time.timeSinceLevelLoad < 17) {  }
*/
		if (Time.timeSinceLevelLoad > 3 && Time.timeSinceLevelLoad < 4)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
        }

		if (Time.timeSinceLevelLoad > 13 && Time.timeSinceLevelLoad < 14)
        {
            transform.Rotate(0, 0, 45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
		if (Time.timeSinceLevelLoad > 15 && Time.timeSinceLevelLoad < 17)
        {
            transform.Rotate(0, 0, 45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }

		if (Time.timeSinceLevelLoad >= 18.5)
        {
            Application.LoadLevel(2);
        }        
    }


	// Use this for initialization

	void Start () {
        //counter = 0;
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("8"))
		{
			Application.LoadLevel(4);
		}
		if (Input.GetKeyDown("9"))
		{
			Application.LoadLevel(5);
		}
		if (Input.GetKeyDown("0"))
		{
			Application.LoadLevel(6);
		}
        option1();
	}
}
