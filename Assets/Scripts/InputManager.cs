using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System;

public class InputManager : SingletonBase<InputManager>
{
    public Action OnMouseButtonDown;
    public Action OnMouseButtonUp;

    public void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (OnMouseButtonDown != null)
            {
                OnMouseButtonDown();
            }
        }

        if (Input.GetMouseButtonUp(0))
        {
            if (OnMouseButtonUp != null)
            {
                OnMouseButtonUp();
            }
        }
    }

}
