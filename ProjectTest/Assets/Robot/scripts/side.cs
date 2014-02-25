using UnityEngine;
using System.Collections;

public class side : MonoBehaviour {

    public GameObject straight;
    public GameObject left;
    public GameObject right;


	// Use this for initialization
	void Start () {

	}

	// Update is called once per frame
	void Update () {

        straight.SetActive(true);
        left.SetActive(false);
        right.SetActive(false);
        transform.Translate(0, -5 * Time.deltaTime, 0);

       transform.Rotate(0, 0, 40*Time.deltaTime);

        //transform.Rotate(0, 0, -40 * Time.deltaTime);

      //  transform.Rotate(0, 0, 40 * Time.deltaTime);


	}
}
