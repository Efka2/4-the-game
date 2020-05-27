using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class randomSpawn : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        sukurtiLapelius();
    }

    // Update is called once per frame
    void Update()
    {

    }


    public GameObject[] lapeliai = new GameObject[4];
    public GameObject[] lapeliaiBaznycioj = new GameObject[2];
    public GameObject[] lapeliaiTowery = new GameObject[2];
    public GameObject[] lapeliaiNamely = new GameObject[2];
    public List<int> panaudoti;

    public void sukurtiLapelius()
    {
        int k = Random.Range(0, lapeliaiBaznycioj.Length);
        Destroy(lapeliaiTowery[k]);//.SetActive(true);

        Destroy(lapeliaiBaznycioj[k]);//.SetActive(true);

        Destroy(lapeliaiNamely[k]);//.SetActive(true);

        k = Random.Range(0, lapeliai.Length);
        for (int i = 0; i < 4; i++)
        {
            Destroy(lapeliai[k]);
        }
        //int i = 0;
        //while(i < 4)
        //{
        //    k = Random.Range(0, lapeliai.Length);
        //    if (!panaudoti.Contains(k))
        //    {
        //        lapeliai[k].SetActive(true);
        //        panaudoti.Add(k);
        //        i++;
        //    }
        //}
    }
}
