using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class NetworkedGameManager : NetworkBehaviour
{
    public GameObject SpawnablePrefab;
    public Transform SpawnPoint;
    private NetworkObject m_SpawnedNetworkObject;


    public override void OnNetworkSpawn()
    {
        if (!IsServer) { return; }



        base.OnNetworkSpawn();

        Debug.Log("NetworkedGameManager is spawned.");

        GameObject coinObj = Instantiate(SpawnablePrefab, SpawnPoint);



        m_SpawnedNetworkObject = coinObj.GetComponent<NetworkObject>();
        m_SpawnedNetworkObject.Spawn();
    }







}
