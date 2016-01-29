using UnityEngine;
using System.Collections;

using UnityEngine.Networking;

public class KeyboardController : NetworkBehaviour {

	// Use this for initialization
	void Start () {
	
	}

	const float defaultvel = 1;

	void handleMovement() {
		Vector2 velocity = Vector2.zero;

		if (Input.GetKey (KeyCode.UpArrow)) {
			print ("UPPP");

			velocity += new Vector2 (0, defaultvel);

		}

		if (Input.GetKey (KeyCode.DownArrow)) {
			print ("DOWWN");

			velocity -= new Vector2 (0, defaultvel);
		}

		if (Input.GetKey (KeyCode.LeftArrow)) {
			print ("LEFT");
			velocity -= new Vector2 (defaultvel, 0);

		}

		if (Input.GetKey (KeyCode.RightArrow)) {
			print ("RIGHT");
			velocity += new Vector2 (defaultvel, 0);

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
