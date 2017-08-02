﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraController : MonoBehaviour {
	public GameObject player;
	private Vector3 offest;

	// Use this for initialization
	void Start () {
		offest = transform.position - player.transform.position;
	}
	
	void LateUpdate () {
		transform.position = player.transform.position + offest;
	}
}
