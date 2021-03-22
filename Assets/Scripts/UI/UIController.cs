using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UIController : MonoBehaviour
{
    public static UIController instance;

    public HouseUI houseUI;

    public UI currentActiveUI;

    private void Awake()
    {
        instance = this;
    }

    internal void EnableObjectUI(GameObject uiGameObject)
    {
        Building clickedbuilding = uiGameObject.GetComponent<Building>();
        if (clickedbuilding != null)
        {
            if (clickedbuilding.myUI != null)
            {
                clickedbuilding.myUI.SetActiveUI(true);
            }
        }
    }
}
