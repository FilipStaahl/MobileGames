using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

public class Item : MonoBehaviour, IBeginDragHandler, IDragHandler
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnBeginDrag(PointerEventData eventData)
    {
        Debug.Log("Start Drag");
        // We need to create a canvas
        // and put the item under that canvas
        // so it can be freely moved around
    }

    public void OnDrag(PointerEventData eventData)
    {
        Debug.Log("Drag.");
        // We need to assign the pointer position
        // to this item
    }
}
