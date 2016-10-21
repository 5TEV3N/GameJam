using UnityEngine;
using System.Collections;

public class UiManager : MonoBehaviour
{
    LevelManager levelManager;

    void Awake()
    {
        levelManager = GameObject.FindGameObjectWithTag("T_LevelManager").GetComponent<LevelManager>();
    }

    public void RestartGame()
    {
        levelManager.ReloadLevel();
    }
}
