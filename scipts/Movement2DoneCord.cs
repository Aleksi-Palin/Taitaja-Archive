using UnityEngine;

public class Movement2DoneCord : MonoBehaviour
{
    // Speed of movement
    public float speed = 1.0f;

    // Target position for movement
    private Vector2 targetPosition;

    // Initialization
    void Start()
    {
        // Set target position to the current position
        targetPosition = transform.position;
    }

    // Called once per frame
    void Update()
    {
        // Check if up arrow key is pressed
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            // Update target position to move up by 1 unit
            targetPosition = new Vector2(transform.position.x, transform.position.y + 1);
        }
        // Check if down arrow key is pressed
        else if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            // Update target position to move down by 1 unit
            targetPosition = new Vector2(transform.position.x, transform.position.y - 1);
        }
        // Check if left arrow key is pressed
        else if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            // Update target position to move left by 1 unit
            targetPosition = new Vector2(transform.position.x - 1, transform.position.y);
        }
        // Check if right arrow key is pressed
        else if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            // Update target position to move right by 1 unit
            targetPosition = new Vector2(transform.position.x + 1, transform.position.y);
        }

        // Move the transform towards the target position at the specified speed
        transform.position = Vector2.MoveTowards(transform.position, targetPosition, speed * Time.deltaTime);
    }
}
