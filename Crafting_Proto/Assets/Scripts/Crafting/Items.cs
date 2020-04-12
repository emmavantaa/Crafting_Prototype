using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Items : MonoBehaviour
{
   [SerializeField] private List<ItemData> itemDatas = new List<ItemData>();
   [SerializeField] private ItemData[] itemData;
  

    public void AddItem(int itemID)
    {
        itemData[0].amount += 1;
        Debug.Log("You added one" + itemData[0].itemName + " " + itemData[0].amount);

        itemData[1].amount += 1;
        Debug.Log("You added one" + itemData[1].itemName + " " + itemData[1].amount);
    }

    public void RemoveItem(int itemID)
    {
        itemData[0].amount -= 1;
    }


    public void RestetItems()
    {
        for (int i = 0; i < itemData.Length; i++)
        {
            itemData[i].amount = 0;
        }
    }

}
