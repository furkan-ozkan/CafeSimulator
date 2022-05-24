using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PaperTowel : Interractable
{
    public GameObject paperTowel;
    public override void Active(GameObject gameObject)
    {
        //Instantiate(paperTowel,gameObject.transform.position-new Vector3(.32f,0.1f,0), new Quaternion(0,0,0,0));
        Instantiate(paperTowel,new Vector3(0,100,0), new Quaternion(0, 0, 0, 0));
        
        GameController.activeHoldingObject= Instantiate(paperTowel, new Vector3(0, 100, 0), new Quaternion(0, 0, 0, 0)).transform;
        GameController.handsFree = false;

        GameController.activeHoldingObject.GetComponent<Collider>().enabled = false;
        GameController.activeHoldingObject.GetComponent<Renderer>().material.color = Color.green;
        GameController.activeHoldingObject.GetComponent<Rigidbody>().useGravity = false;
    }
}
