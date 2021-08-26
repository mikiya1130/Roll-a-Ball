using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreateItems : MonoBehaviour
{
    public GameObject Item;

    public int ItemNum = 10;

    void Create()
    {
        for (int retry = 0; retry < 10; retry++)
        {
            float height = Item.GetComponent<CapsuleCollider>().height;
            float radius = Item.GetComponent<CapsuleCollider>().radius;
            float scaleY = Item.transform.localScale.y;

            height *= scaleY;

            float x = Random.Range(-10.0f, 10.0f);
            float y = height / 2.0f;
            float z = Random.Range(-10.0f, 10.0f);

            Vector3 bottom = new Vector3(x, y - height / 2 + radius, z);
            Vector3 top = new Vector3(x, y + height / 2 - radius, z);
            Collider[] cols =
                Physics.OverlapCapsule(top, bottom, radius, ~(1 << 8));

            if (cols.Length == 0)
            {
                Instantiate(Item,
                new Vector3(x, y, z),
                Quaternion.identity,
                this.transform);
                break;
            }
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        for (int i = 0; i < ItemNum; i++)
        {
            Create();
        }
    }

    // Update is called once per frame
    void Update()
    {
    }
}
