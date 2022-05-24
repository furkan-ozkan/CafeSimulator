using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Interractable : ScriptableObject
{
    [SerializeField] private bool moveable;
    [SerializeField] private string itemName;
    [SerializeField] private string itemInfo;
    [SerializeField] private int itemId;
    [SerializeField] private float itemPrice;
    public virtual void Active(GameObject gameObject)
    {

    }
    public bool GetMoveable()
    {
        return moveable;
    }
    public string GetItemName()
    {
        return itemName;
    }
    public string GetItemInfo()
    {
        return itemInfo;
    }
    public int GetItemId()
    {
        return itemId;
    }
    public void SetItemId(int id)
    {
        itemId = id;
    }
    public float GetItemPrice()
    {
        return itemPrice;
    }
    public void SetItemPrice(float itemPrice)
    {
        this.itemPrice = itemPrice;
    }
}
