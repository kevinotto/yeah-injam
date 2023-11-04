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

    public List<Prompt> friendPrompts;
    public int pIndex = 0; //prompt index, for instance, friendPrompts[0] would be pIndex = 0
    public int exchanges; //Amount of exchanges since initial message
    public int totalExc; //The total amount of exchanges

    public TextMeshProUGUI choiceOneText;
    public TextMeshProUGUI choiceTwoText;
    public GameObject choiceOne;
    public GameObject choiceTwo;

    private void Start()
    {
        //Enemy initiates talking
        friendPrompts = GameObject.Find("Player").GetComponent<PromptList>().friendPrompts;
        pIndex = 0;
        StartCoroutine("EnemySpeech");
        choiceOne.SetActive(false); 
        choiceTwo.SetActive(false);
    }

    void GiveChoices() //Give the player choices
    {
        choiceOne.SetActive(true);
        choiceTwo.SetActive(true);
        choiceOneText.SetText(friendPrompts[pIndex].answerOne);
        choiceTwoText.SetText(friendPrompts[pIndex].answerTwo);
    }

    public void PlayerSpeech(int i) //Called when player clicks on button. The int is the index of the choice, so either
        //0 or 1
    {
        if (exchanges < 2)
        {
            switch (i)
            {
                case 0:
                    playerText.SetText(friendPrompts[pIndex].answerOne);
                    pIndex += 1; //Good answer
                    break;
                case 1:
                    playerText.SetText(friendPrompts[pIndex].answerTwo);
                    pIndex += 2; //Bad answer. Bad answers are always even numbers, good ones always odd
                    break;
            }
            exchanges += 1;
        }
        else
        {
            totalExc = exchanges + 1;
            exchanges = 0;
            pIndex = totalExc;
            Debug.Log("RESET!");
        }
        Debug.Log(exchanges.ToString());

        choiceOne.SetActive(false);
        choiceTwo.SetActive(false);
        GameObject.Find("PlayerSprite").GetComponent<AudioSource>().Play();

        StartCoroutine("EnemySpeech");
    }

    IEnumerator EnemySpeech() //Called after player responds
    {
        yield return new WaitForSeconds(0.05f);
        if (pIndex > 0)
        {
            yield return new WaitForSeconds(2);
        }
        enemyText.SetText(friendPrompts[pIndex].question);
        GameObject.Find("EnemySprite").GetComponent<AudioSource>().Play();


        yield return new WaitForSeconds(1.5f);
        //Give player choices
        GiveChoices();
    }
}
