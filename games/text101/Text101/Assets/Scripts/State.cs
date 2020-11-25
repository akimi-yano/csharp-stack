using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[CreateAssetMenu(menuName = "State")]
public class State : ScriptableObject
{
    // first one is mininum ; second one is where it starts to scroll
    [TextArea(14,10)] [SerializeField] string storyText;
    [SerializeField] State[] nextStates;
    public string GetStateStory() 
    { 
        return storyText; 
    }
    public State[] GetNextStates()
    {
        return nextStates;
    }

}
