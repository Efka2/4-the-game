﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class renderDisabler : MonoBehaviour
{
    private MeshRenderer renderer;
    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<MeshRenderer>();
        renderer.enabled = false;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
