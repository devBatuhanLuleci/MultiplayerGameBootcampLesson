using StarterAssets;
using System.Collections;
using System.Collections.Generic;
using Unity.Netcode;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerBehaviour : NetworkBehaviour
{

    private ThirdPersonController _characterController;
    //private AnimationController _animationController;
    private PlayerInput PlayerInput;

    

  
    public override void OnNetworkSpawn()
    {
        base.OnNetworkSpawn();

        PlayerInput = GetComponent<PlayerInput>();
        _characterController = GetComponent<ThirdPersonController>();
        //_animationController = GetComponent<AnimationController>();

        if (IsClient && IsLocalPlayer)
        {
            PlayerInput.enabled = true;

            Debug.Log("Hello World");

        }
        else if (IsClient && !IsLocalPlayer)
        {
            PlayerInput.enabled=false;

        }
    }

    //private void SetAnimationSpeed()
    //{

    //   _characterController.SetAnimationSpeed(_animationController.GetAverageThresholdValue());


    //}


}
