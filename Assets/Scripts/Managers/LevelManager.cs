using UnityEngine;
using UnityEngine.SceneManagement;
using System.Collections;

public class LevelManager : MonoBehaviour
{
    SoundManager soundManager;
    TileManager tileManager;

    void Awake()
    {
        tileManager = GameObject.FindGameObjectWithTag("T_TileManager").GetComponent<TileManager>();
    }

    void Update()
    {
        WinCondition();
    }

    public void ReloadLevel ()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex); //Loads the current scene again
    }

    public void WinCondition()
    {
        if (tileManager.winConditionMet == true)
        {
            SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
            print("On to the next Level!");
        }
    }
}
