using UnityEngine;

[CreateAssetMenu(fileName = "Entities", menuName = "ScriptableObjects/Entities", order = 1)]
public class EntityBaseSO : ScriptableObject
{
    public string entityName;

    public Sprite profileImage;

    [Header("Battle Stats")]

    [SerializeField] private int _health;
    [SerializeField] private int _attack;
    [SerializeField] private int _velocity;
    [SerializeField] private int _defense;
    [SerializeField] private int _dodge;

    [Header("General Stats")]
    [SerializeField] private int _lucky;

    public GameObject prefab;


    public int Health { get { return _health; } }
    public int Attack { get { return _attack; } }
    public int AttackSpeed { get { return _velocity; } }
    public int Defense { get { return _defense; } }
    public int Dodge { get { return _dodge; } }
    //general stats
    public int Lucky { get { return _lucky; } }

}