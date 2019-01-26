using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DestroyAfter : MonoBehaviour
{
    public bool Die = false;
    public float destroyTimer;
    float timer;

    // Update is called once per frame
    void Update()
    {
        if(Die)
        {
            timer = +Time.deltaTime;
            if (timer > destroyTimer)
            {
                Destroy(gameObject);
            }
        }
    }
}
