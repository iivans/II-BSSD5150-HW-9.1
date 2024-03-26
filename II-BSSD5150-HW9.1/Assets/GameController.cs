using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class GameController : MonoBehaviour
{
    [SerializeField]
    TextMeshProUGUI computerChoice;

    [SerializeField]
    TextMeshProUGUI resultText; // New text box for displaying game result

    string[] choices = new string[] { "Rock", "Paper", "Scissors" };

    void Start()
    {
        ResetGame();
    }

    public void RPSClicked(string userChoice)
    {
        int randomIndex = Random.Range(0, choices.Length);
        string randomChoice = choices[randomIndex];
        computerChoice.text = randomChoice;
        CheckWinner(userChoice, randomChoice);
    }

    private void CheckWinner(string p1, string p2)
    {
        if (string.Equals(p1, p2))
        {
            resultText.text = "Draw";
        }
        else if ((string.Equals(p1, "Rock") && string.Equals(p2, "Scissors")) ||
                 (string.Equals(p1, "Paper") && string.Equals(p2, "Rock")) ||
                 (string.Equals(p1, "Scissors") && string.Equals(p2, "Paper")))
        {
            resultText.text = "You Win";
        }
        else
        {
            resultText.text = "Computer Wins";
        }
    }

    public void ResetGame()
    {
        computerChoice.text = "";
        resultText.text = "";
    }
}
