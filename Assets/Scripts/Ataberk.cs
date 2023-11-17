using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ataberk : MonoBehaviour
{
    public GameObject firstObjectToActivate;
    public GameObject secondObjectToDeactivate;
    //[SerializeField] GameObject eButton;

    public void AtaberkButonu()
    {
        //Debug.Log("ATABERK");
        if (firstObjectToActivate != null)
        {
            firstObjectToActivate.SetActive(true);
        }

        if (secondObjectToDeactivate != null)
        {
            secondObjectToDeactivate.SetActive(false);
        }
    }

    /*public void AtaberkEActivate()
    {
        if (eButton != null)
        {
            eButton.SetActive(true);
        }
    }

    public void AtaberkEDeactivate()
    {
        if (eButton != null)
        {
            eButton.SetActive(false);
        }
    }*/
}
