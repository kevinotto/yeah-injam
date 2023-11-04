using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Prompt
{
    public string question;
    public string answerOne;
    public Prompt answerOnePrompt; //question to be asked if player chooses answer one
    public string answerTwo;
    public Prompt answerTwoPrompt;
    public int level; //The level of the character (1-3)

    public Prompt(string question, string answerOne, string answerTwo, int level)
    {
        this.question = question;
        this.answerOne = answerOne;
        this.answerTwo = answerTwo;
        this.level = level;
    }
}
