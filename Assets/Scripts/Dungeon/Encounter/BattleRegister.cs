using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleRegister : MonoBehaviour
{
    public BattleSO _currentBattle;
    public bool team1;
   
    public void RegisterTeam()
    {
        Team team = GetComponent<EntitiesPanel>().team;

        if (team1)
        {
            _currentBattle._team1 = team;
        }
        else
        {
            _currentBattle._team2 = team;
            ResetTeamLife(team);
        }
    }

    private void ResetTeamLife(Team team)
    {
        foreach (Entity entity in team._Team)
        {
            entity.currentHealth = entity.baseEntity.Health;
        }
    }
}
