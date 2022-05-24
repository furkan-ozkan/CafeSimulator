using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class Mustard : Interractable
{
    public override void Active(GameObject gameObject)
    {
        if (GameController.activeHoldingObject!=null && GameController.activeHoldingObject.GetComponent<GetInterractable>().inter.GetItemName()=="HotDog")
        {
            GameController.activeHoldingObject.GetComponent<CreateHotdog>().mustard = true;
        }
    }
}
