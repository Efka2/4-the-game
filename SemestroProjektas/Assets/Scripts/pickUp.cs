using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class pickUp : MonoBehaviour
{
    public bool isHighlighted = false;
    public CharacterController c;
    private Color matColor;
    bool playerIsClose = false;
    //darbas su display'u lapeliu teksto
    //public Text myText;
    //public float fadeTime;
    //public string myString;

    void OnMouseEnter()
    {
        if (playerIsClose)
        {
            Renderer render = GetComponent<Renderer>();
            matColor = render.material.color;
            render.material.color = Color.red;
            isHighlighted = true;
        }

    
    }
    
    void OnMouseExit()
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = matColor;
        isHighlighted = false;

    }

    public void OnTriggerEnter(Collider other)
    {
        //try
        //{
        //    CharacterController cc = other.GetComponent<CharacterController>();
        //    cc.enabled = false;
        //    other.transform.position = new Vector3(other.transform.position.x + 30, other.transform.position.y, other.transform.position.z);
        //    cc.enabled = true;
        //}
        //catch (System.Exception)
        //{

        //}
        if (other.gameObject.tag == "Player")
        {
            playerIsClose = true;
        }

    }
    public void OnTriggerExit()
    {
        //if (other.GameObject.tag == "Player")
        //{
            playerIsClose = false;
        //}
    }

    void Update()
    {
        //FadeText();

        if (Input.GetKeyDown("e") && isHighlighted == true)
        {
            Destroy(gameObject); 
            OnTriggerEnter(c);
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        //myText = GameObject.Find("Text").GetComponent<Text>();
        //myText.color = Color.clear;
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
