using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class phonecollider : MonoBehaviour
{
    public GameObject cheers;
    public GameObject wall;
    public GameObject pinkLights;
    public GameObject whiteLights;

    // Start is called before the first frame update
    void Start()
    {
        
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
            wall.SetActive(true);
            pinkLights.SetActive(true);
            whiteLights.SetActive(false);
            StartCoroutine(Wait());

        }
    }
    IEnumerator Wait()

    {
        yield return new WaitForSeconds(8);    //Random.Range(10, 20);
        pinkLights.SetActive(false);
        whiteLights.SetActive(true);
        cheers.SetActive(true);
        wall.SetActive(false);
    }
}
