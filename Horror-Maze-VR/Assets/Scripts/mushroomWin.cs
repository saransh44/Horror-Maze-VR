using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class mushroomWin : MonoBehaviour
{
    public float TheDistance;
    public GameObject ActionKey;
    public GameObject MushText;
   
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        TheDistance = PlayerCasting.DistanceFromTarget;

        void OnMouseOver()
        {
            if (TheDistance <= 15)
            {
                ActionKey.SetActive(true);
                MushText.SetActive(true);
            }
            if (Input.GetButtonDown("Oculus_CrossPlatform_Button2"))
            {
                if (TheDistance <= 15)
                {
                    ActionKey.SetActive(false);
                    MushText.SetActive(false);
                    SceneManager.LoadScene(2);
                }
            }
        }

        void OnMouseExit()
        {
            ActionKey.SetActive(false);
            MushText.SetActive(false);
        }
    }
}
