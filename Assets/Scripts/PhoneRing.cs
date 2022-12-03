using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PhoneRing : MonoBehaviour
{
    public GameObject phoneRinging;
    public GameObject callerID;

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
        if (other.tag == "Player")
        {
            Debug.Log("player grabbed phone");
            StartCoroutine(Wait());

        }
    }
    IEnumerator Wait()

    {
        yield return new WaitForSeconds(5);    //Random.Range(10, 20);
        phoneRinging.SetActive(true);
        callerID.SetActive(true);
    }
}
