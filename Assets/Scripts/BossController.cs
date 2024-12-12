using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BossController : MonoBehaviour
{
    [SerializeField] private GameObject ToxicArea;
    [SerializeField] private PlayerController Player;
    [SerializeField] public GameObject Bullet;

    public Transform firePoint;
    public float currentHealth;
    private float maxHealth = 200;
    
    State currentState;
    Dictionary<States, State> statesDict = new Dictionary<States, State>();

    // ready
    void Start()
    {
        // inicializar datos boss
        currentHealth = maxHealth;
        
        // inicializar estados:
        //      definir estado inicial
        currentState = new FollowState(this);
        currentState.Entry();
        //      crear lista de estados
        statesDict.Add(States.Follow, currentState);
        statesDict.Add(States.Rage, new RageState(this));
        statesDict.Add(States.Spit, new SpitState(this));
        statesDict.Add(States.Burp, new BurpState(this));
        statesDict.Add(States.Recovery, new RecoveryState(this));
        
        //      preparar sistema de eventos
    }

    // process
    void Update()
    {
        // llamar update del estado actual
        currentState.Update();
    }

    public float GetHealthPercentage()
    {
        return currentHealth / maxHealth;
    }

    public void ChangeStateKey(States newState)
    {
        if(statesDict.ContainsKey(newState))
        {
            ChangeState(statesDict[newState]);
        }
        else
        {
            Debug.LogWarning("State not in list.");
        }
    }
    
    void ChangeState(State newState)
    {
        currentState.Exit();
        currentState = newState;
        currentState.Entry();
    }    
}

public enum States
{
    Follow, Spit, Burp, Recovery, Rage,
}