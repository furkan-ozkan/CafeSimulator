using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableActiveControl : MonoBehaviour
{
    public GameObject chairOne, chairTwo,customer;
    public bool active=false;
    private bool once = false;
    private bool store = false;
    public int tableNum;
    void Update()
    {
        if (chairOne != null && chairTwo != null && store)
            active = true;
        else
            active = false;

        if (active){
            gameObject.GetComponent<Renderer>().material.color = Color.green;
            if (once == false)
            {
                GameController.allTables.Add(gameObject);
                tableNum = GameController.allTables.IndexOf(gameObject);
                //GameController.emptyTables.Add(gameObject);
                once = true;
            }
        }
        else {
            gameObject.GetComponent<Renderer>().material.color = Color.red;
            //if(GameController.allTables.IndexOf(gameObject)!= null)
            //{
                GameController.allTables.Remove(gameObject);
                once = false;
            //}
        }
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.GetComponent<GetInterractable>() && other.GetComponent<GetInterractable>().inter.GetItemName() == "Chair")
        {
            if (chairOne == null)
                chairOne = other.gameObject;
            else if(chairTwo == null)
                chairTwo = other.gameObject;
        }
        else { }
        if (other.tag == "Customer" && customer == null && other.GetComponent<CustomerToTable>().emptyCustomer)
        {
            customer = other.gameObject;
            customer.GetComponent<CustomerToTable>().emptyCustomer = false;
            //GameController.emptyTables.Remove(gameObject);
            //GameController.activeTables.Add(gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<GetInterractable>() && other.GetComponent<GetInterractable>().inter.GetItemName() == "Chair")
        {
            if (chairOne != null)
                chairOne = null;
            else
                chairTwo = null;
        }
        if (other.tag == "Customer" && other == customer)
        {
            customer = null;
            //GameController.emptyTables.Add(gameObject);
            //GameController.activeTables.Remove(gameObject);
        }
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.tag == "StoreGround")
            store = true;
        else if(collision.transform.tag == "outground")
            store = false;
    }
}
