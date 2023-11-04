using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromptList : MonoBehaviour
{
    public List<Prompt> friendPrompts = new List<Prompt>();
    private void Start()
    {
        friendPrompts.Add(new Prompt("Hey, it's been a while! Wanna catch up this weekend?", "Sure, i'd love to hang out. I'm doing great!", "Sure! I've been feeling down, so I could use some company."));
        friendPrompts.Add(new Prompt("Great, looking forward to it!", "Same here! It's been so long..", "[NO ANSWER]"));
        friendPrompts.Add(new Prompt("I'm here for you. Let's talk in the weekend", "Thanks, that means a lot", "Yup.."));

    }
}
