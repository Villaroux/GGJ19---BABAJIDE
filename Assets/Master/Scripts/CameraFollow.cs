﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    public Transform target;

	public float smoothSpeed = 0.125f;

	public Vector3 offset;

	
	void Start ()
	{
		offset = transform.position - target.transform.position;
	}
	
	
	void FixedUpdate ()
	{
		Vector3 desiredPosition = target.position + offset;
		Vector3 smoothedPosition = Vector3.Lerp (transform.position, desiredPosition, smoothSpeed);
		transform.position = smoothedPosition;
        //transform.LookAt(target);
	}
}
