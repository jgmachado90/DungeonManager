using UnityEngine;

[CreateAssetMenu(fileName = "Entities", menuName = "ScriptableObjects/Entities", order = 1)]
public class EntityBaseSO : ScriptableObject
{
    public string entityName;

    public Sprite profileImage;

    public int health;
    public int attack;
    public int attackSpeed;
    public int speed;
   
}