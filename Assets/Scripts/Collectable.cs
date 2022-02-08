using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class Collectable : NetworkBehaviour
{
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
        if (IsServer && transform.parent != other.transform && other.CompareTag("Player"))
        {
            transform.parent = other.transform; 
        }
    }
}
