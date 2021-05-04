using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Healing Object", menuName = "InventorySystem/Items/Healing")]
public class HealingObject : ItemSO
{
    public int restoreHealthValue;
    public void Awake()
    {
        type = ItemType.Food;
    }
}
