using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityStandardAssets.Characters.FirstPerson;


public class pickUp2 : MonoBehaviour 
{
    public bool isHighlighted = false;
    public CharacterController character;
    private Color matColor;
    public float pickUpDistance = 3;
    public AudioSource pageSound;
    
    public playerControler pc;


    void OnMouseEnter()
    {
        Renderer render = GetComponent<Renderer>();
        matColor = render.material.color;

        if (InRange())
        {
            isHighlighted = true;
            render.material.color = Color.red;
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

        if (Input.GetKeyDown("e") && isHighlighted && InRange())
        {
            pageSound.Play();
            Destroy(gameObject);
            TeleportFrom.SetActive(true);
            pc.count++;
            pc.cout();
        }

    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    public GameObject TeleportTo;
    public GameObject TeleportFrom;
    static bool noRotateView = false;
    public float applyRotationX = 0.0f;
    public float applyRotationY = 0.0f;
    public float applyRotationZ = 0.0f;
    public bool FlickerFlashlight = false;


    public void OnTriggerEnter(Collider other)
    {
        
                CharacterController cc = other.GetComponent<CharacterController>();
                Transform tr = other.GetComponent<Transform>();
                cc.enabled = false;

               

                other.transform.Rotate(applyRotationX, applyRotationY, applyRotationZ, Space.Self);

                other.GetComponent<FirstPersonController>().mouseReset();

                

                other.transform.position = new Vector3(
                    other.transform.position.x + TeleportTo.transform.position.x - this.transform.position.x,
                    other.transform.position.y + TeleportTo.transform.position.y - this.transform.position.y,
                    other.transform.position.z + TeleportTo.transform.position.z - this.transform.position.z);

               
                cc.enabled = true;
                if (FlickerFlashlight)
                {
                    Flashlight asd = other.GetComponentInChildren<Flashlight>();
                    asd.flicker();
                }
            
            
        }
    

}
