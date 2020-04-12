using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu(fileName ="Item", menuName ="Create/Item", order = 0)]
[System.Serializable]
public class ItemData : ScriptableObject
{
    public string itemName;
    public int itemID;
    public int amount;
    public Sprite itemImg;

    public bool collectable;
    public bool consumable;

}
