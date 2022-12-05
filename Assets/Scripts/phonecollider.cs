using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phonecollider : MonoBehaviour
{
    public GameObject cheers;
    
    public GameObject pinkLights;
    public GameObject whiteLights;

    public ParticleSystem smokeParticles;
    public ParticleSystem smoke1Particles;
    public ParticleSystem smoke2Particles;

    // Start is called before the first frame update
    void Start()
    {
        smokeParticles.Stop(); 
        smoke1Particles.Stop();
        smoke2Particles.Stop();
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == "Phone")
        {
            cheers.SetActive(true);
            
            pinkLights.SetActive(true);
            whiteLights.SetActive(false);  

            smokeParticles.Play();
            smoke1Particles.Play();
            smoke2Particles.Play();

            StartCoroutine(Wait());

        }
    }
    IEnumerator Wait()

    {
        yield return new WaitForSeconds(8);    //Random.Range(10, 20);
        pinkLights.SetActive(false);
        whiteLights.SetActive(true);
        
        cheers.SetActive(true);

        smokeParticles.Stop();
        smoke1Particles.Stop();
        smoke2Particles.Stop();

    }
}
