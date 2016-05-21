using UnityEngine;
using System.Collections;

public class PlayAnimation : MonoBehaviour {
	public Animation animation;
	public Transform left;
	public Transform right;

	void Awake(){
		animation = gameObject.GetComponent<Animation>();
	}
	void Update () {
		animation.wrapMode = WrapMode.Loop;
		float speed = 8 * Time.deltaTime;
		if (Input.GetKey (KeyCode.A)) {

				animation.Play ();
				animation.enabled = true;

			transform.LookAt(left);
			transform.Translate (Vector3.forward * speed);
		}
		if (Input.GetKeyUp (KeyCode.A)) {
			animation.enabled = false;
		}
			
		if (Input.GetKey (KeyCode.D)) {

				animation.Play ();
				animation.enabled = true;
			transform.LookAt(right);
			transform.Translate (Vector3.forward * speed);

		}
		if (Input.GetKeyUp (KeyCode.D)) {
			animation.enabled = false;
		}
	}
}
