using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(fileName = "Teams", menuName = "ScriptableObjects/Team", order = 1)]
public class TeamSO : ScriptableObject
{
    [SerializeField] private List<EntityBaseSO> _team;
  
    public List<EntityBaseSO> Team { get { return _team; } }

}