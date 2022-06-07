using System.Collections.Generic;
using UnityEngine;

public class ActionManager : MonoBehaviour
{
    private readonly Stack<Actionable> actionables=new Stack<Actionable>();
    public void Record(Actionable action)
    {
        actionables.Push(action);
        action.Execute();
    }

    public void Undo()
    {
        Actionable action=actionables.Pop();
        action.Undo();
    }
}
