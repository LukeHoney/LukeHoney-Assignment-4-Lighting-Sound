using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoseCollider : MonoBehaviour
{
    
    public GameObject cheers;
    //public GameObject cheers1;
    //public GameObject cheers2;
    //public GameObject cheers3;

    public ParticleSystem petalParticles;

    // Start is called before the first frame update
    void Start()
    {
        cheers.SetActive(false);
        petalParticles.Stop();
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rose")
        {
            Debug.Log("Rose hit singer");
            cheers.SetActive(true);
            //cheers1.SetActive(true);
            //cheers2.SetActive(true);
            //cheers3.SetActive(true);
            petalParticles.Play();
        }
    }
}
