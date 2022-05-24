using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class StoreSign : Interractable
{
    public override void Active(GameObject gameObject)
    {
        GameController.storeOpen = !GameController.storeOpen;
    }
}
