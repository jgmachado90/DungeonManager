using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Equipment Object", menuName = "InventorySystem/Items/Equipment")]
public class EquipmentObject : ItemSO
{
    public int atackBonus;
    public int defenseBonus;

    public void Awake()
    {
        type = ItemType.Food;
    }
}
