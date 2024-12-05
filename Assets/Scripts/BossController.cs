using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    [SerializeField] private GameObject ToxicArea;

    State currentState;
    List<State> states = new List<State>();

    // ready
    void Start() 
    {
        /*
        // inicializar estados:
        //      definir estado inicial
        currentState = new FollowState(this);
        //      crear lista de estados
        states.Add(currentState);
        states.Add(new RageState());
        states.Add(new SpitState());
        states.Add(new BurpState());
        states.Add(new RecoveryState());
        */
        //      preparar sistema de eventos
    }

    // physics_process
    private void FixedUpdate()
    {
        // llamar fixedupdate del estado actual
    }

    // process
    void Update()
    {
        // llamar update del estado actual
        //currentState.Update();
    }
}
