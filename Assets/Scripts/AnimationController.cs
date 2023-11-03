using System.Collections;
using System.Collections.Generic;
//using UnityEditor.Animations;
using UnityEngine;

public class AnimationController : MonoBehaviour
{
    private Animator _animator;

    void Start()
    {
        // Get the Animator component attached to the game object
        _animator = GetComponent<Animator>();

        if (_animator == null)
        {
            Debug.LogError("Animator component not found.");
        }
    }
    //public float GetAverageThresholdValue()
    //{
    //    var thresholdValue=0f;
    //    int layerIndex = 0; // Change this to the appropriate layer index

    //    // Ensure that the layer index is valid
    //    if (layerIndex < _animator.layerCount)
    //    {

    //        // Access the Animator Controller for the specified layer
    //        AnimatorController controller = _animator.runtimeAnimatorController as AnimatorController;

    //        if (controller != null)
    //        {
    //            // Access the layer's state machine
    //            AnimatorStateMachine stateMachine = controller.layers[layerIndex].stateMachine;

    //            if (stateMachine != null)
    //            {
    //                // Access the default state's motion (which should be a blend tree)
    //                Motion motion = stateMachine.defaultState.motion;

    //                if (motion is BlendTree blendTree)
    //                {
    //                    // Read the max threshold value from the blend tree
    //                 var averageThresholdValue= (blendTree.minThreshold+ blendTree.maxThreshold)/2f;
    //                    thresholdValue = averageThresholdValue;
    //                    //float maxThreshold = blendTree.maxThreshold;
    //                    Debug.Log("Average Threshold: " + averageThresholdValue);
    //                }


    //            }

    //        }
    //    }
    //    else
    //    {
    //        Debug.LogError("Invalid layer index.");
    //    }
    //    return thresholdValue;
    //}
  
}