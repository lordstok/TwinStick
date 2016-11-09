using UnityEngine;
using System.Collections;
using UnityStandardAssets.CrossPlatformInput;

public class Player : MonoBehaviour {

	// Use this for initialization
	void Start () {
		Debug.Log ("Test 2 for sourcetree upload");
	}
	
	// Update is called once per frame
	void Update () {
		Debug.Log ("H: " + CrossPlatformInputManager.GetAxis("Horizontal"));
		Debug.Log ("V: " + CrossPlatformInputManager.GetAxis("Vertical"));

	}
}
