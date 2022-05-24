using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Looking : MonoBehaviour
{
    private bool isLooking;
    private Color color;
    private void Update()
    {
        if (!GameController.onLoad)
        {
            var ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;
            isLooking = Physics.Raycast(ray, out hit, 5);

            if (GameController.activeLookingObject != null && GameController.activeLookingObject.tag != "Customer")
            {
                var selectionRenderer = GameController.activeLookingObject.GetComponent<Renderer>();
                selectionRenderer.material.color = Color.white;
                GameController.activeLookingObject = null;
            }
            if (isLooking)
            {
                GameController.activeLookingPlace = hit.point;
                var selection = hit.transform;
                if (selection.GetComponent<GetInterractable>() != null)
                {
                    var selectionRenderer = selection.GetComponent<Renderer>();
                    if (selectionRenderer != null)
                    {
                        selectionRenderer.material.color = Color.yellow;
                    }
                    GameController.activeLookingObject = selection;
                }
            }
        }
        
    }
}
