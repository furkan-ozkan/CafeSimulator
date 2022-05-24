using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateHotdog : MonoBehaviour
{
    public GameObject ketc, may, mus;
    public bool ketchup=false, mayonnaise = false, mustard = false;
    private void Update()
    {
        if (ketchup)
            ketc.SetActive(true);
        if (mayonnaise)
            may.SetActive(true);
        if (mustard)
            mus.SetActive(true);

        if (ketchup && mayonnaise && mustard)
            gameObject.GetComponent<GetInterractable>().inter = GameObject.FindGameObjectWithTag("GameController").GetComponent<OrderList>().ORDERLISTFOOD[7].GetComponent<GetInterractable>().inter;

        else if (ketchup && mayonnaise)//4
            gameObject.GetComponent<GetInterractable>().inter = GameObject.FindGameObjectWithTag("GameController").GetComponent<OrderList>().ORDERLISTFOOD[4].GetComponent<GetInterractable>().inter;
        else if (mayonnaise && mustard)//6
            gameObject.GetComponent<GetInterractable>().inter = GameObject.FindGameObjectWithTag("GameController").GetComponent<OrderList>().ORDERLISTFOOD[6].GetComponent<GetInterractable>().inter;
        else if (ketchup && mustard)//5
            gameObject.GetComponent<GetInterractable>().inter = GameObject.FindGameObjectWithTag("GameController").GetComponent<OrderList>().ORDERLISTFOOD[5].GetComponent<GetInterractable>().inter;

        else if (ketchup)//1
            gameObject.GetComponent<GetInterractable>().inter = GameObject.FindGameObjectWithTag("GameController").GetComponent<OrderList>().ORDERLISTFOOD[1].GetComponent<GetInterractable>().inter;
        else if (mayonnaise)//2
            gameObject.GetComponent<GetInterractable>().inter = GameObject.FindGameObjectWithTag("GameController").GetComponent<OrderList>().ORDERLISTFOOD[2].GetComponent<GetInterractable>().inter;
        else if (mustard)//3
            gameObject.GetComponent<GetInterractable>().inter = GameObject.FindGameObjectWithTag("GameController").GetComponent<OrderList>().ORDERLISTFOOD[3].GetComponent<GetInterractable>().inter;
    }
}
