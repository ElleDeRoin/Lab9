using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    public float moveSpeed = 5f;
    public float maxLeft = -8f;
    public float maxRight = 8f;

    private void Update()
    {
        float moveX = Input.GetAxis("Horizontal");
        Vector3 movement = new Vector2(moveX, 0f) * moveSpeed * Time.deltaTime;
        transform.Translate(movement);

        if (transform.position.x < maxLeft)
        {
            transform.position = new Vector3(maxLeft, transform.position.y, transform.position.z);
        }
        else if (transform.position.x > maxRight)
        {
            transform.position = new Vector3(maxRight, transform.position.y, transform.position.z);
        }

    }


}
