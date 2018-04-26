using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class LeverScript : VRTK_Lever
{
    private void Update()
    {
        Debug.Log(value);
    }

    public void ShowValue()
    {
        Debug.Log(value);
    }
}
