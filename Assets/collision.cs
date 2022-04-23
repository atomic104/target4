using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class collision : MonoBehaviour
{
    float setime = 0;
    public GameObject hyouteki;
    // Start is called before the first frame update
    void Start()
    {
    }
    // Update is called once per frame
    void Update()
    {
        
    }
    void OnTriggerEnter(Collider other)
    {
      
       
            
            //Instantiate(hyouteki, new Vector3((float)Random.Range(-3, 6), (float)Random.Range(-3, 6), (float)Random.Range(-3, 6)), Quaternion.identity);
        
    }
    private void OnTriggerStay(Collider other)
    {
        other.GetComponent<Renderer>().material.color -= new Color32(0, 10, 0, 0);
        other.GetComponent<Renderer>().material.color += new Color32(10, 0, 0, 0);
        other.GetComponent<Transform>().position += new Vector3(Random.Range(-1, 3)*0.1f, Random.Range(-1, 3) * 0.1f, Random.Range(-1, 3) * 0.1f);
        if (other.GetComponent<Renderer>().material.color.r>=1)
        {
            Destroy(other.gameObject);
        }
    }
    private void OnTriggerExit(Collider other)
    {
        setime = 0;
       
    }
}
