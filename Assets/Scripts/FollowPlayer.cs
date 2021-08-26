using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FollowPlayer : MonoBehaviour
{
    public GameObject Target;

    Vector3 offset;

    // Start is called before the first frame update
    void Start()
    {
        System.Random rand = new System.Random();
        int rotate = 90 * rand.Next(4);
        transform.RotateAround(Vector3.zero, Vector3.up, rotate);

        offset = transform.position - Target.transform.position;
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = Target.transform.position + offset;
    }
}
