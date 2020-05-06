using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.AI;

public class zombieScript : MonoBehaviour
{
    //declare the transform of our goal (where the navmesh agent will move towards) and our navmesh agent (in this case our zombie)
    private Transform goal;
    private NavMeshAgent agent;
    public Camera thePlayer;

    // Use this for initialization
    void Start()
    {

        //create references
        goal = thePlayer.transform;
        agent = GetComponent<NavMeshAgent>();
        //set the navmesh agent's desination equal to the main camera's position (our first person character)
        agent.destination = goal.position;
        //start the walking animation
        //GetComponent<Animation>().Play("walk_2");
    }
    void Update()
    {
        agent.destination = thePlayer.transform.position;

    }

    //for this to work both need colliders, one must have rigid body, and the zombie must have is trigger checked.
    void OnTriggerEnter(Collider col)
    {
        //first disable the zombie's collider so multiple collisions cannot occur
        GetComponent<CapsuleCollider>().enabled = false;
        //destroy the bullet
        Destroy(col.gameObject);
        //stop the zombie from moving forward by setting its destination to it's current position
        agent.destination = gameObject.transform.position;
        //stop the walking animation and play the falling back animation
        GetComponent<Animation>().Stop();
        GetComponent<Animation>().Play("fallingback");
        //destroy this zombie in six seconds.
        Destroy(gameObject, 6);
      

    }

}
