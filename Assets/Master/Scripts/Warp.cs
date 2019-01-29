using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Warp : MonoBehaviour
{
    
	
	public Transform warpTarget;

    void OnTriggerEnter2D(Collider2D other)
	{
		other.gameObject.transform.position = warpTarget.position;
	}
}
