using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Light myLight;
    private bool lightOn = true;

    public AudioSource clickSound;
    public float lowestIntensity;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        lowestIntensity = myLight.intensity / 3;
    }

    // Update is called once per frame
    void Update()
    {
      
        turnOn();

        //Dimming flashlight
        if (myLight.enabled && myLight.intensity > lowestIntensity)
        {
            myLight.intensity -= Time.deltaTime / 800;
        }

    }
    // turning on/off flashlight
    void turnOn()
    {
        if (Input.GetKeyUp(KeyCode.F))
        {
            myLight.enabled = !myLight.enabled;
            clickSound.Play();
        }
        
    }

    public void flicker() 
    {
        if (myLight.enabled)
        {
        }
        myLight.enabled = false;
        clickSound.Play();
    }
    
}
