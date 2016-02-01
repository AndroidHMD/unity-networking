using UnityEngine;
using System.Collections;

using UnityEngine.Networking;

public class KeyboardController : NetworkBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	const float defaultvel = 1;

	void handleMovement() {
		Vector3 velocity = Vector3.zero;

		if (Input.GetKey (KeyCode.UpArrow)) {
			print ("UPPP");

			velocity += new Vector3 (0, 0, defaultvel);

		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			print ("DOWWN");

			velocity -= new Vector3 (0, 0, defaultvel);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			print ("LEFT");
			velocity -= new Vector3 (defaultvel, 0, 0);

		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			print ("RIGHT");
			velocity += new Vector3 (defaultvel, 0, 0);
		}

		Rigidbody curr = gameObject.GetComponent<Rigidbody>();
		curr.velocity = velocity;
	}

	// Update is called once per frame
	void Update () {
		if (!isLocalPlayer) {
			return;
		}

		handleMovement();
	}
}
