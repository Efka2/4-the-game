using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    private bool isHighlighted = false;
    public CharacterController c;
    private Color matColor;

    void OnMouseEnter()
    {
        Renderer render = GetComponent<Renderer>();
        matColor = render.material.color;
        render.material.color = Color.red;
        isHighlighted = true;

    }



    void OnMouseExit()
    {
        Renderer render = GetComponent<Renderer>();
        render.material.color = matColor;
        isHighlighted = false;

    }

    public void OnTriggerEnter(Collider other)
    {

        try
        {
            CharacterController cc = other.GetComponent<CharacterController>();
            cc.enabled = false;
            other.transform.position = new Vector3(other.transform.position.x + 30, other.transform.position.y, other.transform.position.z);
            cc.enabled = true;
            //inCollision = true;
        }
        catch (System.Exception)
        {
            //throw;
        }

    }
    public void OnTriggerExit()
    {

    }

    void Update()
    {

        if (Input.GetKeyDown("e") && isHighlighted == true)
        {
            Destroy(gameObject); //removes the mesh from the world if picked up
            OnTriggerEnter(c);
        }

    }
    // Start is called before the first frame update
    void Start()
    {

    }

}
