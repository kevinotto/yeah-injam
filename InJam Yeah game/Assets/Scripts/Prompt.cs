using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class Prompt
{
    public string question;
    public string answerOne;
    public string answerTwo;

    public Prompt(string question, string answerOne, string answerTwo)
    {
        this.question = question;
        this.answerOne = answerOne;
        this.answerTwo = answerTwo;
    }
}
