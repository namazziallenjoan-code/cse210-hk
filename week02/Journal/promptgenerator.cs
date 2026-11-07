using System;
using System.Collections.Generic;

public class Prompt
{
    private List<string> _prompts = new List<string>
    {
        "What made me smile today?",
        "What is one thing I learned today?",
        "Who helped me today, and how?",
        "What am I grateful for today?",
        "What challenge did I overcome today?",
        "What is one thing I want to improve tomorrow?",
        "How did I show kindness to someone today?",
        "What is one goal I want to achieve this week?"
    };

    private Random _random = new Random();

    public string GetRandomPrompt()
    {
        int index = _random.Next(_prompts.Count);

        return _prompts[index];
    }
}