using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

[RequireComponent(typeof(Animator))]
public class AnimateHandController : MonoBehaviour

    
    
{
    public InputActionReference gripInputActionReference;
    public InputActionReference triggerInputActionReference;

    private Animator _handanimator;
    private float _gripValue;
    private float _triggerValue;
    // Start is called before the first frame update
    private void Start()
    {
        _handanimator = GetComponent<Animator>();
        
    }


    // Update is called once per frame
    private void Update()
    {
        AnimateGrip();
        AnimateTrigger();
        
    }

    private void AnimateGrip()
    {
        _gripValue = gripInputActionReference.action.ReadValue<float>();
        _handanimator.SetFloat("Grip", _gripValue);
    }

    private void AnimateTrigger()
    {
        _triggerValue = triggerInputActionReference.action.ReadValue<float>();

        _handanimator.SetFloat("Trigger", _triggerValue);
    }
}
