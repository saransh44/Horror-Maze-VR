using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mushZombieSpawn : MonoBehaviour
{
    public GameObject ZombieText;
    public bool tested = false;
    public GameObject TheZombie;
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    void OnTriggerEnter()
    {
        if (!tested)
        {
            //SceneManager.LoadScene(2);
            ZombieText.SetActive(true);
            TheZombie.SetActive(true);
        }
    }

    void OnTriggerExit()
    {
        ZombieText.SetActive(false);
        tested = true;
    }
}
