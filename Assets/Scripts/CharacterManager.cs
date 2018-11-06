using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterManager : MonoBehaviour
{
    Rigidbody2D rb2d;
    float maxVelocity = 7.0f;
    Vector2 originalVelocity;

    private void Start()
    {
        InputManager.Instance.OnMouseButtonDown += HandleMouseButtonDown;
        InputManager.Instance.OnMouseButtonUp += HandleMouseButtonUp;
        rb2d = GetComponent<Rigidbody2D>();
    }

    private void OnDestroy()
    {
        InputManager.Instance.OnMouseButtonDown -= HandleMouseButtonDown;
        InputManager.Instance.OnMouseButtonUp -= HandleMouseButtonUp;
    }

    private void FixedUpdate()
    {
        rb2d.velocity = Vector2.ClampMagnitude(rb2d.velocity, maxVelocity);
        GetComponent<Rigidbody2D>().velocity *= GameManager.Instance.ingameTimeScale;
        if (transform.position.y < -5.5f)
        {
            transform.position = new Vector2(0.0f, 10.0f);
        }
    }
    
    private void HandleMouseButtonDown()
    {
        originalVelocity = rb2d.velocity;
        GameManager.Instance.ingameTimeScale = 0.1f;
    }

    private void HandleMouseButtonUp()
    {
        rb2d.velocity = originalVelocity;
        GameManager.Instance.ingameTimeScale = 1.0f;
    }
}
