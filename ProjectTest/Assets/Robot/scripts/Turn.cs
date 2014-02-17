using UnityEngine;
using System.Collections;

public class Turn : MonoBehaviour {
    void Start()
    {
        transform.Rotate(75 * Vector3.up * Time.deltaTime, Space.World);

    }
	// Update is called once per frame
	void Update () {
       transform.Rotate(75 * Vector3.up * Time.deltaTime, Space.World);
     
       
	}
}
