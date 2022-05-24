using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu]
public class PaperTowelPart : Interractable
{
    public GameObject Hotdog;
    public override void Active(GameObject gameObject)
    {
        if (gameObject.GetComponent<towelpartHolder>().bread && gameObject.GetComponent<towelpartHolder>().sausage)
        {
            BeforeSaveData.itemsOnMap.Remove(gameObject.GetComponent<towelpartHolder>().sausageobj);
            BeforeSaveData.itemsOnMap.Remove(gameObject.GetComponent<towelpartHolder>().breadobj);
            Destroy(gameObject.GetComponent<towelpartHolder>().sausageobj);
            Destroy(gameObject.GetComponent<towelpartHolder>().breadobj);
            Destroy(gameObject);
            Instantiate(Hotdog,gameObject.transform.position,new Quaternion(0,0,0,0));
        }
    }
}
