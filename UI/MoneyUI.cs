using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;


public class MoneyUI : MonoBehaviour
{
    void Update()
    {
        gameObject.GetComponent<TextMeshProUGUI>().SetText(GameController.money.ToString() + "$");
    }
}
