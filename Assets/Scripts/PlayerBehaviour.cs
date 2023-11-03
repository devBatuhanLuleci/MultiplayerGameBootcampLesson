using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : NetworkBehaviour
{

    public Transform PlayerCameraRoot;
    private ThirdPersonController _characterController;
    private PlayerInput PlayerInput;




    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();

        PlayerInput = GetComponent<PlayerInput>();
        _characterController = GetComponent<ThirdPersonController>();
    

        if (IsClient && IsLocalPlayer)
        {
            PlayerInput.enabled = true;

            SetCameraForThisPlayer();



        }
        else if (IsClient && !IsLocalPlayer)
        {
            PlayerInput.enabled=false;

        }
    }

    public void SetCameraForThisPlayer()
    {

        CameraManager.Instance.Initilize(PlayerCameraRoot);


    }




}
