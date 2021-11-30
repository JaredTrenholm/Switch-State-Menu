using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public Canvas mainMenuCanvas;
    public Canvas pauseCanvas;
    public Canvas optionsCanvas;
    public Canvas creditsCanvas;
    public Canvas gameplayCanvas;
    public Canvas winCanvas;
    public Canvas loseCanvas;
    public Slider slider;
    public void SetUI(GameManager.State state)
    {
        Canvas targetCanvas;
        if (state == GameManager.State.MainMenu) targetCanvas = mainMenuCanvas;
        else if (state == GameManager.State.Gameplay) targetCanvas = gameplayCanvas;
        else if (state == GameManager.State.Pause) targetCanvas = pauseCanvas;
        else if (state == GameManager.State.Options) targetCanvas = optionsCanvas;
        else if (state == GameManager.State.Credits) targetCanvas = creditsCanvas;
        else if (state == GameManager.State.Win) targetCanvas = winCanvas;
        else targetCanvas = loseCanvas;
        SwitchActiveCanvas(targetCanvas);
    }
    private void SwitchActiveCanvas(Canvas canvas)
    {
        DisableAllCanvases();
        canvas.enabled = true;
    }
    private void DisableAllCanvases()
    {
        mainMenuCanvas.enabled = false;
        pauseCanvas.enabled = false;
        optionsCanvas.enabled = false;
        creditsCanvas.enabled = false;
        gameplayCanvas.enabled = false;
        winCanvas.enabled = false;
        loseCanvas.enabled = false;
    }

    public void LoadGameplay()
    {
        GameManager.gameManager.LoadGameplay();
    }
    public void LoadMenu()
    {
        GameManager.gameManager.LoadMenu();
    }
    public void OpenPauseMenu()
    {
        GameManager.gameManager.OpenPauseMenu();
    }
    public void OpenOptionsMenu()
    {
        GameManager.gameManager.OpenOptionsMenu();
    }
    public void OpenCredits()
    {
        GameManager.gameManager.OpenCredits();
    }
    public void CloseMenu()
    {
        GameManager.gameManager.CloseMenu();
    }
    public void Quit()
    {
        GameManager.gameManager.Quit();
    }
    public void SetTimeScale()
    {
        GameManager.gameManager.SetTimeScale(slider.value);
    }
}
