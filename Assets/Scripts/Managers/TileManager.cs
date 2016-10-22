using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class TileManager : MonoBehaviour
{
    LevelManager levelManager;

    [Header ("Lists")]
    public List<GameObject> redTilesList = new List <GameObject>();
    public List<GameObject> greenTilesList = new List <GameObject>();

    [Header("")]
    public int countRedTilesLength;
    public int countGreenTilesLength;

    public bool redGoal;
    public bool greenGoal;

    void Awake()
    {
        levelManager = GameObject.FindGameObjectWithTag("T_LevelManager").GetComponent<LevelManager>();
    }

    void Update()
    {
        countRedTilesLength = redTilesList.Count;
        countGreenTilesLength = greenTilesList.Count;

        CorrecTileContainer();
    }

    public void CorrecTileContainer()
    {
        if (greenGoal == true)
        {
            if (countRedTilesLength == 0)
            {
                levelManager.WinCondition();
            }
        }

        if (redGoal == true)
        {
            if (countGreenTilesLength == 0)
            {
                levelManager.WinCondition();
            }
        }
    }
}
