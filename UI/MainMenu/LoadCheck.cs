using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LoadCheck : MonoBehaviour
{
    public static bool load = false;
    void Start()
    {
        DontDestroyOnLoad(gameObject);   
    }
}
