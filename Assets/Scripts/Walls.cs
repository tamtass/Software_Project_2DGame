using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Walls : MonoBehaviour
{
    private Camera mainCam;

    private void Awake()
    {
        mainCam = Camera.main;
    }

    void Start ()
    {
        float wallBoundX = mainCam.orthographicSize * Screen.width / Screen.height;
        transform.position = transform.position.x < 0 ? new Vector2(-wallBoundX, 0.0f) : new Vector2(wallBoundX, 0.0f);
	}
}
