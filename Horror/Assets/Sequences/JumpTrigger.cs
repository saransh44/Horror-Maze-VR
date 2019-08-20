using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JumpTrigger : MonoBehaviour
{
    public AudioSource DoorBang;
    public AudioSource DoorJumpMusic;
    public GameObject TheZombie;
    public GameObject TheDoor;
    public static bool spook = false;

    void OnTriggerEnter()
    {
        if (!spook)
        {
            GetComponent<BoxCollider>().enabled = false;
            TheDoor.GetComponent<Animation>().Play("JumpDoorAnim");
            DoorBang.Play();
            TheZombie.SetActive(true);
            StartCoroutine(PlayJumpMusic());
            spook = true;
        }
    }
    void OnTriggerExit()
    {
        spook = true;
    }
    IEnumerator PlayJumpMusic()
    {
        yield return new WaitForSeconds(0.4f);
        DoorJumpMusic.Play();
    }
}
