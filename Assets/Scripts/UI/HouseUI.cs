using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HouseUI : UI
{
    public Text TitleText;

    public Text entityNameText1;
    public Text entityNameText2;
    public Text entityNameText3;
    public Text entityNameText4;

    public Image entityProfileImage;
    public Image entityProfileImage2;
    public Image entityProfileImage3;
    public Image entityProfileImage4;

    public Text health;
    public Text attack;
    public Text attackSpeed;
    public Text speed;


    private void Start()
    {

    }

    public override void GetUIInfo()
    {
        entityNameText1.text = TeamManager.instance.currentTeam[0].entityName;
        entityNameText2.text = TeamManager.instance.currentTeam[1].entityName;
        entityNameText3.text = TeamManager.instance.currentTeam[2].entityName;
        entityNameText4.text = TeamManager.instance.currentTeam[3].entityName;

        entityProfileImage.sprite = TeamManager.instance.currentTeam[0].profileImage;
        entityProfileImage2.sprite = TeamManager.instance.currentTeam[1].profileImage;
        entityProfileImage3.sprite = TeamManager.instance.currentTeam[2].profileImage;
        entityProfileImage4.sprite = TeamManager.instance.currentTeam[3].profileImage;

    }

    public void OnClickInEntity(int entityIndex)
    {
        Debug.Log("OnClickEntity");
        health.text = TeamManager.instance.currentTeam[entityIndex].health.ToString();
        attack.text = TeamManager.instance.currentTeam[entityIndex].attack.ToString(); 
        attackSpeed.text = TeamManager.instance.currentTeam[entityIndex].attackSpeed.ToString();
        speed.text = TeamManager.instance.currentTeam[entityIndex].speed.ToString();
    }


}
