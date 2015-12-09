using UnityEngine;
using System.Collections;
using LocationTracking;

public class StateText : MonoBehaviour {

	TextMesh t;
	// Use this for initialization
	void Start () {
		t = (TextMesh)gameObject.GetComponent (typeof(TextMesh));
	}
	
	// Update is called once per frame
	void Update () {
		t.text = IOSPlugin.UnityGetState ();
	}
}
