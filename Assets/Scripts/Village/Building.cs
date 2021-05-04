using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Building : MonoBehaviour, IClickable
{
    [SerializeField] private VoidEvent _onClickMe;

    public VoidEvent OnClickMe { get { return _onClickMe; } }

    public virtual void OnClick(){}

}
