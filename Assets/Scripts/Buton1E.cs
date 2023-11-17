using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Buton1E : MonoBehaviour
{
    public GameObject EButton1;

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (EButton1 != null)
            {
                //Debug.Log("EEEEEEEEE ");
                EButton1.SetActive(true);
            }
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            if (EButton1 != null)
            {
                //Debug.Log("EEEEEEEEE ");
                EButton1.SetActive(false);
            };
        }
    }
}
