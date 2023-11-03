using System.Collections;
using System.Collections.Generic;
using System.Linq;
using Unity.Netcode;
using UnityEngine;

public class MGBLNetworkManager : NetworkManager
{
    #region Public Fields

    private NetworkObject m_SpawnedNetworkObject;
    private GameplayManagerIntilizer GameplayManagerIntilizer;
    #endregion

    #region MonoBehaviour Callbacks


    private void Awake()
    {
        GameplayManagerIntilizer=GetComponent<GameplayManagerIntilizer>();
        OnServerStarted += MGBLNetworkManager_OnServerStarted;
    }

    private void OnDestroy()
    {
        OnServerStarted -= MGBLNetworkManager_OnServerStarted;

    }
    //private void OnEnable()
    //{
    //    OnServerStarted += MGBLNetworkManager_OnServerStarted;
    //}



    //private void OnDisable()
    //{
    //    OnServerStarted -= MGBLNetworkManager_OnServerStarted;

    //}
    #endregion

    #region Action Methods
    private void MGBLNetworkManager_OnServerStarted()
    {


        Debug.Log("Server Started, Callback is initilized!");
       GameObject NetworkedGameManager = Instantiate(GameplayManagerIntilizer.GameplayManager);



        m_SpawnedNetworkObject = NetworkedGameManager.GetComponent<NetworkObject>();
        m_SpawnedNetworkObject.Spawn();



    }
    #endregion

}
