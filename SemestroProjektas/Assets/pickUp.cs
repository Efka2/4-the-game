using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class pickUp : MonoBehaviour
{
    private bool isHighlighted = false;
    public CharacterController c;


    void OnMouseEnter()
    {
        
        isHighlighted = true;

    }



    void OnMouseExit()
    {
        

        isHighlighted = false;

    }

    public void OnTriggerEnter(Collider other)
    {
        //speed = speed * -1;
        //colorPicker = Random.Range(0, 10);
        try
        {
            CharacterController cc = other.GetComponent<CharacterController>();

            cc.enabled = false;
            other.transform.position = new Vector3(other.transform.position.x + 10, other.transform.position.y, other.transform.position.z);
            cc.enabled = true;
        }
        catch (System.Exception)
        {

            //throw;
        }

        //other.transform.rotation = new Quaternion(0, 10, 0, 0);
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
