using UnityEngine;
using System.Collections;

public class scene5b : MonoBehaviour {
    public GameObject straight;
    public GameObject left;
    public GameObject right;
    public GameObject robot;
	public Camera camera01;

	public GameObject one;
	public GameObject two;
	public GameObject three;

	void StartSide()
	{
		straight.SetActive(false);
		left.SetActive(false);
		right.SetActive(false);

		one.SetActive(false);
		two.SetActive(false);
		three.SetActive(false);
	}


    private void run()
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

        transform.Translate(0, -5 * Time.deltaTime, 0);

		if (Time.timeSinceLevelLoad > 0 && Time.timeSinceLevelLoad < 2)
		{
			one.SetActive(true);
			two.SetActive(false);
			three.SetActive(false);
		}

		if (Time.timeSinceLevelLoad > 2 && Time.timeSinceLevelLoad < 3)
		{
			one.SetActive(true);
			two.SetActive(false);
			three.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 3 && Time.timeSinceLevelLoad < 5)
		{
			one.SetActive(true);
			two.SetActive(false);
			three.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 5 && Time.timeSinceLevelLoad < 9)
		{
			one.SetActive(false);
			two.SetActive(true);
			three.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 9 && Time.timeSinceLevelLoad < 11)
		{
			one.SetActive(false);
			two.SetActive(true);
			three.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 11 && Time.timeSinceLevelLoad < 14)
		{
			one.SetActive(false);
			two.SetActive(false);
			three.SetActive(true);
		}
		
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
		if (Time.timeSinceLevelLoad > 11 && Time.timeSinceLevelLoad < 14)
		{
			transform.Rotate(0, 0, 45 * Time.deltaTime);
			transform.Translate(0, -5 * Time.deltaTime, 0);
		}
		if (Time.timeSinceLevelLoad>=16)
		{
			Application.LoadLevel(2);
		}
		
	}
	// Use this for initialization
	
	void Start () {
        
	}

	// Update is called once per frame
	void Update () {
		if (Input.GetKeyDown("8"))
		{
			Application.LoadLevel(7);
		}
		if (Input.GetKeyDown("9"))
		{
			Application.LoadLevel(8);
		}
		if (Input.GetKeyDown("0"))
		{
			Application.LoadLevel(9);
		}
        run();
	}
}
