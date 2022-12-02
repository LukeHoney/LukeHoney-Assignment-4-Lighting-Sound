using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoseCollider : MonoBehaviour
{
    
    public GameObject cheers;
    public GameObject bekah1;
    public GameObject bekah2;
    public GameObject toby1;
    public GameObject toby2;
    public GameObject ollie1;
    public GameObject ollie2;

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
            bekah1.SetActive(true);
            toby1.SetActive(true);
            ollie1.SetActive(true);
            petalParticles.Play();
        }
    }
}
