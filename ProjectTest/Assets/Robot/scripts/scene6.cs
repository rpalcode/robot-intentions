using UnityEngine;
using System.Collections;

public class scene6 : MonoBehaviour {
    public GameObject straight;
    public GameObject left;
    public GameObject right;
    public GameObject robot;

    void leftArrow()
    {
        straight.SetActive(false);
        left.SetActive(true);
        right.SetActive(false);
    }

    void upArrow()
    {
        straight.SetActive(true);
        left.SetActive(false);
        right.SetActive(false);
    }

    void rightArrow()
    {
        straight.SetActive(false);
        left.SetActive(false);
        right.SetActive(true);
    }


    private void option3()
    {
		Debug.Log (Time.timeSinceLevelLoad);

		upArrow();
        transform.Translate(0, -5 * Time.deltaTime, 0);

		if (Time.timeSinceLevelLoad > 2 && Time.timeSinceLevelLoad < 4) { rightArrow(); }
		if (Time.timeSinceLevelLoad > 6 && Time.timeSinceLevelLoad < 7.6) { leftArrow(); }
		if (Time.timeSinceLevelLoad > 8.4 && Time.timeSinceLevelLoad < 9) { leftArrow(); }
		if (Time.timeSinceLevelLoad > 14.5 && Time.timeSinceLevelLoad < 16.5) { leftArrow(); }

		
		if (Time.timeSinceLevelLoad > 3 && Time.timeSinceLevelLoad < 3.6)
        {
            transform.Rotate(0, 0, 90 * Time.deltaTime);
        }
		if (Time.timeSinceLevelLoad > 7 && Time.timeSinceLevelLoad < 7.6)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
		if (Time.timeSinceLevelLoad > 8.4 && Time.timeSinceLevelLoad < 9)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }

		if (Time.timeSinceLevelLoad > 15.5 && Time.timeSinceLevelLoad < 16.5)
		{
			transform.Rotate(0, 0, -45 * Time.deltaTime);
			transform.Translate(0, -5 * Time.deltaTime, 0);
		}
		
		if (Time.timeSinceLevelLoad >= 17.5)
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
