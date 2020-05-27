using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class teleportOnCollide : MonoBehaviour
{

    //float speed = 2f;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        //transform.Translate(Vector3.forward * Time.deltaTime * speed);
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
}
