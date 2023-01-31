using UnityEngine;

public class Shoot2Dobject : MonoBehaviour
{
    // Reference to the prefab that will be instantiated as the projectile
    public GameObject projectilePrefab;

    // The strength of the shot
    public float shootForce = 10.0f;

    void Update()
    {
        // Check if the left mouse button is pressed
        if (Input.GetMouseButtonDown(0))
        {
            // Get the mouse position in world space
            Vector3 mousePosition = Input.mousePosition;
            mousePosition = Camera.main.ScreenToWorldPoint(mousePosition);

            // Calculate the shoot direction
            Vector2 shootDirection = (mousePosition - transform.position).normalized;

            // Instantiate a new projectile at the current position
            GameObject newProjectile = Instantiate(projectilePrefab, transform.position, Quaternion.identity);

            // Apply a force to the new projectile in the shoot direction
            newProjectile.GetComponent<Rigidbody2D>().AddForce(shootDirection * shootForce, ForceMode2D.Impulse);
        }
    }
}
