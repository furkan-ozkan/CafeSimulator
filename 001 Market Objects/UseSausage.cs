using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class UseSausage : Interractable
{
    public GameObject sausage;
    public override void Active(GameObject gameObject)
    {
        if (gameObject.GetComponent<GetInterractable>().inter.GetItemPrice()> 0 && GameController.handsFree)
        {
            gameObject.GetComponent<GetInterractable>().inter.SetItemPrice(gameObject.GetComponent<GetInterractable>().inter.GetItemPrice() - 1);
            //Instantiate(sausage, new Vector3(0, 100, 0), new Quaternion(0, 0, 0, 0));

            GameController.activeHoldingObject = Instantiate(sausage, new Vector3(0, 100, 0), new Quaternion(0, 0, 0, 0)).transform;
            GameController.handsFree = false;

            GameController.activeHoldingObject.GetComponent<Collider>().enabled = false;
            GameController.activeHoldingObject.GetComponent<Renderer>().material.color = Color.green;
            GameController.activeHoldingObject.GetComponent<Rigidbody>().useGravity = false;
            if (gameObject.GetComponent<GetInterractable>().inter.GetItemPrice() == 0)
            {
                gameObject.GetComponent<GetInterractable>().inter.SetItemPrice(10);
                Destroy(gameObject);
            }
        }
    }
}
