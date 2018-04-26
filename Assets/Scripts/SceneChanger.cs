using UnityEngine;
using VRTK;

public class SceneChanger : VRTK_HeadsetFade
{
    public static SceneChanger instance;

    public void Awake()
    {
        instance = this;
    }

    public void FadeScreen()
    {
        Fade(Color.black, 1.5f);
    }

    public void ClearScreen()
    {
        Unfade(1.5f);
    }

}