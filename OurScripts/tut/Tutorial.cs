﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Tutorial : MonoBehaviour
{
    public int Order;

    public string Explanation;

    // Update is called once per frame
    void Awake()
    {
        TutorialManager.Instace.Tutorials.Add(this);
    }

    public virtual void ChechIfHappening()
    {


    }
}
