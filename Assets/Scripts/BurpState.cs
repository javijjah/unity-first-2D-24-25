using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BurpState : State
{
    public BurpState(MonoBehaviour boss) : base(boss) {}

    public override void Entry()
    {
        // activar animaci�n follow
    }

    public override void Exit()
    {
        // terminar animaci�n follow
    }

    public override void Update()
    {
        // buscar jugador y seguir
    }
}
