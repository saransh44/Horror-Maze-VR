using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ZombieAI : MonoBehaviour
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

    void Update()
    {
        transform.LookAt(thePlayer.transform);
        if (attackTrigger == false)
        {
            enemySpeed = 0.01f;
            theEnemy.GetComponent<Animation>().Play("walk 1");
            transform.position = Vector3.MoveTowards(transform.position, thePlayer.transform.position, enemySpeed);
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
        theEnemy.GetComponent<Animation>().Stop("walk 1");
    }

    void OnTriggerExit()
    {
        attackTrigger = false;
        theEnemy.GetComponent<Animation>().Play("walk 1");

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