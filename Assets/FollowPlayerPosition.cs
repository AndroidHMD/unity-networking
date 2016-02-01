using UnityEngine;
using System.Collections;

using UnityEngine.Networking;

public class FollowPlayerPosition : MonoBehaviour {
	public Vector3 relativePosition;

	void Update () {
		GameObject[] players = GameObject.FindGameObjectsWithTag("Player");

		foreach (GameObject player in players) {
			NetworkIdentity networkIdentity = player.GetComponent<NetworkIdentity>();

			if (networkIdentity.isLocalPlayer) {
				Vector3 playerPosition = player.transform.position;
				transform.position = playerPosition + relativePosition;

				return;
			}
		}
	}
}
