using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameManager : MonoBehaviour
{
    public static GameManager I;

    public int Score = 0;
    public Text comboText;

    private void Awake()
    {
        I = this;
    }

    public void AddScore(int score)
    {
        Score = Score + score;
    }
}