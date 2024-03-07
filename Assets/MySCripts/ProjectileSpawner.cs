using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProjectileSpawner : MonoBehaviour
{
    public GameObject projectilePrefab; // Assign your projectile prefab in the Inspector
    public float projectileSpeed = 10f;

    void Update()
    {
        // Check if the trigger is pressed
        if (XRInputManager.IsButtonDown())
        {
            GameObject projectile = Instantiate(projectilePrefab, Camera.main.transform.position, Camera.main.transform.rotation);

            // Add velocity to the projectile
            Rigidbody rb = projectile.GetComponent<Rigidbody>();
            if (rb != null)
            {
                rb.velocity = Camera.main.transform.forward * projectileSpeed;
            }
        }
    }

    // OnCollisionEnter is called when the projectile collides with another collider
    void OnCollisionEnter(Collision collision)
    {
        // Check if the collider's parent has the "Player" tag
        if (collision.transform.parent != null && collision.transform.parent.CompareTag("Player"))
        {
            // Destroy the parent object
            Destroy(collision.transform.parent.gameObject);
        }
    }
}