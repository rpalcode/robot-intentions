using UnityEngine;
using System.Collections;

public class side : MonoBehaviour {
    public int counter = 0;
    public double timediff = 0.0;
    public GameObject straight;
    public GameObject left;
    public GameObject right;
    public GameObject path;

    void run()
    {
        straight.SetActive(true);
        left.SetActive(false);
        right.SetActive(false);
        transform.Translate(0, -5 * Time.deltaTime, 0);

        timediff = Time.deltaTime - timediff;
        //print(timediff);

        if (timediff > 0) { counter += 1; }
        if (counter % 10 == 0) { print(counter); }
        
        
        if (counter > 75 && counter < 100)
        {
            print("TURNING!");
            transform.Rotate(0, 0, 90 * Time.deltaTime);
        }

        if (counter > 125 && counter < 170)
         {
             print("TURNING OTHER WAY");
             transform.Rotate(0, 0, -45 * Time.deltaTime);
             transform.Translate(0, -5 * Time.deltaTime, 0);
         }

        if (counter > 340 && counter < 395)
        {
            print("TURNING LEFT");
            transform.Rotate(0, 0, -45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }

        if (counter > 415 && counter < 460)
        {
            print("TURNING RIGHT");
            transform.Rotate(0, 0, 45 * Time.deltaTime);
            transform.Translate(0, -5 * Time.deltaTime, 0);
        }
        if (counter==500)
        {
            transform.Translate(0, 0, 0);
        }
        //transform.Rotate(0, 0, -40 * Time.deltaTime);

        //  transform.Rotate(0, 0, 40 * Time.deltaTime);


    }
	// Use this for initialization
	void Start () {
        
	}

	// Update is called once per frame
	void Update () {

        if (Input.GetKeyDown("space"))
        {
            path.SetActive(false);
        }
        run();


	}
}
