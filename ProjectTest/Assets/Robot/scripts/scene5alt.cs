using UnityEngine;
using System.Collections;

public class scene5alt : MonoBehaviour {
    private int counter = 0;
    public double timediff = 0.0;
    public GameObject straight;
    public GameObject left;
    public GameObject right;
    public GameObject robot;

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
        //print(counter);
        upArrow();
        transform.Translate(0, -5 * Time.deltaTime, 0);

        timediff = Time.deltaTime - timediff;
        //print(timediff);

        if (timediff > 0) { counter += 1; }
        if (counter % 10 == 0) { print(counter); }

        if (counter>25 && counter<65) { rightArrow(); }
        if (counter>65 && counter<150) { leftArrow(); }
        if (counter > 140 && counter > 230) { upArrow(); }
        if (counter > 200 && counter < 270) { leftArrow(); }
        if (counter > 270 && counter < 395) { rightArrow(); } 

        if (counter > 55 && counter < 80)
        {
            transform.Rotate(0, 0, 90 * Time.deltaTime);
        }
        if (counter > 105 && counter < 150)
         {
             transform.Rotate(0, 0, -45 * Time.deltaTime);
             transform.Translate(0, -5 * Time.deltaTime, 0);
         }
        if (counter > 250 && counter < 305)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
        if (counter > 320 && counter < 385)
        {
            transform.Rotate(0, 0, 45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
        if (counter>=400)
        {
            Application.LoadLevel(5);
        }

    }
	// Use this for initialization

	void Start () {
        
	}

	// Update is called once per frame
	void Update () {

        run();
	}
}
