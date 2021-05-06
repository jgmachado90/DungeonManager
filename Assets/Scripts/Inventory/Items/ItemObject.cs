using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public enum ItemType
{
    Food,
    Equipment,
    Default
}
public abstract class ItemSO : ScriptableObject
{
    public GameObject prefab;
    public ItemType type;

    public Sprite profileImage;

    [TextArea(15, 20)]
    public string description;
}
