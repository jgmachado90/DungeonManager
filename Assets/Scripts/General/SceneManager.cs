using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SceneManager : MonoBehaviour
{
    public static SceneManager instance;

    public enum CurrentScene {Town, UI, Dungeon};
    public CurrentScene currentScene;

    private void Awake()
    {
        instance = this;
        currentScene = CurrentScene.Town;
    }

    internal void LoadQuestScene()
    {
        throw new NotImplementedException();
    }
}
