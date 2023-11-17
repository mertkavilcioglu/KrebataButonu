using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionPlayer : MonoBehaviour
{
    private CharacterController characterController;

    private void Start()
    {
        characterController = GetComponentInParent<CharacterController>();
    }

    void Update()
    {
        if (characterController.canButton && Input.GetKeyDown(KeyCode.E))
        {
            InteractWithAtaberk();
        }
    }

    private void InteractWithAtaberk()
    {
        Collider2D ataberkCollider = GetAtaberkCollider();

        if (ataberkCollider != null)
        {
            Ataberk ataberkScript = ataberkCollider.GetComponent<Ataberk>();

            if (ataberkScript != null)
            {
                ataberkScript.AtaberkButonu();
            }
        }
    }

    private Collider2D GetAtaberkCollider()
    {
        Collider2D[] colliders = Physics2D.OverlapCircleAll(transform.position, 0.1f);

        foreach (Collider2D collider in colliders)
        {
            if (collider.CompareTag("Ataberk"))
            {
                return collider;
            }
        }

        return null;
    }

    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Ataberk"))
        {
            Ataberk ataberkscp = FindObjectOfType<Ataberk>();
            //ataberkscp.AtaberkEActivate();
            characterController.canButton = true;
            //Debug.Log("canButton: " + characterController.canButton);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ataberk"))
        {
            Ataberk ataberkscp = FindObjectOfType<Ataberk>();
            //ataberkscp.AtaberkEDeactivate();
            characterController.canButton = false;
            //Debug.Log("canButton: " + characterController.canButton);
        }
    }
}
