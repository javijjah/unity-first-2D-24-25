using System.Collections;
using System.Collections.Generic;
using UnityEditorInternal;
using UnityEngine;


public class State : IState
{
    MonoBehaviour Boss;

    public State(MonoBehaviour Boss)
    {
        this.Boss = Boss;
    }

    public virtual void Entry()
    {
        // dejar que el estado lo cambie
    }

    public virtual void Exit()
    {
        // dejar que el estado lo cambie
    }

    public virtual void Update()
    {
        // dejar que cada estado lo cambie
    }
}
