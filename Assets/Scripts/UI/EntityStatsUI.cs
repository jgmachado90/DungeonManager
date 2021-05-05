using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EntityStatsUI : MonoBehaviour
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
            UpdateEntityStats();
        }
    }

    public Text nameText;
    public Text healthText;
    public Text AttackText;
    public Text SpeedText;
    public Text DefenseText;
    public Text DodgeText;

    public Image image;

    public void UpdateEntityStats()
    {
        if(_myEntity != null)
        {
            if(nameText != null)
                nameText.text = MyEntity.entityName;
            if (AttackText != null)
                AttackText.text = MyEntity.attack.ToString();
            if (DefenseText != null)
                DefenseText.text = MyEntity.defense.ToString();
            if (SpeedText != null)
                SpeedText.text = MyEntity.attackSpeed.ToString();
            if (DodgeText != null)
                DodgeText.text = MyEntity.dodge.ToString();
            if (image != null)
                image.sprite = MyEntity.profileImage;

        }
    }

}
