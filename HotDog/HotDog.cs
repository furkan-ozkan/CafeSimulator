using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class HotDog : Interractable
{
    public override void Active(GameObject gameObject)
    {
        if (GameController.hunger <= 80)
            GameController.hunger += 20;
        else if(GameController.hunger>80)
            GameController.hunger = 100;
        Destroy(gameObject);
    }
    
}
