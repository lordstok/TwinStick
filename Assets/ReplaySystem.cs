﻿using UnityEngine;
using System.Collections;

public class ReplaySystem : MonoBehaviour {

	private const int bufferFrames = 100;
	private MyKeyFrame[] keyFrames = new MyKeyFrame [bufferFrames];
	private Rigidbody rigidBody;

	// Use this for initialization
	void Start () {
		rigidBody = GetComponent<Rigidbody>();
	}
	
	// Update is called once per frame
	void Update () {
		Record ();

	}

	public void PlayBack () {
		rigidBody.isKinematic = true;
		int frame = Time.frameCount % bufferFrames;
		print ("Reading frame " + frame);
		transform.position = keyFrames [frame].position;
		transform.rotation = keyFrames [frame].rotation;
	}

	public void Record () {
		rigidBody.isKinematic = false;
		int frame = Time.frameCount % bufferFrames;
		float time = Time.time;
//		print ("Writing frame " + frame);
		keyFrames [frame] = new MyKeyFrame (time, transform.position, transform.rotation);
	}
}

/// <summary>
/// A structure for storing time, rotation and position.
/// </summary>
public class MyKeyFrame {
		public float frameTime;
		public Vector3 position;
		public Quaternion rotation;

		public MyKeyFrame (float aTime, Vector3 aPosition, Quaternion aRotation) {
			this.frameTime = aTime;
			this.position = aPosition;
			this.rotation = aRotation;
		}

}