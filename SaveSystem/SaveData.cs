using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class SaveData
{
    public float hunger, water, money;
    public List<int> itemIds=new List<int>();
    public List<string> itemPos = new List<string>();
    public List<string> itemRot = new List<string>();

    public SaveData()
    {
        this.hunger = GameController.hunger;
        this.water = GameController.water;
        this.money = GameController.money;

        for (int i = 0; i < BeforeSaveData.itemsOnMap.Count; i++)
        {
            itemIds.Add(BeforeSaveData.itemsOnMap[i].GetComponent<GetInterractable>().inter.GetItemId());
            itemPos.Add(BeforeSaveData.itemsOnMap[i].transform.position.x + ";" + BeforeSaveData.itemsOnMap[i].transform.position.y+";"+ BeforeSaveData.itemsOnMap[i].transform.position.z);
            itemRot.Add(BeforeSaveData.itemsOnMap[i].transform.rotation.x + ";" + BeforeSaveData.itemsOnMap[i].transform.rotation.y + ";" + BeforeSaveData.itemsOnMap[i].transform.rotation.z + ";" + BeforeSaveData.itemsOnMap[i].transform.rotation.w);
        }
    }
}
