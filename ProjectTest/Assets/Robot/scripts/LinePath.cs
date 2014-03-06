using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class LinePath : MonoBehaviour {
    public LineRenderer line;
    //List<Vector3> element;
	// Use this for initialization
	void Start () {
        line = gameObject.GetComponent<LineRenderer>();
        //element = new List<Vector3>();
    }
	
	// Update is called once per frame
	void Update () {
       /* line.SetVertexCount(element.count);

        for (int j = 0; j < element.count; j += 1)
        {
            line.SetPosition(j, element[j]);
        }
        */
        if (Time.deltaTime < 0)
        {
            print(Time.deltaTime);
            print("FIXING LINE");
            line.SetVertexCount(0);
        }
        else if (Time.deltaTime > 0)
        {
            //line.SetVertexCount(2);
            //element.RemoveAt(1);
            print("CHANGING LINE");
        }
	}
}
