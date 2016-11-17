using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

private bool recording;

	// Use this for initialization
	void Start () {
		recording = true;
	}
	
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButtonDown("Fire1")){
			recording = false;
	//		playback;
		} else {
	//		ReplaySystem.Record();

		}
	}
}
