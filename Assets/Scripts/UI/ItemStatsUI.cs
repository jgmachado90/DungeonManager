using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ItemStatsUI : MonoBehaviour
{
    private InventorySlot _myItem;
    public InventorySlot MyItem
    {
        get
        {
            return _myItem;
        }
        set
        {
            _myItem = value;
            UpdateItemStats();
        }
    }

    public Text nameText;
    public Text itemInfoText;

    public void UpdateItemStats()
    {
        if (_myItem != null)
        {
            if (nameText != null)
                nameText.text = MyItem.item.name;
            if (itemInfoText != null)
                itemInfoText.text = MyItem.item.description;
        }
    }
}
