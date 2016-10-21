using UnityEngine;
using System.Collections;

public class TileController : MonoBehaviour
{
    public bool isGreen;
    public bool isRed;

    public Material greenMat;
    public Material redMat;

    private Renderer tileRend;

    void Awake()
    {
        tileRend = GetComponent<MeshRenderer>();
    }

    void OnMouseDown()
    {
        if (gameObject.tag == "T_Green")
        {
            tileRend.material = redMat;
        }

        if (gameObject.tag == "T_Red")
        {
            tileRend.material = greenMat;
        }
    }
}
/*
 *         if (isGreen == true && gameObject.tag == "T_Green")
        {
            tileRend.material = redMat;
            isGreen = false;
        }

        if (isRed == true && gameObject.tag == "T_Red")
        {
            tileRend.material = greenMat;
            isRed = false;
        }


        if (isGreen == false && gameObject.tag == "T_Green")
        {
            tileRend.material = greenMat;
            isGreen = true;
        }

        if (isRed == false && gameObject.tag == "T_Red")
        {
            tileRend.material = redMat;
            isRed = true;
        }
 */
