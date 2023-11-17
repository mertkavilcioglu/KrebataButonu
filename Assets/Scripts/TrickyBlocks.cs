using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrickyBlocks : MonoBehaviour
{
    public GameObject obj1;
    public GameObject obj2; 
    public float changeTime = 2f; 

    private float timePassed;

    void Start()
    {
        obj1.SetActive(true);
        obj2.SetActive(false);

        timePassed = 0f;
    }

    void Update()
    {
        // Zamaný güncelle
        timePassed += Time.deltaTime;

        if (timePassed >= changeTime)
        {
            obj1.SetActive(!obj1.activeSelf);
            obj2.SetActive(!obj2.activeSelf);

            timePassed = 0f;
        }
    }
}
