using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;

    Rigidbody rb;

    float inputHorizontal;

    float inputVertical;

    // Start is called before the first frame update
    void Start()
    {
        rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        inputHorizontal = Input.GetAxisRaw("Horizontal");
        inputVertical = Input.GetAxisRaw("Vertical");
    }

    void FixedUpdate()
    {
        Vector3 forward =
            Vector3
                .Scale(Camera.main.transform.forward, new Vector3(1, 0, 1))
                .normalized;

        Vector3 move =
            forward * inputVertical +
            Camera.main.transform.right * inputHorizontal;

        rb.AddForce(move * speed);
    }
}
