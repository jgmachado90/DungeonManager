using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
public class EntitiesPanel : MonoBehaviour
{
    public Team team;
    [SerializeField] private GameObject _entityStatsPrefab;

    public void ShowEntitiesOnPanel()
    {

        foreach(Entity entity in team._Team)
        {
            GameObject entityStatsGameObject = Instantiate(_entityStatsPrefab, transform);

            EntityStatsUI entityStats = entityStatsGameObject.GetComponent<EntityStatsUI>();
            entityStats.MyEntity = entity;

            LifeBar lifeBar = entityStatsGameObject.GetComponentInChildren<LifeBar>();
            lifeBar.MyEntity = entity;
        }
    }
}
