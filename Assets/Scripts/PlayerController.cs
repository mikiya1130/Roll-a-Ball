using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public float speed = 10.0f;

    public GameObject Item;

    public bool stop = false;

    Rigidbody rb;

    float inputHorizontal;

    float inputVertical;

    int countItem;

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

        countItem = GameObject.FindGameObjectsWithTag(Item.tag).Length;
    }

    void FixedUpdate()
    {
        if (stop)
        {
            rb.velocity = Vector3.zero;
        }
        else
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
}
