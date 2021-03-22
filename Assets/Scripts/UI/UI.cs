using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class UI : MonoBehaviour
{
    public bool active;

    public virtual void GetUIInfo()
    {

    }
    public virtual void SetActiveUI(bool willActivate)
    {
        if (willActivate)
            SceneManager.instance.currentScene = SceneManager.CurrentScene.UI;
        else
            SceneManager.instance.currentScene = SceneManager.CurrentScene.Town;

        GetUIInfo();
        transform.gameObject.SetActive(willActivate);
        active = willActivate;
    }
}
