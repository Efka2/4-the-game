using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Flashlight : MonoBehaviour
{
    public Light myLight;
    //public float maxBatteryLife = 20;
    private bool lightOn = true;
    //public static bool flicker = false;
    //public float lightDrain = 0.1f;
    //public float batteryLife = 0;

    public AudioSource clickSound;
    public float lowestIntensity;
    // Start is called before the first frame update
    void Start()
    {
        myLight = GetComponent<Light>();
        lowestIntensity = myLight.intensity / 3;
        //batteryLife = maxBatteryLife;
    }

    // Update is called once per frame
    void Update()
    {
        //if(lightOn && batteryLife > 0 && lightOn)
        //{
        //    batteryLife -= Time.deltaTime * lightDrain;
        //}

        //myLight.intensity = batteryLife;

        //if(batteryLife == 0)
        //{
        //    batteryLife = 0;
        //    lightOn = false;
        //}
        //toggleFlashLight();
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
        if (/*Input.GetMouseButtonDown(0))*/Input.GetKeyUp(KeyCode.F))
        {
            myLight.enabled = !myLight.enabled;
            clickSound.Play();
        }
        
    }

    public void flicker() // not a flicker but I dont care *dab dab maverick*
    {
        if (myLight.enabled)
        {
        }
        myLight.enabled = false;
        clickSound.Play();
    }
    
}
