using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InventoryScript : MonoBehaviour
{
    public Image itemPrefab; // Reference to the item image prefab
    public Color[] itemColors; // Array of colors for the items

    private RectTransform contentRect; // Reference to the Scroll Rect's content area

    void Start()
    {
        if (itemPrefab == null || itemColors.Length == 0)
        {
            Debug.LogError("Please assign item prefab and color array!");
            return;
        }

        contentRect = GetComponentInChildren<ScrollRect>().content; // Get the Scroll Rect's content

        // Loop through colors and instantiate items
        for (int i = 0; i < itemColors.Length; i++)
        {
            Image newItem = Instantiate(itemPrefab, contentRect); // Instantiate inside Scroll Rect's content
            newItem.color = itemColors[i]; // Set the color of the new item
        }
    }
}