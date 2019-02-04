using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateFOV : MonoBehaviour
{ 
    public GameObject go;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        go.SetActive(true);
        gameObject.SetActive(false);
    }
}
