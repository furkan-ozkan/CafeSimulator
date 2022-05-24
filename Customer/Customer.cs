using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

[CreateAssetMenu]
public class Customer : Interractable
{
    public override void Active(GameObject gameObject)
    {
        GameObject controller = GameObject.FindGameObjectWithTag("GameController");
        string customerText="Table "+gameObject.GetComponent<CustomerToTable>().tablePos.gameObject.GetComponent<TableActiveControl>().tableNum+" : ";

        if (gameObject.GetComponent<CustomerOrder>().foodOrder != null)
        {
            customerText += gameObject.GetComponent<CustomerOrder>().foodOrder.GetComponent<GetInterractable>().inter.GetItemInfo()+"\n";
        }
        if (gameObject.GetComponent<CustomerOrder>().drinkOrder != null)
        {
            customerText += gameObject.GetComponent<CustomerOrder>().drinkOrder.GetComponent<GetInterractable>().inter.GetItemInfo() + "\n";
        }
        if (gameObject.GetComponent<CustomerOrder>().cakeOrder != null)
        {
            customerText += gameObject.GetComponent<CustomerOrder>().cakeOrder.GetComponent<GetInterractable>().inter.GetItemInfo() + "\n";
        }
        if (gameObject.GetComponent<CustomerOrder>().soupOrder != null)
        {
            customerText += gameObject.GetComponent<CustomerOrder>().soupOrder.GetComponent<GetInterractable>().inter.GetItemInfo() + "\n";
        }


        for (int i = 0; i < controller.GetComponent<UIOrderList>().uiOrderList.Count; i++)
        {
            if (controller.GetComponent<UIOrderList>().uiOrderList[i].GetComponent<orderListEmptyCheck>().empty == true)
            {
                gameObject.GetComponent<CustomerToTable>().orderPlace = i;
                controller.GetComponent<UIOrderList>().uiOrderList[i].transform.GetChild(0).GetChild(0).GetComponent<TextMeshProUGUI>().SetText(customerText);
                controller.GetComponent<UIOrderList>().uiOrderList[i].GetComponent<orderListEmptyCheck>().empty = false;
                controller.GetComponent<UIOrderList>().uiOrderList[i].SetActive(true);
                break;
            }
        }
        
        
    }
}
