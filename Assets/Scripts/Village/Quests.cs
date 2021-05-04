using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quests : Building
{
    public override void OnClick()
    {
        OnClickMe.Raise();
    }
}
