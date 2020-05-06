using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class AOpening : MonoBehaviour
{

    public GameObject ThePlayer;
    public GameObject FadeScreenIn;
    public GameObject TextBox;

    void Start()
    {
        //ThePlayer.GetComponent<OVRPlayerController>().enabled = false;
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(3f);
        FadeScreenIn.SetActive(false);
        TextBox.GetComponent<Text>().text = "Bad Shroom Trip";
        yield return new WaitForSeconds(2f);
        TextBox.GetComponent<Text>().text = "Goal: Interact with mushrooms to find the kinds for suitable antitdote";
        yield return new WaitForSeconds(4);
        TextBox.GetComponent<Text>().text = "Be careful! They all look alike but most are shrooms";
        yield return new WaitForSeconds(4);
        TextBox.GetComponent<Text>().text = "Releasing hallucinations of zombies walking through walls just for you :)";
        yield return new WaitForSeconds(4);
        TextBox.GetComponent<Text>().text = "Begin";
        yield return new WaitForSeconds(1.5f);
        TextBox.GetComponent<Text>().text = "";
        //ThePlayer.GetComponent<OVRPlayerController>().enabled = true;

    }

}
