using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "New Battle", menuName = "Encounter/Battle")]
public class BattleSO : ScriptableObject
{
    public Team _team1;
    public Team _team2;
}