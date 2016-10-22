using UnityEngine;
using System.Collections;

public class SoundManager : MonoBehaviour
{
    public AudioSource soundDing;
    public AudioSource bgm;

    public void PlayDing()
    {
        soundDing.Play();
    }
}
