using Cinemachine;
using UnityEngine;

public class CameraManager : Singleton<CameraManager> 
{
    private CinemachineVirtualCamera _cinemachineVirtualCamera;



    protected override void Awake()
    {
        base.Awake();

        _cinemachineVirtualCamera = GetComponent<CinemachineVirtualCamera>();




    }
    public void Initilize(Transform target)
    {

        SetFollowOfCamera(target);


    }
    public void SetFollowOfCamera(Transform target)
    {
   
        _cinemachineVirtualCamera.Follow = target;

    }




}
