using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class WaterUI : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(UpdateWater());
    }
    void Update()
    {
        gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(GameController.water * 3.5f, gameObject.GetComponent<RectTransform>().rect.height);
    }
    IEnumerator UpdateWater()
    {
        yield return new WaitForSeconds(30f);
        if (GameController.water > 0)
            GameController.water -= 3.5f;
        else if (GameController.water < 0)
            GameController.water = 0;
        StartCoroutine(UpdateWater());
    }
}
