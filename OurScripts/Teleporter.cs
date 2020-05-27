using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityStandardAssets.Characters.FirstPerson;
//using UnityStandartAssets.Characters.FirstPerson; //This
//using StandartAssets;

public class Teleporter : MonoBehaviour
{

    public GameObject TeleportTo;
    //private GameObject Player;
    static bool noRotateView = false;
    public float applyRotationX = 0.0f;
    public float applyRotationY = 0.0f;
    public float applyRotationZ = 0.0f;
    public bool FlickerFlashlight = false;
    //public FirstPersonController fpc;
    // Start is called before the first frame update
    void Start()
    {
      // Player = GameObject.Find("Player");

    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        //speed = speed * -1;
        //colorPicker = Random.Range(0, 10);
        try
        {
            CharacterController cc = other.GetComponent<CharacterController>();
            Transform tr = other.GetComponent<Transform>();
            cc.enabled = false;

            //object fpc = other.GetComponent<FirstPersonController>();
            //GameObject.Find("Player").GetComponent("First Person Controller").enabled = false;
            //Player.GetComponent("First Person Controller").enabled = false;
            //var asd = GameObject.Find("Player").GetComponent("ridgidbody");
            //other.enabled = false;

            //asd.enabled = false;

            //Player.transform.Rotate(0, 30f, 0, Space.World);
            //other.transform.Rotate(90.0f, 50.0f, 30.0f, Space.Self);
            //other.transform.rotation = new Quaternion(90.0f, 50.0f, 30.0f, 30.0f);

            //other.transform.rotation = TeleportTo.transform.rotation;

            //other.transform.rotation = Quaternion.Euler(
            //    TeleportTo.transform.rotation.x + other.transform.rotation.x,
            //    TeleportTo.transform.rotation.y + other.transform.rotation.y,
            //    TeleportTo.transform.rotation.z + other.transform.rotation.z);

            /*other.transform.rotation = Quaternion.Euler(
                applyRotationX + tr.rotation.x,
                applyRotationY + tr.rotation.y,
                applyRotationZ + tr.rotation.z);*/

            other.transform.Rotate(applyRotationX, applyRotationY, applyRotationZ, Space.Self);

            other.GetComponent<FirstPersonController>().mouseReset();

            //other.GetComponent(FirstPersonController).mouseReset();

            //other.transform.position = new Vector3(
            //    other.transform.position.x + TeleportTo.transform.position.x - this.transform.position.x,
            //    other.transform.position.y + TeleportTo.transform.position.y - this.transform.position.y,
            //    other.transform.position.z + TeleportTo.transform.position.z - this.transform.position.z);

            other.transform.position = new Vector3(
                other.transform.position.x + TeleportTo.transform.position.x - this.transform.position.x,
                other.transform.position.y + TeleportTo.transform.position.y - this.transform.position.y,
                other.transform.position.z + TeleportTo.transform.position.z - this.transform.position.z);

            //Camera.main.transform.rotation = Quaternion.Euler(TeleportTo.transform.rotation.x, TeleportTo.transform.rotation.y, TeleportTo.transform.rotation.z);
            cc.enabled = true;
            if (FlickerFlashlight)
            {
                Flashlight asd = other.GetComponentInChildren<Flashlight>();
                //asd.flicker = true;
                asd.flicker();
            }
            //other.enabled = true;
            //other.transform.Rotate(TeleportTo.transform.rotation.x, TeleportTo.transform.rotation.y, TeleportTo.transform.rotation.z, Space.Self);
        }
        catch (System.Exception)
        {
            //System.Console.WriteLine(Exception);
            //throw;
        }

        //other.transform.rotation = new Quaternion(0, 10, 0, 0);
    }
}
