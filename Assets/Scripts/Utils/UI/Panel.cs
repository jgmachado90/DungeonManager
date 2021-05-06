using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Panel : MonoBehaviour
{

    public List<GameObject> _entitiesInPannel = new List<GameObject>();

    public virtual void ShowEntitiesOnPanel()
    {

    }

    protected void ClearEntitiesInPannel()
    {
        foreach (GameObject gO in _entitiesInPannel)
        {
            Destroy(gO);
        }
        _entitiesInPannel.Clear();
    }
}
