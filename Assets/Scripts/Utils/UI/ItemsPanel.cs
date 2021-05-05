using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ItemsPanel : MonoBehaviour
{
    [SerializeField] private InventorySO currentLoot;
    [SerializeField] private GameObject itemStatsUIPrefab;

    public void ShowEntitiesOnPanel()
    {
        foreach (InventorySlot slot in currentLoot.container)
        {
            GameObject itemStatsGameObject = Instantiate(itemStatsUIPrefab, transform);

            ItemStatsUI itemStats = itemStatsGameObject.GetComponent<ItemStatsUI>();
            itemStats.MyItem = slot;

        }
    }
}
