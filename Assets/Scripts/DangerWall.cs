using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DangerWall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        Material mat = GetComponent<Renderer>().material;
        mat.color =
            Color
                .Lerp(new Color(150.0f / 255.0f,
                    20.0f / 255.0f,
                    20.0f / 255.0f,
                    255.0f / 255.0f),
                new Color(255.0f / 255.0f,
                    20.0f / 255.0f,
                    20.0f / 255.0f,
                    255.0f / 255.0f),
                Mathf.PingPong(Time.time, 0.8f));
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            GameObject GameController = GameObject.Find("GameController");
            GameController.GetComponent<GameController>().GameOver();
        }
    }
}
