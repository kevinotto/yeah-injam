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

    public List<Prompt> kendrickPrompts;
    public int pIndex; //prompt index, for instance, kendrickPrompts[0] would be pIndex = 0

    public TextMeshProUGUI choiceOneText;
    public TextMeshProUGUI choiceTwoText;
    public GameObject choiceOne;
    public GameObject choiceTwo;

    private void Start()
    {
        //Enemy initiates talking
        kendrickPrompts = GameObject.Find("Player").GetComponent<PromptList>().kendrickPrompts;
        pIndex = 0;
        StartCoroutine("EnemySpeech");
        choiceOne.SetActive(false); 
        choiceTwo.SetActive(false);
    }

    void GiveChoices() //Give the player choices
    {

        choiceOne.SetActive(true);
        choiceTwo.SetActive(true);
        choiceOneText.SetText(kendrickPrompts[pIndex].answerOne);
        choiceTwoText.SetText(kendrickPrompts[pIndex].answerTwo);
    }

    public void PlayerSpeech(int i) //Called when player clicks on button. The int is the index of the choice, so either
        //0 or 1
    {
        switch (i)
        {
            case 0:
                playerText.SetText(kendrickPrompts[pIndex].answerOne);
                pIndex += 1; //Good answer
                break;
            case 1:
                playerText.SetText(kendrickPrompts[pIndex].answerTwo);
                pIndex += 2; //Bad answer. Bad answers are always even numbers, good ones always odd
                break;
        }

        choiceOne.SetActive(false);
        choiceTwo.SetActive(false);

        StartCoroutine("EnemySpeech");
    }

    IEnumerator EnemySpeech() //Called after player responds
    {
        if (pIndex > 0)
        {
            yield return new WaitForSeconds(2);
        }
        enemyText.SetText(kendrickPrompts[pIndex].question);

        yield return new WaitForSeconds(1.5f);
        //Give player choices
        GiveChoices();
    }
}
