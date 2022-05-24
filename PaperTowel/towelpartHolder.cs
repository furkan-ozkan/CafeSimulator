using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class towelpartHolder : MonoBehaviour
{
    public bool sausage, bread;
    public GameObject sausageobj, breadobj;
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.transform.GetComponent<GetInterractable>() && collision.transform.GetComponent<GetInterractable>().inter.GetItemName() == "Hotdog Bread")
        {
            breadobj = collision.gameObject;
            gameObject.transform.SetParent(collision.transform);
            bread = true;
        }
        if (collision.transform.GetComponent<GetInterractable>() && collision.transform.GetComponent<GetInterractable>().inter.GetItemName() == "Sausage")
        {
            sausageobj = collision.gameObject;
            gameObject.transform.SetParent(collision.transform);
            sausage = true;
        }
    }
}
