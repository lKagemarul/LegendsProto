﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ScoreManager : MonoBehaviour
{
    public static int score;
    public static int health;

    void Start()
    {
        // resets the score to 0 at the start of the game
        score = 0;
        health = 100;
    }
}