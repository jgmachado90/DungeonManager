using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsPanel : Panel
{
    [SerializeField] private InventorySO currentLoot;
    [SerializeField] private GameObject itemStatsUIPrefab;


    public override void ShowEntitiesOnPanel()
    {
        if (_entitiesInPannel.Count > 0)
        {
            ClearEntitiesInPannel();
        }

        foreach (InventorySlot slot in currentLoot.container)
        {
            GameObject itemStatsGameObject = Instantiate(itemStatsUIPrefab, transform);

            ItemStatsUI itemStats = itemStatsGameObject.GetComponent<ItemStatsUI>();
            itemStats.MyItem = slot;

            _entitiesInPannel.Add(itemStatsGameObject);
        }
    }
}
