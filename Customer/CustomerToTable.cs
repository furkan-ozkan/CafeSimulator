using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerToTable : MonoBehaviour
{
    [SerializeField] private Transform path1, path2;
    public Transform tablePos;
    public int current = 0;
    public int orderPlace;
    public bool emptyCustomer = true;
    void Start()
    {
        
    }

    void Update()
    {
        if (current == 0)
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(path1.position.x, gameObject.transform.position.y, path1.position.z), 6*Time.deltaTime);
            if (gameObject.transform.position.x == path1.position.x && gameObject.transform.position.z == path1.position.z)
            {
                current++;
            }
        }
        else if (current == 1)
        {
            transform.position = Vector3.MoveTowards(gameObject.transform.position, new Vector3(path2.position.x, gameObject.transform.position.y, path2.position.z), 6 * Time.deltaTime);
            if (gameObject.transform.position.x == path2.position.x && gameObject.transform.position.z == path2.position.z)
            {
                current++;
            }
        }
        else if (current == 2)
        {
            // teleport to chair
            gameObject.GetComponent<Rigidbody>().useGravity = false;
            gameObject.GetComponent<BoxCollider>().isTrigger=true;
            if (tablePos.gameObject.GetComponent<TableActiveControl>().chairOne.transform.position != null)
            {
                transform.position = tablePos.gameObject.GetComponent<TableActiveControl>().chairOne.transform.position;
            }
            else
                Destroy(gameObject);
        }
    }
}
