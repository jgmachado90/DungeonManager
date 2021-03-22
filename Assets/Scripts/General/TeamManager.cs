using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TeamManager : MonoBehaviour
{
    public static TeamManager instance;
    public List<EntityBaseSO> teamEntitiesBase;
    public List<Entity> currentTeam = new List<Entity>();
    public GameObject EntityPrefab;

    private void Awake()
    {
        instance = this;
    }
    private void Start()
    {
        GenerateFirstTeam();
    }

    private void GenerateFirstTeam()
    {
        foreach(EntityBaseSO entities in teamEntitiesBase)
        {
           GameObject newEntityGO = Instantiate(EntityPrefab, transform);
           Entity newEntity = newEntityGO.GetComponent<Entity>();
           newEntity.entityName = entities.entityName;
           newEntity.profileImage = entities.profileImage;
           newEntity.health = entities.health;
           newEntity.attack = entities.attack;
           newEntity.attackSpeed = entities.attackSpeed;
           newEntity.speed = entities.speed;
            currentTeam.Add(newEntity);
        }
    }
}
