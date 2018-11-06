using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : SingletonBase<GameManager>
{
    public bool IsPlaying { get; set; }

    public float ingameTimeScale = 1.0f;
}
