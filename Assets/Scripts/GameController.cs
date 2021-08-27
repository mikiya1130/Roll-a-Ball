using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject ScoreLabel;

    public GameObject WinnerLabel;

    public GameObject Button;

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        GameObject[] Items = GameObject.FindGameObjectsWithTag("Item");
        int countItems = Items.Length;
        Text score_text = ScoreLabel.GetComponent<Text>();
        score_text.text = countItems.ToString();

        if (countItems == 0)
        {
            WinnerLabel.SetActive(true);
            Button.SetActive(true);
        }
    }
}
