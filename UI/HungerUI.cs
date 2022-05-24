using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HungerUI : MonoBehaviour
{
    private void Start()
    {
        StartCoroutine(UpdateHunger());
    }
    void Update()
    {
        gameObject.GetComponent<RectTransform>().sizeDelta = new Vector2(GameController.hunger*3.5f,gameObject.GetComponent<RectTransform>().rect.height);
    }
    IEnumerator UpdateHunger()
    {
        yield return new WaitForSeconds(40f);
        if (GameController.hunger > 0)
            GameController.hunger -= 3.5f;
        else if (GameController.hunger < 0)
            GameController.hunger = 0;
        StartCoroutine(UpdateHunger());
    }
}
