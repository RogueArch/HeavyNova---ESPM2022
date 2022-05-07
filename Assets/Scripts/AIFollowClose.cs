using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AIFollowClose : MonoBehaviour
{
    public GameObject player;
    public UnityEngine.AI.NavMeshAgent agent;
    private void OnTriggerEnter(Collider other)
    {
        player = other.gameObject;
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        agent.SetDestination(player.transform.position);
    }
}
