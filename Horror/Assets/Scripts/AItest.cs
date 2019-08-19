using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AItest : MonoBehaviour
{

    public GameObject thePlayer;
    public GameObject theEnemy;
    public float enemySpeed = 0.01f;
    public bool attackTrigger = false;
    public bool isAttacking = false;
    public AudioSource hurtSound1;
    public AudioSource hurtSound2;
    public AudioSource hurtSound3;
    public int hurtGen;
 
    Vector3 newPos;
    Quaternion newRot;

    void Start()
    {
        newRot.x = 0;
    }

    void Update()
    {
        transform.LookAt(thePlayer.transform);
        if (attackTrigger == false)
        {
            enemySpeed = 0.01f;
            theEnemy.GetComponent<Animation>().Play("walk_in_place_1");
            newPos.x = Vector3.MoveTowards(transform.position, thePlayer.transform.position, enemySpeed).x;
            newPos.y = transform.position.y;
            newPos.z = Vector3.MoveTowards(transform.position, thePlayer.transform.position, enemySpeed).z;
            newRot.x = 0;
            newRot.y = transform.rotation.y;
            newRot.z = transform.rotation.z;

            transform.position = newPos;
            transform.rotation = newRot;
            //transform.rotation = Quaternion()
        }
        if (attackTrigger == true && isAttacking == false)
        {
            enemySpeed = 0;
            theEnemy.GetComponent<Animation>().Play("attack 1");
            StartCoroutine(InflictDamage());
        }

    }

    void OnTriggerEnter()
    {
        attackTrigger = true;
        theEnemy.GetComponent<Animation>().Stop("walk_in_place_1");
    }

    void OnTriggerExit()
    {
        attackTrigger = false;
        theEnemy.GetComponent<Animation>().Play("walk_in_place_1");

    }


    IEnumerator InflictDamage()
    {
        isAttacking = true;
        hurtGen = Random.Range(1, 4);
        if (hurtGen == 1)
        {
            hurtSound1.Play();
        }
        if (hurtGen == 2)
        {
            hurtSound2.Play();
        }
        if (hurtGen == 3)
        {
            hurtSound3.Play();
        }
        yield return new WaitForSeconds(1.1f);
        GlobalHealth.currentHealth -= 5;
        
        yield return new WaitForSeconds(0.9f);
        isAttacking = false;
    }

}