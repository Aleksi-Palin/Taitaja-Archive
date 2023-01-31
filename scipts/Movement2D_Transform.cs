using System.Collections;
using System.Collections.Generic;
using UnityEngine;
/*
----the movement is handled by directly updating the Transform component's 
----position based on the horizontal and vertical inputs. 
----The Time.deltaTime factor ensures that the movement is smooth and framerate-independent.
 */
public class Movement2D_Transform : MonoBehaviour
{
    public float speed = 10.0f;

    void Update()
    {
        float horizontal = Input.GetAxis("Horizontal");
        float vertical = Input.GetAxis("Vertical");

        Vector3 direction = new Vector3(horizontal, vertical, 0);
        transform.position += direction * speed * Time.deltaTime;
    }
}
