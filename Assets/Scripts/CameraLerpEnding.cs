using UnityEngine;
using System.Collections;

public class CameraLerpEnding : MonoBehaviour
{
    public float camLerpSpeed;
    public float dirYLerp;

    public void lerpCam()
    {
        transform.position = Vector3.Lerp(transform.position, new Vector3(0, dirYLerp, 0), camLerpSpeed);
    }
}
