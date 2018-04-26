using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;

public class CustomTips : VRTK_ControllerTooltips
{
    private bool TipsEnabled = true;

    private void Awake()
    {
        Invoke("DisableTips", 8f);
    }

    private void Update()
    {
        if (TipsEnabled)
        {
            ToggleTips(true);
        } else
        {
            ToggleTips(false);
        }
    }

    public override void ToggleTips(bool state, TooltipButtons element = TooltipButtons.None)
    {
        base.ToggleTips(state, element);
    }

    void DisableTips()
    {
        TipsEnabled = false;
    }
}
