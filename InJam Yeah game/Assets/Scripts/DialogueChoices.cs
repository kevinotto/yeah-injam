using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class DialogueChoices : MonoBehaviour
{
    //This script is attached to the empty "Player" gameobject.

    public GameObject playerChatBox;
    public TextMeshProUGUI playerText;
    public GameObject enemyChatBox; //Just calling the second texter the enemy for convenience
    public TextMeshProUGUI enemyText;

    public GameObject choiceOne;
    public TextMeshProUGUI choiceOneText;
    public GameObject choiceTwo;
    public TextMeshProUGUI choiceTwoText;

    string enemySpeech; //Just set this to whatever the enemy is supposed to say next
    string[] choices; //An array of the (most of the time, 2) choices available to the player.

    private void Start()
    {
        //Enemy initiates talking
        enemyText.SetText("Been a while -- what's up, buddy??");
    }

    void GiveChoices() //Give the player choices
    {

    }

    void PlayerSpeech(string s) //Called when player clicks on button. The string should be choices[0 or 1],
        //of course depending on what the player chose
    {

    }

    void EnemySpeech() //Called after player responds
    {
        //Set the enemy's text blahblahblah

        //Give player choices
        GiveChoices();
    }
}
