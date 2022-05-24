using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerOrder : MonoBehaviour
{
    public GameObject orderList;
    public GameObject foodOrder;
    public GameObject drinkOrder;
    public GameObject cakeOrder;
    public GameObject soupOrder;
    public int orderAmount=0;
    private void Start()
    {
        orderAmount = 0;
        orderList = GameObject.FindGameObjectWithTag("GameController");
        foodOrder=orderList.GetComponent<OrderList>().ORDERLISTFOOD[Random.Range(0, orderList.GetComponent<OrderList>().ORDERLISTFOOD.Count)];
        orderAmount++;
        if (Random.Range(0, 101) < 60)
        {
            drinkOrder = orderList.GetComponent<OrderList>().ORDERLISTDRINK[Random.Range(0, orderList.GetComponent<OrderList>().ORDERLISTDRINK.Count)];
            orderAmount++;
        }
        /*if (Random.Range(0, 101) < 15){
            cakeOrder = orderList.GetComponent<OrderList>().ORDERLISTCAKE[Random.Range(0, orderList.GetComponent<OrderList>().ORDERLISTCAKE.Count)];
            orderAmount++;
        }
        if (Random.Range(0, 101) < 30){
            soupOrder = orderList.GetComponent<OrderList>().ORDERLISTSOUP[Random.Range(0, orderList.GetComponent<OrderList>().ORDERLISTSOUP.Count)];
            orderAmount++;
        }
        */
    }

}
