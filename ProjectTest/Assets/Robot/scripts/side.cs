using UnityEngine;
using System.Collections;

public class side : MonoBehaviour {
    public int counter = 0;
    public double timediff = 0.0;
    public GameObject straight;
    public GameObject left;
    public GameObject right;
    public GameObject robot;

    public GameObject l1;
    public GameObject l2;
    public GameObject l3;
    public GameObject l4;
    public GameObject l5;
    public GameObject l6;
    public GameObject l7;
    public GameObject l8;
    public GameObject l9;
    public GameObject l10;
    public GameObject l11;
    public GameObject l12;
    public GameObject l13;
    public GameObject l14;
    public GameObject l15;
    public GameObject l16;
    public GameObject l17;
    public GameObject l18;
    public GameObject l19;
    public GameObject l20;

    void Initial()
    {
        l1.SetActive(true);
        l2.SetActive(true);
        l3.SetActive(true);
        l4.SetActive(true);
        l5.SetActive(false);
        l6.SetActive(false);
        l7.SetActive(false);
        l8.SetActive(false);
        l9.SetActive(false);
        l10.SetActive(false);
        l11.SetActive(false);
        l12.SetActive(false);
        l13.SetActive(false);
        l14.SetActive(false);
        l15.SetActive(false);
        l16.SetActive(false);
        l17.SetActive(false);
        l18.SetActive(false);
        l19.SetActive(false);
        l20.SetActive(false);

    }

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

    void run()
    {
        upArrow();
        transform.Translate(0, -5 * Time.deltaTime, 0);

        timediff = Time.deltaTime - timediff;
        //print(timediff);
        int i = 0;
        if (counter > 47)
        { l1.SetActive(false); l5.SetActive(true); }
        if (counter > 80)
        { l2.SetActive(false); l6.SetActive(true); }
        if (counter > 90)
        { l3.SetActive(false); l7.SetActive(true); }
        if (counter > 130)
        { l4.SetActive(false); l8.SetActive(true); }
        if (counter > 160)
        { l5.SetActive(false); l9.SetActive(true); }
        if (counter > 200)
        { l6.SetActive(false); l10.SetActive(true); }
        if (counter > 220)
        { l7.SetActive(false); l11.SetActive(true); }
        if (counter > 250)
        { l8.SetActive(false); l12.SetActive(true); }
        if (counter > 280)
        { l9.SetActive(false); l13.SetActive(true); }
        if (counter > 310)
        { l10.SetActive(false); l14.SetActive(true); }
        if (counter > 320)
        { l11.SetActive(false); l15.SetActive(true); }
        if (counter > 340)
        { l12.SetActive(false); l16.SetActive(true); }
        if(counter > 345)
        { l9.SetActive(false); l13.SetActive(true); }
        if (counter > 350)
        { l10.SetActive(false); l14.SetActive(true); }
        if (counter > 351)
        { l11.SetActive(false); l15.SetActive(true); }
        if (counter > 352)
        { l12.SetActive(false); l16.SetActive(true); }
        if (counter > 345)
        { l13.SetActive(false); l17.SetActive(true); }
        if (counter > 350)
        { l14.SetActive(false); l18.SetActive(true); }
        if (counter > 351)
        { l15.SetActive(false); l19.SetActive(true); }
        if (counter > 352)
        { l16.SetActive(false); l20.SetActive(true); }
        if (counter > 353)
        { l17.SetActive(false);  }
        if (counter > 354)
        { l18.SetActive(false); }
        if (counter > 355)
        { l19.SetActive(false); }
        if (counter > 356)
        { l20.SetActive(false); }

        if (timediff > 0) { counter += 1; }
        if (counter % 10 == 0) { print(counter); }

        if (counter > 45 && counter < 85) { rightArrow(); l1.SetActive(false); }
        if (counter>85 && counter<160) { leftArrow(); }
        if (counter > 160 && counter > 250) { upArrow(); }
        if (counter > 250 && counter < 395) { leftArrow(); }
        if (counter > 395 && counter < 460) { rightArrow(); } 

        if (counter > 75 && counter < 100)
        {
            transform.Rotate(0, 0, 90 * Time.deltaTime);
        }
        if (counter > 125 && counter < 170)
         {
             transform.Rotate(0, 0, -45 * Time.deltaTime);
             transform.Translate(0, -5 * Time.deltaTime, 0);
         }
        if (counter > 340 && counter < 405)
        {
            transform.Rotate(0, 0, -45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
        if (counter > 415 && counter < 470)
        {
            transform.Rotate(0, 0, 45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
        if (counter>=500)
        {
            robot.rigidbody.velocity = Vector3.zero;
        }

    }
	// Use this for initialization
	void Start () {
        
	}

	// Update is called once per frame
	void Update () {
        Initial();
        run();
	}
}
