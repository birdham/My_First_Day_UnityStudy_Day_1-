using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Rtan : MonoBehaviour
{
    // Start is called before the first frame update
    float direction = 0.05f;

    SpriteRenderer renderer;

    void Start()
    {
        Application.targetFrameRate = 60;
        renderer = GetComponent<SpriteRenderer>();
        Debug.Log("¾È³ç");

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            direction *= -1;
            renderer.flipX = !renderer.flipX;
        }
        if(transform.position.x > 2.6f)
        {
            renderer.flipX = true;
            direction = -0.05f;
        }
        if (transform.position.x < -2.6f)
        {
            renderer.flipX = false;
            direction = 0.05f;
        }


        transform.position += Vector3.right * direction;
    }
}
