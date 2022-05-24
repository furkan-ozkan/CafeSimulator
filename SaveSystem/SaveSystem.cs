using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

public class SaveSystem : MonoBehaviour
{
    public static void SaveGame()
    {
        BinaryFormatter formatter = new BinaryFormatter();
        string path = Application.persistentDataPath + "/save.save";
        FileStream stream = new FileStream(path, FileMode.Create);

        SaveData data = new SaveData();

        formatter.Serialize(stream,data);
        stream.Close();
    }
    public static void LoadGame()
    {
        string path = Application.persistentDataPath + "/save.save";
        if (File.Exists(path))
        {
            BinaryFormatter formatter = new BinaryFormatter();
            FileStream stream = new FileStream(path, FileMode.Open);

            SaveData data = formatter.Deserialize(stream) as SaveData;
            stream.Close();

            // injure in game in here
            InjureData(data);
        }
        else
        {
            Debug.LogError("Save file not found!");
        }
    }
    private static void InjureData(SaveData data)
    {
        string[] tempPos;
        string[] tempRot;
        int tempId;
        GameObject tempGameObject;


        GameController.hunger = data.hunger;
        GameController.water = data.water;
        GameController.money = data.money;

        for (int i = 0; i < data.itemIds.Count; i++)
        {
            tempId = data.itemIds[i];
            tempPos = data.itemPos[i].Split(';');
            tempRot = data.itemRot[i].Split(';');

            for (int j = 0; j < GameObject.FindGameObjectWithTag("GameController").GetComponent<ItemList>().items.Count; j++)
            {
                if (GameObject.FindGameObjectWithTag("GameController").GetComponent<ItemList>().items[j].GetComponent<GetInterractable>().inter.GetItemId() == tempId)
                {
                    tempGameObject = GameObject.FindGameObjectWithTag("GameController").GetComponent<ItemList>().items[j];
                    Instantiate(tempGameObject, new Vector3(float.Parse(tempPos[0]), float.Parse(tempPos[1]), float.Parse(tempPos[2])), new Quaternion(float.Parse(tempRot[0]), float.Parse(tempRot[1]), float.Parse(tempRot[2]), float.Parse(tempRot[3])));
                    break;
                }
            }

            
        }
    }
}
