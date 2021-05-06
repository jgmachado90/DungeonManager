using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EntitiesPanel : Panel
{
    public Team team;
    [SerializeField] private GameObject _entityStatsPrefab;

   

    public override void ShowEntitiesOnPanel()
    {
        if(_entitiesInPannel.Count > 0)
        {
            ClearEntitiesInPannel();
        }

        foreach (Entity entity in team._Team)
        {
            GameObject entityStatsGameObject = Instantiate(_entityStatsPrefab, transform);

            EntityStatsUI entityStats = entityStatsGameObject.GetComponent<EntityStatsUI>();
            entityStats.MyEntity = entity;

            _entitiesInPannel.Add(entityStatsGameObject);

            LifeBar lifeBar = entityStatsGameObject.GetComponentInChildren<LifeBar>();
            lifeBar.MyEntity = entity;
        }
    }

    
}
