using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class GameController : MonoBehaviour
{
    public GameObject gameOverText;

    public Text Scoretext;
    int score = 0;
    // Start is called before the first frame update
    void Start()
    {
        gameOverText.SetActive(false);
        Scoretext.text = "Score:" + score;
    }
    private void Update()
    {
        if (gameOverText.activeSelf == true)
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                SceneManager.LoadScene("start");
            }
            else if (Input.GetKeyDown(KeyCode.R))
            {
                SceneManager.LoadScene("SampleScene");
            }
        }
    }

    // Update is called once per frame
    public void AddScore()
    {
        score += 100;
        Scoretext.text = "Score:" + score;
    }

    public void GameOver()
    {
        gameOverText.SetActive(true);
        Scoretext.text = "Score:" + score;
    }
}
