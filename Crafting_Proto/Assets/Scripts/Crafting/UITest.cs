using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class UITest : MonoBehaviour
{
    [SerializeField] private ItemData[] itemDatas;
    [SerializeField] private TMP_Text[] amoutOfText;



    private void Update()
    {
        for (int i = 0; i < amoutOfText.Length; i++)
        {
            amoutOfText[i].text = itemDatas[i].itemName + " : " + itemDatas[i].amount;
        }
    }



}
