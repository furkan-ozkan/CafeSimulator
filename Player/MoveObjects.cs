using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MoveObjects : MonoBehaviour
{
    [SerializeField] private Transform holdPlace;
    void Update()
    {
        if (!GameController.onLoad)
        {
            if (Input.GetKeyDown(KeyCode.H) && GameController.handsFree && GameController.activeLookingObject != null && GameController.activeLookingObject.GetComponent<GetInterractable>().inter.GetMoveable())
            {
                GameController.handsFree = false;
                GameController.activeHoldingObject = GameController.activeLookingObject;
                GameController.activeHoldingObject.position = holdPlace.position;
                GameController.activeHoldingObject.rotation = new Quaternion(0, GameController.activeHoldingObject.rotation.y, 0, 0);
            }
            if (!GameController.handsFree)
            {
                StartCoroutine(ColiderClose());

                if (GameController.activeLookingPlace != null && Input.GetKey(KeyCode.Mouse1))
                {
                    GameController.activeHoldingObject.position = new Vector3(GameController.activeLookingPlace.x,
                        GameController.activeLookingPlace.y + 0.02f, GameController.activeLookingPlace.z);
                    if (Input.GetKey(KeyCode.Q))
                    {
                        GameController.activeHoldingObject.Rotate(0, 100 * Time.deltaTime, 0);
                    }
                    if (Input.GetKey(KeyCode.E))
                    {
                        GameController.activeHoldingObject.Rotate(0, -100 * Time.deltaTime, 0);
                    }
                }
                else if (!Input.GetKeyUp(KeyCode.Mouse1))
                    GameController.activeHoldingObject.position = holdPlace.position;

                if (Input.GetKeyUp(KeyCode.Mouse1))
                {
                    //------------------------- do when stop holding an object ------------------------
                    GameController.activeHoldingObject.GetComponent<Collider>().enabled = true;
                    if (GameController.activeHoldingObject.GetComponent<BoxCollider>())
                        GameController.activeHoldingObject.GetComponent<BoxCollider>().enabled = true;
                    if (GameController.activeHoldingObject.GetComponent<BoxCollider>())
                        GameController.activeHoldingObject.GetComponent<BoxCollider>().enabled = true;
                    GameController.activeHoldingObject.GetComponent<Renderer>().material.color = Color.white;
                    GameController.activeHoldingObject.GetComponent<Rigidbody>().useGravity = true;
                    //------------------------- do when stop holding an object ------------------------
                    GameController.handsFree = true;
                    GameController.activeHoldingObject = null;
                }

            }
        }
    }
    IEnumerator ColiderClose()
    {
        yield return new WaitForSeconds(.1f);
        //------------------------- do when hold an object ------------------------
        if (GameController.activeHoldingObject!=null)
        {
            GameController.activeHoldingObject.GetComponent<Collider>().enabled = false;
            if (GameController.activeHoldingObject.GetComponent<BoxCollider>())
                GameController.activeHoldingObject.GetComponent<BoxCollider>().enabled = false;
            GameController.activeHoldingObject.GetComponent<Renderer>().material.color = Color.green;
            GameController.activeHoldingObject.GetComponent<Rigidbody>().useGravity = false;
        }
        //------------------------- do when hold an object ------------------------
    }
}
