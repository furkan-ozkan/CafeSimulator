using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : MonoBehaviour
{
    public static float hunger = 100, hungerMax = 100;
    public static float water = 100, waterMax = 100;
    //public static int sleep = 0, sleepMax = 100;
    public static float money = 985;
    public static bool storeOpen=false;
    public static Vector3 activeLookingPlace;
    public static Transform activeLookingObject;
    public static bool handsFree=true;
    public static Transform activeHoldingObject;
    public static List<GameObject> allTables = new List<GameObject>();
    public static bool onLoad = true;
}
