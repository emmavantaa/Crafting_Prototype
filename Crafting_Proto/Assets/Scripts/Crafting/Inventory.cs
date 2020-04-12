using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Inventory : MonoBehaviour
{
    [SerializeField] private ItemData[] inventory;
    [SerializeField] private Items items;

    private void Update()
    {
       if (Input.GetKeyDown(KeyCode.Space))
        {
            items.AddItem(0);
            items.AddItem(1);
        }
        if (Input.GetKeyDown(KeyCode.Backspace))
        {
            items.RemoveItem(0);
        }

        if (Input.GetKeyDown(KeyCode.Tab))
        {
            items.RestetItems();
        }
    }
}
