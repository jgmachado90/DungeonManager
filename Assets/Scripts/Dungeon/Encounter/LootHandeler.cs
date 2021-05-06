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
        for(int i = 0; i < 3; i++)
        {
            int rng = Random.Range(0, _lootableItems.container.Count);
            InventorySlot item = _lootableItems.container[rng];

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
