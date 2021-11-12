using UnityEngine;
using UnityStandardAssets.Characters.ThirdPerson;

public GameObject target;
public Transform targetPos;

void Start()
{
    Enemy = GetComponent<ThirdPersonCharacter>();
    agent = GetComponent<NavMeshAgent>();
    target = GameObject.Find("gameobject to be default target");
    targetPos = target.transform.position;

}

void Update()
{
    agent.destination = targetPos.position;
    Enemy.Move(agent.desiredVelocity, false, false);
}