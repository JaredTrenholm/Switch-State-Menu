using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public static GameManager gameManager;
    public UIManager uiManager;
    public State state;
    private State previousState;
    private float timeScale;
    [Range(1, 10)] [SerializeField] private float defaultTimeScale;
    public enum State
    {
        MainMenu,
        Pause,
        Options,
        Credits,
        Gameplay,
        Win,
        Lose
    }
    private void Start()
    {
        if(gameManager != null && gameManager != this)
        {
            Destroy(this.gameObject);
        } else
        {
            gameManager = this;
            DontDestroyOnLoad(this.gameObject);
            SetTimeScaleToDefault();
        }
    }
    private void Update()
    {
        HandleState();
    }
    private void HandleState()
    {
        switch (state)
        {
            case State.MainMenu:
                ResumeTime();
                SetUI();
                break;
            case State.Pause:
                PauseTime();
                SetUI();
                break;
            case State.Options:
                ResumeTime();
                SetUI();
                break;
            case State.Credits:
                ResumeTime();
                SetUI();
                break;
            case State.Gameplay:
                ResumeTime();
                SetUI();
                break;
            case State.Win:
                PauseTime();
                SetUI();
                break;
            case State.Lose:
                PauseTime();
                SetUI();
                break;
        }
    }
    public bool IsInGame()
    {
        return state == State.Gameplay;
    }
    private void SetTimeScaleToDefault()
    {
        timeScale = defaultTimeScale;
    }
    private void ResumeTime()
    {
        Time.timeScale = timeScale;
    }
    private void PauseTime()
    {
        Time.timeScale = 0;
    }
    private void SetUI()
    {
        uiManager.SetUI(state);
    }
    public void SetTimeScale(float value)
    {
        timeScale = value;
    }
    public void LoadGameplay()
    {
        if (IsInGame())
            return;
        state = State.Gameplay;
        LevelManager.levelManager.LoadGameplay();
    }
    public void LoadMenu()
    {
        state = State.MainMenu;
        LevelManager.levelManager.LoadMenu();
    }
    public void OpenPauseMenu()
    {
        previousState = state;
        state = State.Pause;
    }
    public void OpenOptionsMenu()
    {
        if (IsInGame())
            return;
        previousState = state;
        state = State.Options;
    }
    public void OpenCredits()
    {
        if (IsInGame())
            return;
        previousState = state;
        state = State.Credits;
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void CloseMenu()
    {
        if(previousState == state)
        {
            state = State.MainMenu;
        }
        state = previousState;
    }
    public void Win()
    {
        state = State.Win;
    }
    public void Lose()
    {
        state = State.Lose;
    }

}
