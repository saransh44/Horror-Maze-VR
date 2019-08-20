using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class DoorCellOpen : MonoBehaviour
{

    public float TheDistance;
    public GameObject ActionKey;
    public GameObject ActionText;
    public GameObject DoorHinge;
    public AudioSource CreakSound;

    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;
    }

    void OnMouseOver()
    {
        if (TheDistance <= 10)
        {
            ActionKey.SetActive(true);
            ActionText.SetActive(true);
        }
        if (Input.GetButtonDown("Oculus_CrossPlatform_Button2"))
        {
            if (TheDistance <= 10)
            {
                this.GetComponent<BoxCollider>().enabled = false;
                ActionKey.SetActive(false);
                ActionText.SetActive(false);
                DoorHinge.GetComponent<Animation>().Play("FirstDoorOpenAnim");
                CreakSound.Play();
            }
        }
    }

    void OnMouseExit()
    {
        ActionKey.SetActive(false);
        ActionText.SetActive(false);
    }
}