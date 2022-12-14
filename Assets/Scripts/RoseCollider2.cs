using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoseCollider2 : MonoBehaviour
{

    
    public GameObject bekah2;
    
    public GameObject toby2;
    
    public GameObject ollie2;

    public ParticleSystem petalParticles;

    // Start is called before the first frame update
    void Start()
    {
        petalParticles.Stop();
    }



    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rose2")
        {
            Debug.Log("Rose2 hit singer");
            
            bekah2.SetActive(true);
            toby2.SetActive(true);
            ollie2.SetActive(true);
            petalParticles.Play();
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()

    {
        yield return new WaitForSeconds(8);    //Random.Range(10, 20);
        bekah2.SetActive(false);
        toby2.SetActive(false);
        ollie2.SetActive(false);
    }
}
