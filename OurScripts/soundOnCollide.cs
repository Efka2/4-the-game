using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class soundOnCollide : MonoBehaviour
{
    //public AudioSource jumpingMusic;
    public bool played = false;
    AudioSource sp;
    // Start is called before the first frame update
    void Start()
    {
         sp = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void OnTriggerEnter(Collider other)
    {
        //speed = speed * -1;
        //colorPicker = Random.Range(0, 10);

            if (other.gameObject.tag == "Player" && !played)
            {
                sp.Play();
                //sp.clip = sound;
                //jumpingMusic.Play();
                played = true;
            }



    }
}