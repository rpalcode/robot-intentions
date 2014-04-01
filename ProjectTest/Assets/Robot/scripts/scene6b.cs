using UnityEngine;
using System.Collections;

public class scene6b : MonoBehaviour {
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

    private void option3()
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
		Debug.Log (Time.timeSinceLevelLoad);

        transform.Translate(0, -5 * Time.deltaTime, 0);



		if (Time.timeSinceLevelLoad > 0 && Time.timeSinceLevelLoad < 3)
		{
			one.SetActive(true);
			two.SetActive(false);
			three.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 3 && Time.timeSinceLevelLoad < 3.6)
		{
			one.SetActive(true);
			two.SetActive(false);
			three.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 3.6 && Time.timeSinceLevelLoad < 10)
		{
			one.SetActive(false);
			two.SetActive(true);
			three.SetActive(false);
		}
		if (Time.timeSinceLevelLoad > 10 && Time.timeSinceLevelLoad < 11)
		{
			one.SetActive(false);
			two.SetActive(false);
			three.SetActive(true);
		}
		if (Time.timeSinceLevelLoad > 11 && Time.timeSinceLevelLoad < 16)
		{
			one.SetActive(false);
			two.SetActive(false);
			three.SetActive(true);
		}
		if (Time.timeSinceLevelLoad > 16 && Time.timeSinceLevelLoad < 17)
		{
			one.SetActive(false);
			two.SetActive(false);
			three.SetActive(true);
		}
		if (Time.timeSinceLevelLoad > 17 && Time.timeSinceLevelLoad < 20)
		{
			one.SetActive(false);
			two.SetActive(false);
			three.SetActive(true);
		}		
		if (Time.timeSinceLevelLoad > 20 && Time.timeSinceLevelLoad < 21)
		{
			one.SetActive(false);
			two.SetActive(false);
			three.SetActive(true);
		}


		
		if (Time.timeSinceLevelLoad > 3 && Time.timeSinceLevelLoad < 3.6)
        {
            transform.Rotate(0, 0, 90 * Time.deltaTime);
        }
		if (Time.timeSinceLevelLoad > 10 && Time.timeSinceLevelLoad < 11)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
		if (Time.timeSinceLevelLoad > 16 && Time.timeSinceLevelLoad < 17)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }

		if (Time.timeSinceLevelLoad > 20 && Time.timeSinceLevelLoad < 21)
		{
			transform.Rotate(0, 0, -45 * Time.deltaTime);
			transform.Translate(0, -5 * Time.deltaTime, 0);
		}
		
		if (Time.timeSinceLevelLoad >= 23)
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
			Application.LoadLevel(10);
		}
		if (Input.GetKeyDown("9"))
		{
			Application.LoadLevel(11);
		}
		if (Input.GetKeyDown("0"))
		{
			Application.LoadLevel(12);
		}
		option3();
	}
}
