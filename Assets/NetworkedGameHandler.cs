using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;

public class NetworkedGameHandler : NetworkBehaviour
{
    public GameObject CoinPrefab;
    public Transform CoinSpawnPoint;
    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();

       
        GameObject coinObj= Instantiate(CoinPrefab);





    }
    public override void OnNetworkDespawn()
    {
        base.OnNetworkDespawn();


    }





}
