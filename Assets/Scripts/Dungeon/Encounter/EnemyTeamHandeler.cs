using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTeamHandeler : MonoBehaviour
{
    public List<TeamSO> possibleEnemyTeams;

    public Team currentEnemyTeam;

    public void GenerateEnemyTeam()
    {
        int rng = Random.Range(0, possibleEnemyTeams.Count);

        TeamSO newTeam = possibleEnemyTeams[rng];

        foreach (EntityBaseSO e in newTeam.Team)
        {
            currentEnemyTeam.InstantiateNewEntity(e);
        }
    }
}
