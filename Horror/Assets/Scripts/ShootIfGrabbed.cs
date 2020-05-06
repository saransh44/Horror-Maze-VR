using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootIfGrabbed : MonoBehaviour
{
    private SimpleShoot simpleShoot;
    private OVRGrabbable ovrGrabbable;
    public OVRInput.Button shootingButton;
    public GameObject GuideArrow;
    public AudioSource GunFire;
    public float TargetDistance;
    public int DamageAmount = 5;
    public RaycastHit Shot;
    public float rate = 0.4f;
    private float rate_time;
    public bool grabbed = false;

    // Start is called before the first frame update
    void Start()
    {
        simpleShoot = GetComponent<SimpleShoot>();
        ovrGrabbable = GetComponent<OVRGrabbable>();

    }

    // Update is called once per frame
    void Update()
    {
        if (ovrGrabbable.isGrabbed)
        {
            
            GuideArrow.SetActive(false);
            if (OVRInput.GetDown(shootingButton, ovrGrabbable.grabbedBy.GetController()) && Time.time > rate_time)
            {
                rate_time = Time.time + rate;
                simpleShoot.TriggerShoot();
                GunFire.Play();
                //yield return new WaitForSeconds(0.2f);
                if (Physics.Raycast(transform.position, transform.TransformDirection(Vector3.forward), out Shot))
                {
                    TargetDistance = Shot.distance;
                    Shot.transform.SendMessage("DamageZombie", DamageAmount, SendMessageOptions.DontRequireReceiver);
                }
                
            }
            //StartCoroutine(ScenePlayer());
        }
    }
    IEnumerator ScenePlayer()
    {
        yield return new WaitForSeconds(1.5f);

    }
}
