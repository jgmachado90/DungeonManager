using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootHandeler : MonoBehaviour
{
    [SerializeField] private InventorySO _lootableItems;
    [SerializeField] private InventorySO _playerInventory;
    public void RandomLoot()
    {
        foreach(InventorySlot item in _lootableItems.container)
        {
            _playerInventory.AddItem(item.item, item.amount);
        }  
    }
}
