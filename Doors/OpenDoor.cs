using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class OpenDoor : Interractable
{
    private bool opposite = false;
    public override void Active(GameObject gameObject)
    {
        if (opposite == false)
        {
            gameObject.transform.rotation = new Quaternion(0,-gameObject.GetComponent<GetInterractable>().inter.GetItemPrice(),0,0);
            opposite = true;
        }
        else
        {
            gameObject.transform.rotation = new Quaternion(0,0, 0, 0);
            opposite =false;
        }
    }
}
