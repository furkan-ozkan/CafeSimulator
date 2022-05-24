using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class BuySausage : Interractable
{
    public GameObject useSausage;
    public override void Active(GameObject gameObject)
    {
        if (GameController.handsFree && GameController.money>= gameObject.GetComponent<GetInterractable>().inter.GetItemPrice())
        {
            GameController.money -= gameObject.GetComponent<GetInterractable>().inter.GetItemPrice();
            //Instantiate(useSausage, new Vector3(0, 100, 0), new Quaternion(0, 0, 0, 0));

            GameController.activeHoldingObject = Instantiate(useSausage, new Vector3(0, 100, 0), new Quaternion(0, 0, 0, 0)).transform;
            GameController.handsFree = false;

            GameController.activeHoldingObject.GetComponent<Collider>().enabled = false;
            GameController.activeHoldingObject.GetComponent<Renderer>().material.color = Color.green;
            GameController.activeHoldingObject.GetComponent<Rigidbody>().useGravity = false;
        }
    }
}
