﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickUp2 : MonoBehaviour
{
    public bool isHighlighted = false;
    public CharacterController character;
    private Color matColor;
    public float pickUpDistance = 3;
    //public bool inRange = false;
    //darbas su display'u lapeliu teksto
    //public Text myText;
    //public float fadeTime;
    //public string myString;

    void OnMouseEnter()
    {

        Renderer render = GetComponent<Renderer>();
        matColor = render.material.color;

        if (InRange())
        {
            isHighlighted = true;
            render.material.color = Color.gray;
        }
    }

    void OnMouseExit()
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = matColor;
        isHighlighted = false;
    }

    bool InRange()
    {
        Transform other = GameObject.Find("Player").GetComponent<Transform>();
        float dist = Vector3.Distance(other.position, transform.position);
        if (dist < pickUpDistance)
        {
            return true;
        }
        else
            return false;
        
    }

    void Update()
    {
        //FadeText();

        if (Input.GetKeyDown("e") && isHighlighted && InRange())
        {
            Destroy(gameObject);
            Teleportation(character);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        //myText = GameObject.Find("Text").GetComponent<Text>();
        //myText.color = Color.clear;
    }

    void Teleportation(Collider other)
    {
        try
        {
            CharacterController cc = other.GetComponent<CharacterController>();
            cc.enabled = false;
            other.transform.position = new Vector3(other.transform.position.x + 30, other.transform.position.y, other.transform.position.z);
            cc.enabled = true;
        }
        catch (System.Exception)
        {

        }
    }

    //void FadeText()
    //{
    //    if (isHighlighted)
    //    {
    //        myText.text = myString;
    //        myText.color = Color.Lerp(myText.color, Color.white, fadeTime * Time.deltaTime);
    //    }
    //    else
    //    {
    //        myText.color = Color.Lerp(myText.color, Color.clear, fadeTime * Time.deltaTime);
    //    }
    //}
}
