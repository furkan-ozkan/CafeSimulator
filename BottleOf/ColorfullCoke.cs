using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class ColorfullCoke : Interractable
{
    public override void Active(GameObject gameObject)
    {
        if (GameController.water <= 80)
        {
            GameController.water += 20;
        }
        else if (GameController.water > 80 && GameController.water != 100)
        {
            GameController.water = 100;
        }
        Destroy(gameObject);
    }
}
