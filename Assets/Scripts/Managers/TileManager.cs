using UnityEngine;
using System.Collections;
using System.Collections.Generic;


public class TileManager : MonoBehaviour
{
    SoundManager soundManager;

    [Header ("Lists")]
    public List<GameObject> redTilesList = new List <GameObject>();
    public List<GameObject> greenTilesList = new List <GameObject>();

    [Header("")]
    public int countRedTilesLength;
    public int countGreenTilesLength;

    public bool redGoal;
    public bool greenGoal;
    public bool winConditionMet;
    public bool winConditionMetSound;

    void Awake()
    {
        soundManager = GameObject.FindGameObjectWithTag("T_SoundManager").GetComponent<SoundManager>();
    }

    void Update()
    {
        countRedTilesLength = redTilesList.Count;
        countGreenTilesLength = greenTilesList.Count;

        CorrectTileContainer();

        if (winConditionMetSound == true)
        {
            soundManager.PlayDing();
            winConditionMetSound = false;
        }

    }

    public void CorrectTileContainer()
    {
        if (greenGoal == true)
        {
            if (countRedTilesLength == 0)
            {
                winConditionMet = true;
                winConditionMetSound = true;
            }
        }

        if (redGoal == true)
        {
            if (countGreenTilesLength == 0)
            {
                winConditionMet = true;
            }
        }
    }
}
