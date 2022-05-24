using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CustomerSpawn : MonoBehaviour
{
    [SerializeField] private GameObject customerSpawnPoint;
    [SerializeField] private List<GameObject> customerList;
    void Start()
    {
        StartCoroutine(CustomerSpawnScript());
    }

    void Update()
    {
    }
    IEnumerator CustomerSpawnScript()
    {
        yield return new WaitForSeconds(10f);
            for (int i = 0; i < GameController.allTables.Count; i++)
            {
            if (GameController.allTables[i].GetComponent<TableActiveControl>().customer==null && GameController.storeOpen)
            {
                if (Random.Range(0, 101) < 110)
                {
                    Instantiate(customerList[Random.Range(0, customerList.Count)], customerSpawnPoint.transform.position, new Quaternion(0, 0, 0, 0)).GetComponent<CustomerToTable>().tablePos = GameController.allTables[i].transform;
                }
                break;
            }
            }
        StartCoroutine(CustomerSpawnScript());
    }
}
