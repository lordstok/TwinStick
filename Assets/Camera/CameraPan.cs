using UnityEngine;
using System.Collections;

public class CameraPan : MonoBehaviour {

	private GameObject player;

	// Use this for initialization
	void Start () {
		player = GameObject.FindGameObjectWithTag("Player");
		if (player) {
			print ("found player");
		} else {
			print ("could not find player");
		}
	}

	void LateUpdate () {
		transform.LookAt (player.transform);
	}
}
