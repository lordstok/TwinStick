using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class GameManager : MonoBehaviour {

	public bool recording = true;
	private float initialFixedDeltaTime;
	private bool isPaused;

	// Use this for initialization
	void Start () {
		initialFixedDeltaTime = Time.fixedDeltaTime;
		print ("Initial fixedDeltaTime = " + initialFixedDeltaTime);
		isPaused = false;
	}
	
	// Update is called once per frame
	void Update () {
		if (CrossPlatformInputManager.GetButton("Fire1")){
			recording = false;
		} else {
			recording = true;
		}

		if (Input.GetKeyDown (KeyCode.P)) {
			PauseGame ();
		}

		if (Input.GetKeyDown (KeyCode.R)) {
			ResumeGame ();
		}

	}

	void ResumeGame () {
		isPaused = false;
		Time.timeScale = 1f;
		Time.fixedDeltaTime = initialFixedDeltaTime;
	}

	void PauseGame () {
		isPaused = true;
		Time.timeScale = 0;
		Time.fixedDeltaTime = 0;
	}

	void OnApplicationPause (bool pauseStatus) {
		isPaused = pauseStatus;
	}
}
