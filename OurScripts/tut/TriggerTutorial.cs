﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerTutorial : Tutorial
{

    private bool isCurrentTutorial = false;

    public Transform HitTransform;

    public override void ChechIfHappening()
    {
        isCurrentTutorial = true;
    }

    public void OnTriggerEnter(Collider other)
    {
        if(!isCurrentTutorial)
        {
            return;
        }


        if(other.transform == HitTransform)
        {
            TutorialManager.Instace.CompletedTutorial();
            isCurrentTutorial = false;
        }
    }

}
