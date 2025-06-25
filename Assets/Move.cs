using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class Move : MonoBehaviour
{
    public Transform goal;
    public Transform goal2;
    public GameObject button;
    public GameObject button2;
    // Start is called before the first frame update
    void Start()
    {
        button = GameObject.Find("Cube");
        button2 = GameObject.Find("button");
    }

    // Update is called once per frame
    void Update()
    {
        NavMeshAgent agent = GetComponent<NavMeshAgent>();
        if (button.GetComponent<Button>().isClicked)
        {
            agent.destination = goal.position;
        }
        if (button2.GetComponent<Button2>().isClick)
        {
            agent.destination = goal2.position;
        }
    }
}
