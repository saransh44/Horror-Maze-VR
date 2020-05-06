using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.UI;

public class BFirstTrigger : MonoBehaviour
{

    public GameObject ThePlayer;
    public GameObject TextBox;
    public GameObject TheMarker;
    public bool once = true;
    void OnTriggerEnter()
    {
        this.GetComponent<BoxCollider>().enabled = false;
        //ThePlayer.GetComponent<OVRPlayerController>().enabled = false;
        if (once)
        StartCoroutine(ScenePlayer());
    }

    IEnumerator ScenePlayer()
    {
        TextBox.GetComponent<Text>().text = "Looks like a weapon on that table.";
        yield return new WaitForSeconds(2.5f);
        TheMarker.SetActive(true);
        TextBox.GetComponent<Text>().text = "Don't let go once you've grabbed it";
        yield return new WaitForSeconds(2.5f);
        TextBox.GetComponent<Text>().text = "";
        //ThePlayer.GetComponent<OVRPlayerController>().enabled = true;
        once = false;
    }

}
