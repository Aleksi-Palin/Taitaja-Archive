using UnityEngine;

public class Pickup2Dobject : MonoBehaviour
{
    private Transform carryTransform;
    private Transform holdTransform;

    void Start()
    {
        // Create a child GameObject to serve as the carry point
        carryTransform = new GameObject().transform;
        carryTransform.name = "Carry Point";
        carryTransform.SetParent(transform);
    }

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            // If an object is being held, drop it
            if (holdTransform != null)
            {
                holdTransform.SetParent(null);
                holdTransform = null;
                return;
            }

            // Raycast to find the closest pickup-able object
            RaycastHit2D hit = Physics2D.Raycast(transform.position, Vector2.right, 1.0f);
            if (hit.collider != null && hit.collider.CompareTag("Pickup"))
            {
                holdTransform = hit.transform;
                holdTransform.SetParent(carryTransform);
                holdTransform.position = carryTransform.position;
            }
        }
    }
}
