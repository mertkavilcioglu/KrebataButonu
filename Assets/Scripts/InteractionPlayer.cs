using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InteractionPlayer : MonoBehaviour
{
    // Diðer bileþenlere eriþim için referanslar
    private CharacterController characterController;

    private void Start()
    {
        // Start fonksiyonunda gerekli referanslarý al
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
            characterController.canButton = true;
            Debug.Log("canButton: " + characterController.canButton);
        }
    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("Ataberk"))
        {
            characterController.canButton = false;
            Debug.Log("canButton: " + characterController.canButton);
        }
    }
}
