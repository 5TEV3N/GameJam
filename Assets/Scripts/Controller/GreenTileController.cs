﻿using UnityEngine;
using System.Collections;

public class GreenTileController : MonoBehaviour
{
    TileManager tileManager;
    SoundManager soundManager;

    public float xPos;
    public float zPos;

    public Material greenMat;
    public Material redMat;

    public bool lerpStart = false;

    private Renderer tileRend;

    void Awake()
    {
        tileRend = GetComponent<MeshRenderer>();
        tileManager = GameObject.FindGameObjectWithTag("T_TileManager").GetComponent<TileManager>();
        soundManager = GameObject.FindGameObjectWithTag("T_SoundManager").GetComponent<SoundManager>();

        xPos = gameObject.transform.position.x;
        zPos = gameObject.transform.position.z;
    }

    void Update()
    {
        if (lerpStart == true)
        {
            transform.position = Vector3.Lerp(gameObject.transform.position, new Vector3(xPos, 0, zPos), 0.1f);
        }
    }

    void OnMouseDown()
    {
        if (gameObject.tag == "T_Green")
        {
            tileRend.material = redMat;
            gameObject.tag = "T_Red";
            tileManager.redTilesList.Add(gameObject);
            tileManager.greenTilesList.Remove(gameObject);

            soundManager.PlayDing();

            lerpStart = true;
        }
    }
}
