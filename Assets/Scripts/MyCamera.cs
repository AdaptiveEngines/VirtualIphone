using UnityEngine;
using System.Collections;

public class MyCamera : MonoBehaviour {
	public Transform target;

	void Updata(){
		transform.LookAt (target);
	}

}
