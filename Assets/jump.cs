using UnityEngine;
using System.Collections;

public class jump: MonoBehaviour {
	
	void Update () {
		if (Input.GetKeyDown ("space")) {
			transform.Translate (Vector3.up * 90 * Time.deltaTime, Space.World);
		}
	}	}