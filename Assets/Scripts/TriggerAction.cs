using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TriggerAction : MonoBehaviour

{
    public GameObject esfera;
    public bool duplicador;
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
        if (other.gameObject.CompareTag("Player"))
        {
            if (duplicador)
            {
                GameObject estaesfera = Instantiate(esfera);
                estaesfera.SetActive(true);
            }
            else
            {
                esfera.SetActive(true);
            }
            
        }

    }
}
