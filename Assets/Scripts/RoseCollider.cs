using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RoseCollider : MonoBehaviour
{
    
    
    public GameObject bekah1;
    
    public GameObject toby1;
    
    public GameObject ollie1;
    

    public ParticleSystem petalParticles;

    // Start is called before the first frame update
    void Start()
    {
        
        petalParticles.Stop();
    }

    

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Rose")
        {
            Debug.Log("Rose hit singer");
            
            bekah1.SetActive(true);
            toby1.SetActive(true);
            ollie1.SetActive(true);
            petalParticles.Play();
            StartCoroutine(Wait());
        }
    }
    IEnumerator Wait()

    {
        yield return new WaitForSeconds(8);    //Random.Range(10, 20);
        bekah1.SetActive(false);
        toby1.SetActive(false);
        ollie1.SetActive(false);
    }
}
