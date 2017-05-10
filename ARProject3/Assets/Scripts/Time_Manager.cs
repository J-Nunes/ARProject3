﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Time_Manager : MonoBehaviour {

    public float slowdownFactor = 0.05f;
    public float slowdownLength = 2f;

    void Update()
    {
        Time.timeScale += (1f / slowdownLength) * Time.unscaledDeltaTime;
        Time.timeScale = Mathf.Clamp(Time.timeScale, 0f, 1f);
    }

	public void SlowMotion()
    {
        Time.timeScale = slowdownFactor;
        Time.fixedDeltaTime = Time.timeScale * .02f;
    }
}


