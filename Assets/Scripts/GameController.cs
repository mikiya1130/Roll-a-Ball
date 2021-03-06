using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    public GameObject Panel;

    public GameObject ScoreLabel;

    public GameObject ResultLabel;

    public GameObject Button;

    public GameObject HowToPlay;

    public GameObject Joystick;

    public GameObject Player;

    static bool first = true;

    // Start is called before the first frame update
    void Start()
    {
        if (first)
        {
            Panel.SetActive(true);
            ScoreLabel.SetActive(false);
            Button.SetActive(true);
            Button.transform.Find("Text").gameObject.GetComponent<Text>().text =
                "Play";
            HowToPlay.SetActive(true);
            Joystick.SetActive(false);
            Player.GetComponent<PlayerController>().stop = true;
            first = false;
        }
    }

    // Update is called once per frame
    void Update()
    {
        int countItem = GameObject.FindGameObjectsWithTag("Item").Length;
        Text score_text = ScoreLabel.GetComponent<Text>();
        score_text.text = countItem.ToString();

        if (countItem == 0)
        {
            GameClear();
        }
    }

    void GameClear()
    {
        printMenu("GAME CLEAR!!");
    }

    public void GameOver()
    {
        printMenu("GAME OVER");
    }

    void printMenu(string text)
    {
        Panel.SetActive(true);

        Text result_text = ResultLabel.GetComponent<Text>();
        result_text.text = text;
        ResultLabel.SetActive(true);

        Button.SetActive(true);

        Joystick.SetActive(false);

        Player.GetComponent<PlayerController>().stop = true;
    }
}
