using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpitState : State
{
    public SpitState(BossController Boss) : base(Boss) {}

    public override void Entry()
    {
        base.Entry();
        Debug.Log("Spit State Entered");
        
        // instanciar proyectil
        //Boss.Bullet.Instantiate(Boss.firePoint.position,B);
        Object.Instantiate(Boss.Bullet, Boss.firePoint.position, Boss.firePoint.rotation);
        // siguiente estado
        Boss.ChangeStateKey(States.Recovery);
    }
}
