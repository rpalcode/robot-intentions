using UnityEngine;
using System.Collections;

public class scene4 : MonoBehaviour {
    public int counter = 0;
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

    void option1()
    {
        transform.Translate(0, -5 * Time.deltaTime, 0);
        timediff = Time.deltaTime - timediff;
        //print(timediff);

        if (timediff > 0) { counter += 1; }
        if (counter % 10 == 0) { print(counter); }

        if (counter > 0 && counter < 45) { leftArrow(); }
        if (counter > 45 && counter < 130) { rightArrow(); }
        if (counter > 130 && counter > 250) { upArrow(); }
        if (counter > 250 && counter < 395) { leftArrow(); }
        if (counter > 395 && counter < 460) { rightArrow(); }

        if (counter > 45 && counter < 75)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
        }

        if (counter > 290 && counter < 310)
        {
            transform.Rotate(0, 0, 45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
        if (counter > 400 && counter < 450)
        {
            transform.Rotate(0, 0, 45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }

        if (counter >= 520)
        {
            Destroy(gameObject);
            robot.rigidbody.velocity = Vector3.zero;
        }        
    }

    void option3()
    {
        upArrow();
        transform.Translate(0, -5 * Time.deltaTime, 0);

        timediff = Time.deltaTime - timediff;
        //print(timediff);

        if (timediff > 0) { counter += 1; }
        if (counter % 10 == 0) { print(counter); }

        if (counter > 45 && counter < 85) { rightArrow(); }
        if (counter > 85 && counter < 160) { leftArrow(); }
        if (counter > 160 && counter > 250) { upArrow(); }
        if (counter > 220 && counter < 290) { leftArrow(); }
        if (counter > 290 && counter < 415) { rightArrow(); }

        if (counter > 75 && counter < 90)
        {
            transform.Rotate(0, 0, 90 * Time.deltaTime);
        }
        if (counter > 340 && counter < 360)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
        if (counter > 450 && counter < 480)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
        /* if (counter > 350 && counter < 405)
         {
             transform.Rotate(0, 0, 45 * Time.deltaTime);
             transform.Translate(0, -5 * Time.deltaTime, 0);
         }
         */
        if (counter >= 600)
        {
            Destroy(gameObject);
            robot.rigidbody.velocity = Vector3.zero;
        }
    }

    void run()
    {
        upArrow();
        transform.Translate(0, -5 * Time.deltaTime, 0);

        timediff = Time.deltaTime - timediff;
        //print(timediff);

        if (timediff > 0) { counter += 1; }
        if (counter % 10 == 0) { print(counter); }

        if (counter>45 && counter<85) { rightArrow(); }
        if (counter>85 && counter<160) { leftArrow(); }
        if (counter > 160 && counter > 250) { upArrow(); }
        if (counter > 220 && counter < 290) { leftArrow(); }
        if (counter > 290 && counter < 415) { rightArrow(); } 

        if (counter > 75 && counter < 100)
        {
            transform.Rotate(0, 0, 90 * Time.deltaTime);
        }
        if (counter > 125 && counter < 170)
         {
             transform.Rotate(0, 0, -45 * Time.deltaTime);
             transform.Translate(0, -5 * Time.deltaTime, 0);
         }
        if (counter > 270 && counter < 325)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
        if (counter > 350 && counter < 405)
        {
            transform.Rotate(0, 0, 45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
        if (counter>=500)
        {
            Destroy(gameObject);
            robot.rigidbody.velocity = Vector3.zero;
        }

    }
	// Use this for initialization

	void Start () {
        
	}

	// Update is called once per frame
	void Update () {

        option1();
	}
}
