using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerEntities : MonoBehaviour
{
    [SerializeField] private TeamSO _team;

    public Team team;


    void Start()
    {
        foreach(EntityBaseSO e in _team.Team)
        {
            team.InstantiateNewEntity(e);
    
        }
    }


}
