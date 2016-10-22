using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{
    TileManager tileManager;

    public AudioSource soundDing;
    public AudioSource bgm;

    void Awake()
    {
        tileManager = GameObject.FindGameObjectWithTag("T_TileManager").GetComponent<TileManager>();
    }

    public void PlayDing()
    {
        //soundDing.Play();
        print("Play a ding!");
    }
}
