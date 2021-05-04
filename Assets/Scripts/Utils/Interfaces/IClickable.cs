using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface IClickable 
{
    VoidEvent OnClickMe { get; }
    public void OnClick();
}
