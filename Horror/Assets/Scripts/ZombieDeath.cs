using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class ZombieDeath : MonoBehaviour
{

    public int EnemyHealth = 20;
    public GameObject TheEnemy;
    public int StatusCheck;
    public AudioSource JumpScareMusic;

    void DamageZombie(int DamageAmount)
    {
        EnemyHealth -= DamageAmount;
    }




    void Update()
    {
        if (EnemyHealth <= 0 && StatusCheck == 0)
        {
            this.GetComponent<ZombieAI>().enabled = false;
            this.GetComponent<BoxCollider>().enabled = false;
            StatusCheck = 2;
            TheEnemy.GetComponent<Animation>().Stop("walk 1");
            JumpScareMusic.Stop();
            TheEnemy.GetComponent<Animation>().Play("fallingback 1");
            //StartCoroutine(ScenePlayer());
            Destroy(gameObject, 0.66f);
            //SceneManager.LoadScene(2);

        }
    }

    IEnumerator ScenePlayer()
    {
        do
        {
            yield return null;
        }
        while (TheEnemy.GetComponent<Animation>().isPlaying);

    }
}
