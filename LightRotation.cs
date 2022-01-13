using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LightRotation : MonoBehaviour
{
    public float rightLimit;
    public float leftLimit;
    public float speed;

    int direction=1;

    // Update is called once per frame
    void Update()
    {
      float angle = transform.eulerAngles.z;
        if (angle > 180f)
        {
            angle -= 360f;
        }

        if ((angle < leftLimit) || (angle > rightLimit))
        {
            direction *= -1; // reverse direction (toggles between 1 & -1)
        }

        if (angle < leftLimit - 1)
        {
            angle = 0;
        }

        if (angle < rightLimit + 1)
        {
            angle = 0;
        }
        transform.Rotate (0, 0, speed * direction * Time.deltaTime);

    }
}
