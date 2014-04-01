using UnityEngine;
using System.Collections;

public class scene5 : MonoBehaviour {
    public GameObject straight;
    public GameObject left;
    public GameObject right;
    public GameObject robot;
	public Camera camera01;

    public int choice;


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

		Debug.Log(Time.timeSinceLevelLoad);

        upArrow();
        transform.Translate(0, -5 * Time.deltaTime, 0);

		if (Time.timeSinceLevelLoad > .7 && Time.timeSinceLevelLoad < 2) { rightArrow(); }
		if (Time.timeSinceLevelLoad>2 && Time.timeSinceLevelLoad<5) { leftArrow(); }
		if (Time.timeSinceLevelLoad > 5 && Time.timeSinceLevelLoad > 7) { upArrow(); }
		if (Time.timeSinceLevelLoad > 8 && Time.timeSinceLevelLoad < 11) { leftArrow(); }
		if (Time.timeSinceLevelLoad > 10 && Time.timeSinceLevelLoad < 12) { rightArrow(); } 
		
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
