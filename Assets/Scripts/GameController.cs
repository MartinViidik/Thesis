using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using VRTK;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour {

    [Header("Amount of time")]
    [SerializeField] public float _timer;

    private float timer;
    private bool faded;

    public static GameController instance;
    public bool timerStarted = false;

    void Awake()
    {
        timer = _timer;
        faded = true;
        instance = this;
    }

    private void Start()
    {
        GetComponent<VRTK_HeadsetFade>().Fade(Color.black, 0.25f);
    }

    void Update()
    {
        if (timerStarted)
        {
            ReduceTime();
            Debug.Log(timer);
        }
        if (faded)
        {
            fadeScreen();
        } else {
            FadeOut();
        }
        if(timer <= 0)
        {
            GameOver(0.25f);
        }
    }

    void ReduceTime()
    {
        timer -= Time.deltaTime;
    }

    public void GameOver(float speed)
    {
        GetComponent<VRTK_HeadsetFade>().Fade(Color.black, speed);
        Invoke("ReloadGame", 2.0f);
    }

    void ReloadGame()
    {
        Scene scene = SceneManager.GetActiveScene();
        SceneManager.LoadScene(scene.name);
    }

    void FadeOut()
    {
        GetComponent<VRTK_HeadsetFade>().Fade(Color.clear, 2.5f);
    }

    public void fadeScreen()
    {
        GetComponent<VRTK_HeadsetFade>().Fade(Color.black, 0.0f);
        Invoke("SetFaded", 0.1f);
    }

    void SetFaded()
    {
        faded = false;
    }

    


}
