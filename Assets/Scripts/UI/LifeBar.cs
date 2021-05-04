using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class LifeBar : MonoBehaviour
{
    private Entity _myEntity;
    public Entity MyEntity
    {
        get
        {
            return _myEntity;
        }
        set
        {
            _myEntity = value;
            UpdateLifeBar();
        }
    }
    public Image lifeBar; 
    public void UpdateLifeBar()
    {
        float amount = (float)MyEntity.currentHealth / (float)MyEntity.health;
        lifeBar.fillAmount = amount;
    }
}
