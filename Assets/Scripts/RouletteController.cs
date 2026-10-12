
using UnityEngine;

public class RouletteController : MonoBehaviour
{
    float rotSpeed = 720f;

    bool isStopping = false;

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            if (isStopping)
            {
                rotSpeed = 720f;
                isStopping = false;
            }
            else
            {
                isStopping = true;
            }
        }

        transform.Rotate(
            0f,
            0f,
            rotSpeed * Time.deltaTime
        );

        if (isStopping)
        {
            rotSpeed *= Mathf.Pow(
                0.96f,
                Time.deltaTime * 60f
            );

            if (rotSpeed < 1f)
            {
                rotSpeed = 0f;
            }
        }
    }
}
