using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Team : MonoBehaviour
{
    [SerializeField] private List<Entity> _team;

    public List<Entity> _Team { get { return _team; } }

    public void InstantiateNewEntity(EntityBaseSO e)
    {
        GameObject gO = Instantiate(e.prefab, transform);
        Entity entity = gO.GetComponent<Entity>();
        _Team.Add(entity);
    }

    public void ClearTeam()
    {
        foreach (Entity entity in _Team)
        {
            Destroy(entity.gameObject);
        }
        _team.Clear();
    }
}
