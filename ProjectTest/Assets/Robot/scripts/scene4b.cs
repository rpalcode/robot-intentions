using UnityEngine;
using System.Collections;
using System.Diagnostics;
using System.Threading;


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

	public System.DateTime date1 = new System.DateTime(1996, 6, 3, 22, 15, 0);
	public System.DateTime date2 = new System.DateTime(1996, 12, 6, 13, 2, 0);

	static int pause=0;


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
		StartSide ();

		if (Input.GetKeyDown("p"))
		{
			date1 = System.DateTime.Now;
			pause=1;
			Time.timeScale =0;
			camera01.enabled = false;
		}


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

		if (Time.timeSinceLevelLoad >= 18)
        {
            Application.LoadLevel(2);
        }        
    }


	// Use this for initialization

	void Start () {
	}

	void OnGUI()
	{
		if(pause==1)
		{
			int choice=0;

			GUI.Box(new Rect(200,350,300,100), "Which way is the robot going to go?");

			if(GUI.Button(new Rect(200,400,100,50), "left")) 
			{
				choice=1;
			}
			if(GUI.Button(new Rect(300,400,100,50), "forward")) 
			{
				choice=1;
			}
	
			if(GUI.Button(new Rect(400,400,100,50), "right")) 
			{
				choice=1;
			}

			if(choice==1)
			{
				date2 = System.DateTime.Now;
				UnityEngine.Debug.Log ("ELAPSED = " + (date2-date1));

				//UnityEngine.Debug.Log ("TIME = " + timee);

				camera01.enabled = true;
				Time.timeScale =1;
				pause=0;
				option1 ();

			}

		}
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
