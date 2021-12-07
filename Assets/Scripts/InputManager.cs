using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour
{
    private void Update()
    {
        if (GameManager.gameManager.IsInGame())
        {
            HandleInput();
        }
    }
    private void HandleInput()
    {
        if (Input.GetKey(KeyCode.W))
        {
            GameManager.gameManager.Win();
        } else if (Input.GetKey(KeyCode.L))
        {
            GameManager.gameManager.Lose();
        }
        else if (Input.GetKey(KeyCode.Escape))
        {
            GameManager.gameManager.OpenPauseMenu();
        }
    }
}
