using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class CraftSystem : MonoBehaviour
{
    [SerializeField] private ItemData[] itemdatas;
    [SerializeField] private Items items;
    [SerializeField] private TMP_Text dontHaveEnoughText;
    [SerializeField] private GameObject dontHaveEnoughObj;


    public void CraftItem()
    {
        Debug.Log("Do i work ");
        if (itemdatas[0].amount >= 2 && itemdatas[1].amount >= 2)
        {
            itemdatas[2].amount += 1;
            Debug.Log("You crafted " + itemdatas[2]);

            itemdatas[0].amount -= 2;
            itemdatas[1].amount -= 2;

        }

        else if (itemdatas[0].amount <= 2 && itemdatas[1].amount <= 2)
        {
            Debug.Log("You do not have enough materials");
            dontHaveEnoughObj.SetActive(true);
            dontHaveEnoughText.text = "You do not have enough material";
            Invoke("NotEnough", 2f);
        }


    }


    public void NotEnough()
    {
        dontHaveEnoughObj.SetActive(false);
    }
}
