using UnityEngine;
using System.Collections;

public class scene6 : MonoBehaviour {
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


    void option3()
    {
        upArrow();
        transform.Translate(0, -5 * Time.deltaTime, 0);

        timediff = Time.deltaTime - timediff;
        //print(timediff);

        if (timediff > 0) { counter += 1; }
        if (counter % 10 == 0) { print(counter); }

        if (counter > 30 && counter < 65) { rightArrow(); }
        if (counter > 240 && counter < 330) { leftArrow(); }
        if (counter > 380 && counter < 450) { leftArrow(); }

        if (counter > 55 && counter < 70)
        {
            transform.Rotate(0, 0, 90 * Time.deltaTime);
        }
        if (counter > 320 && counter < 340)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
        if (counter > 430 && counter < 460)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }

        if (counter >= 600)
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

        option3();
	}
}
