using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LevelManager : MonoBehaviour
{
    public static LevelManager levelManager;
    private void Start()
    {
        if (levelManager != null && levelManager != this)
        {
            Destroy(this.gameObject);
        }
        else
        {
            levelManager = this;
        }
    }
    public void LoadGameplay()
    {
        SceneManager.LoadScene(1);
    }
    public void LoadMenu()
    {
        SceneManager.LoadScene(0);
    }
}
