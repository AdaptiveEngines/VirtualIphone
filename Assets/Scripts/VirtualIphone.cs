using UnityEngine;
using System.Collections;
using LocationTracking;

public class VirtualIphone : MonoBehaviour {
	// Use this for initialization
	void Start () {
		IOSPlugin.UnityInitSensor ();
		IOSPlugin.UnityStartSensorData ();
	}
	
	// Update is called once per frame
	void Update () {
		transform.position = IOSPlugin.UnityGetPosition();
		transform.rotation = IOSPlugin.UnityGetAttitude();
	}
}
