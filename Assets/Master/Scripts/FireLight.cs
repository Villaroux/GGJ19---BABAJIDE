using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FireLight : MonoBehaviour
{
    
	Light fireLight;
	float lightInt;
	public float minInt = 0f, maxInt = 1.5f;
	public int smooth = 5;
	
	
	Queue<float> smoothQueue;
	float lastSum = 0;


	public void Reset()
	{
		smoothQueue.Clear();
		lastSum = 0;
	}
	
	
	// Start is called before the first frame update
    void Start()
    {
        smoothQueue = new Queue<float>(smooth);
		if (fireLight == null) 
			{
				fireLight = GetComponent <Light> ();
			}
    }

    // Update is called once per frame
    void Update()
    {
        if (fireLight == null)
		return ;

		while (smoothQueue.Count >= smooth)
		{
			lastSum -= smoothQueue.Dequeue();
		}
		
		
		float newVal = Random.Range(minInt, maxInt);
		smoothQueue.Enqueue(newVal);
		lastSum += newVal;

		fireLight.intensity = lastSum / (float)smoothQueue.Count;
    }
}
