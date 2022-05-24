using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StoreSignColor : MonoBehaviour
{
    void Update()
    {
        if (GameController.storeOpen)
        {
            gameObject.GetComponent<Renderer>().material.color = Color.green;
        }
        else
        {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
        }
    }
}
