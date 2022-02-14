using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Unity.Netcode;

public class ObjectSpawner : NetworkBehaviour
{
    [SerializeField] GameObject spawnPrefab;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    

    // Update is called once per frame
    void Update()
    {
        
    }

    void SpawnObject()
    {
        if (IsServer)
        {
            GameObject go = Instantiate(spawnPrefab);
            NetworkObject no = go.GetComponent<NetworkObject>();
            no.Spawn();
        }
    }
}
