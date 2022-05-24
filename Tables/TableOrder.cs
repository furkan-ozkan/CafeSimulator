using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TableOrder : MonoBehaviour
{
    private int iCount = 0;
    private void OnCollisionEnter(Collision collision)
    {
        GameObject temp = GameObject.FindGameObjectWithTag("GameController");
        if (collision.gameObject.GetComponent<GetInterractable>()!=null && gameObject.GetComponent<TableActiveControl>().customer != null)
        {
            if (gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().foodOrder != null)
            {
                if (collision.gameObject.GetComponent<GetInterractable>().inter.GetItemId() ==
                    gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().foodOrder.GetComponent<GetInterractable>().inter.GetItemId())
                {
                    gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().foodOrder = collision.gameObject;
                    collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
                    collision.gameObject.GetComponent<Collider>().enabled = false;
                    collision.gameObject.GetComponent<GetInterractable>().enabled = false;
                    collision.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                    iCount++;
                }
            }
            if (gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().drinkOrder != null)
            {
                if (collision.gameObject.GetComponent<GetInterractable>().inter.GetItemId() ==
                    gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().drinkOrder.GetComponent<GetInterractable>().inter.GetItemId())
                {
                    gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().drinkOrder = collision.gameObject;
                    collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
                    collision.gameObject.GetComponent<Collider>().enabled = false;
                    collision.gameObject.GetComponent<GetInterractable>().enabled = false;
                    collision.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                    iCount++;
                }
            }
            if (gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().cakeOrder != null)
            {
                if (collision.gameObject.GetComponent<GetInterractable>().inter.GetItemId() ==
                    gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().cakeOrder.GetComponent<GetInterractable>().inter.GetItemId())
                {
                    gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().cakeOrder = collision.gameObject;
                    collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
                    collision.gameObject.GetComponent<Collider>().enabled = false;
                    collision.gameObject.GetComponent<GetInterractable>().enabled = false;
                    collision.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                    iCount++;
                }
            }
            if (gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().soupOrder != null)
            {
                if (collision.gameObject.GetComponent<GetInterractable>().inter.GetItemId() ==
                    gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().soupOrder.GetComponent<GetInterractable>().inter.GetItemId())
                {
                    gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().soupOrder = collision.gameObject;
                    collision.gameObject.GetComponent<Rigidbody>().useGravity = false;
                    collision.gameObject.GetComponent<Collider>().enabled = false;
                    collision.gameObject.GetComponent<GetInterractable>().enabled = false;
                    collision.gameObject.GetComponent<Rigidbody>().velocity = new Vector3(0, 0, 0);
                    iCount++;
                }
            }


            if (gameObject.GetComponent<TableActiveControl>().customer!=null)
            {
            }
            if (iCount == gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().orderAmount)
            {
                temp.GetComponent<UIOrderList>().uiOrderList[gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerToTable>().orderPlace].GetComponent<orderListEmptyCheck>().empty = true;
                temp.GetComponent<UIOrderList>().uiOrderList[gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerToTable>().orderPlace].SetActive(false);
                

                if (gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().foodOrder != null)
                {
                    GameController.money += gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().foodOrder.GetComponent<GetInterractable>().inter.GetItemPrice();
                    Destroy(gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().foodOrder);
                }
                    

                if (gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().drinkOrder != null)
                {
                    GameController.money += gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().drinkOrder.GetComponent<GetInterractable>().inter.GetItemPrice();
                    Destroy(gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().drinkOrder);
                }
                    

                if (gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().cakeOrder != null)
                {
                    GameController.money += gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().cakeOrder.GetComponent<GetInterractable>().inter.GetItemPrice();
                    Destroy(gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().cakeOrder);
                }
                    

                if (gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().soupOrder != null)
                {
                    GameController.money += gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().soupOrder.GetComponent<GetInterractable>().inter.GetItemPrice();
                    Destroy(gameObject.GetComponent<TableActiveControl>().customer.GetComponent<CustomerOrder>().soupOrder);
                }
                   

                Destroy(gameObject.GetComponent<TableActiveControl>().customer);
                gameObject.GetComponent<TableActiveControl>().customer = null;
                iCount = 0;
            }
        }
        
    }
}
