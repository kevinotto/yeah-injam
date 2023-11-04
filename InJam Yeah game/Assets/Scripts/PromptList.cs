using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PromptList : MonoBehaviour
{
    public List<Prompt> kendrickPrompts = new List<Prompt>();
    private void Start()
    {
        kendrickPrompts.Add(new Prompt("Hey there, Loner! It's been too long -- how have you been??", "Kendrick! I've been good, just caught up in life. How about you?", "Kendrick, it has been a while, but I'm quite busy these days.", 1));
        kendrickPrompts.Add(new Prompt("I've been great. We should catch up soon, grab a coffee?", "Absolutely, I'd love that. Let's make it happen.", "Nah, i don't really drink coffee anymore..", 1));

    }
}
