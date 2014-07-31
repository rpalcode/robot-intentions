using UnityEngine;
using System.Collections;

public class MoveRift : MonoBehaviour {
	int i=0;
	public OVRCameraController ovr;

	void Start(){
		ovr = GameObject.Find("OVRCameraController").GetComponent<OVRCameraController>();
	}
	void Update(){
		if(Time.timeSinceLevelLoad > 1 && Time.timeSinceLevelLoad < 3)
			ovr.SetYRotation(i++);
		if(Time.timeSinceLevelLoad > 5 && Time.timeSinceLevelLoad < 6)
			ovr.SetYRotation(i--);
	}
}
