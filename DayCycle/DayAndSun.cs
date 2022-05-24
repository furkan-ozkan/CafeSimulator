using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DayAndSun : MonoBehaviour
{
    public GameObject sun;
    public float minute=1440;
    private float gameTime=0;
    void Start()
    {
        StartCoroutine(HourCalculator());
    }
    void Update()
    {
        Debug.Log(gameTime);
        sun.transform.rotation = Quaternion.Euler(new Vector3(gameTime/4,0,0));
    }
    IEnumerator HourCalculator()
    {
        yield return new WaitForSeconds(.5f);
        minute -= 1;
        gameTime = minute % 360;
        gameTime %= 360;
        StartCoroutine(HourCalculator());
    }
}
