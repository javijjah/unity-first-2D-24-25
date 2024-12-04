using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    FollowState currentState = new FollowState();

    // ready
    void Start() 
    {
        // inicializar estados:
        //      definir estado inicial
        //      preparar sistema de eventos
    }

    // physics_process
    private void FixedUpdate()
    {
        // llamar fixedupdate del estado actual
        currentState.FixedUpdate();
    }

    // process
    void Update()
    {
        // llamar update del estado actual
        currentState.Update();
    }
}
