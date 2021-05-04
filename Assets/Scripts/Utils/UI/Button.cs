using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    [SerializeField] private VoidEvent Event;

    public void OnPressButton()
    {
        Debug.Log("pressing button");
        Event.Raise();
    }
}
