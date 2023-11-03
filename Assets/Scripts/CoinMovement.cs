using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;
using Unity.Netcode;

public class CoinMovement : NetworkBehaviour
{

    private void Start()
    {
        if (!IsServer) { return; }
        //TODO : SetEase eklenecek ve SetLoops açıklanacak.
        transform.DOLocalMoveY(1.5f, 1f).SetLoops(-1,LoopType.Yoyo);
        transform.DOLocalRotate(transform.forward,.5f).SetLoops(-1, LoopType.Incremental);
    }



}
