using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entity : MonoBehaviour
{
    public EntityBaseSO baseEntity;

    public string entityName;
    public Sprite profileImage;

    bool alive;

    public int health;
    public int attack;
    public int attackSpeed;
    public int defense;
    public int dodge;

    public int currentHealth;

    public int level;

    public int expNextLevel;

    private void Start()
    {
        entityName = baseEntity.name;
        profileImage = baseEntity.profileImage;
        health = baseEntity.Health;
        attack = baseEntity.Attack;
        attackSpeed = baseEntity.AttackSpeed;
        dodge = baseEntity.Dodge;
        defense = baseEntity.Defense;
        currentHealth = health;
        alive = true;
    }

    public void TakeDamage(int damage)
    {
        currentHealth -= damage;
        if(currentHealth <= 0)
        {
            currentHealth = 0;
            alive = false;
        }
    }

}
