using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LootHandeler : MonoBehaviour
{
    [SerializeField] private InventorySO _lootableItems;
    [SerializeField] private InventorySO _playerInventory;
    public InventorySO currentLoot;
    public VoidEvent OnLoot;
    public void GiveLoot()
    {
        foreach(InventorySlot item in _lootableItems.container)
        {
            currentLoot.AddItem(item.item, item.amount);
            _playerInventory.AddItem(item.item, item.amount);
        }
        OnLoot.Raise();
    }

    public void CurrentLootClear()
    {
        currentLoot.Clear();
    }
}
