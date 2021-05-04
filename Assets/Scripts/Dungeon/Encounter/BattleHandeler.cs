using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BattleHandeler : MonoBehaviour
{
    [SerializeField] private BattleSO currentBattle;
    [SerializeField] private VoidEvent _onEntityTakeDamage;
    public void RandomDamage(Team team)
    {
        foreach (Entity entity in team._Team)
        {
            int rNGDamage = Random.Range(0, 10);
            entity.TakeDamage(rNGDamage);
            Debug.Log(entity.name + "RECEIVED " + rNGDamage + " DAMAGE");
        }

        _onEntityTakeDamage.Raise();
    }

    public void BattleCoroutineStarter()
    {
        StartCoroutine(BattleCoroutine());
    }

    public IEnumerator BattleCoroutine()
    {
        while (true)
        {
            if (currentBattle._team1 == null || currentBattle._team2 == null)
            {
                yield return null;
                continue;
            }
            RandomDamage(currentBattle._team1);
            RandomDamage(currentBattle._team2);

            yield return new WaitForSeconds(0.5f);

            if (CheckTeamDead())
            {

                break;
            }
        }

        yield return null;
    }

    public bool CheckTeamDead()
    {
        bool team1Dead = true;
        bool team2Dead = true;

        foreach (Entity entity in currentBattle._team1._Team) {
            if (entity.currentHealth > 0)
                team1Dead = false;
        }

        foreach (Entity entity in currentBattle._team2._Team)
        {
           if (entity.currentHealth > 0)
                team2Dead = false;
        }

        if(team2Dead || team1Dead)
            return true;
        return false;
    }

}
