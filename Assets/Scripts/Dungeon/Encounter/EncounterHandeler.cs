using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EncounterHandeler : MonoBehaviour
{
    [SerializeField] private TeamSO _team;
    [SerializeField] private VoidEvent _onStartBatlle;
    [SerializeField] private VoidEvent _onGiveLoot;

    public void StartEncounter()
    {
        float rNG = Random.Range(0f, 1f);

        if (rNG <= 0.5)
            BattleEvent();
        else
            TreasureEvent();
    }

    private void TreasureEvent()
    {
        _onGiveLoot.Raise();
    }

    private void BattleEvent()
    {
        _onStartBatlle.Raise();
    }


   
}
