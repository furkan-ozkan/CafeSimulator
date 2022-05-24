using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UseObjects : MonoBehaviour
{
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.F) && GameController.activeLookingObject!=null && GameController.activeLookingObject.GetComponent<GetInterractable>()!=null && !GameController.onLoad)
        {
            GameController.activeLookingObject.GetComponent<GetInterractable>().inter.Active(GameController.activeLookingObject.gameObject);
        }
    }
}
