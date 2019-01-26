using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TPPControl : MonoBehaviour
{

    public Transform HUB; //Base HUB
    Transform destination;

    public void TPTo(Transform newPos)
    {
        destination = newPos;
        StartCoroutine(TPCR());
    }

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.B))
        {
            TPTo(HUB);
        }
    }

    IEnumerator TPCR()
    {
        yield return new WaitForSeconds(2.5f);
        this.transform.position = destination.position;
    }
}
