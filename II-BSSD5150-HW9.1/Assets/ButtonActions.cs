using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonActions : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void diceButtonClicked()
    {
    //Debug.Log("You just clicked the dice roller.");
    //gameObject.GetComponentInChildren<Text>().text = "You did it!";
    
    Text score = GameObject.FindGameObjectWithTag("Score").GetComponent<Text>(); // Get current score. It is text so we have to turn it to a number to add 1.
    int scoreVal = int.Parse(score.text); // Parse the score text to an integer.
    
    // Add one and turn it back to a string to go in the Text.
    score.text = (scoreVal + 1).ToString();
    }
}
