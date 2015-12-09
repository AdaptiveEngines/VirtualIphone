using UnityEngine;
using System.Collections;

public class Grid : MonoBehaviour {

	// Use this for initialization
	void OnGUI() {
		for (int i = 0; i<10; i++) {
			for(int j = 0; j<10; j++) {
				GameObject cube = GameObject.CreatePrimitive(PrimitiveType.Cube);
				cube.transform.position = new Vector3(0, 0.5F, 0);
			}
		}

	}

}
