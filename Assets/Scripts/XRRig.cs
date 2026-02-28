using System;
using UnityEngine;
using UnityEngine.InputSystem.XR;

public class XRRig : MonoBehaviour
{
    [SerializeField] private Transform head;
    [SerializeField] private Transform leftHand;
    [SerializeField] private Transform rightHand;
    XRActions _actions;

    private void Awake()
    {
        _actions = new XRActions();
        _actions.Enable();
    }

    private void Update()
    {
        UpdateInput();
    }

    private void UpdateInput()
    {
        var headPosition = _actions.Actions.HeadPosition.ReadValue<Vector3>();
        var headRotation = _actions.Actions.HeadRotation.ReadValue<Quaternion>();
        var left = _actions.Actions.LeftPose.ReadValue<PoseState>();
        var right = _actions.Actions.RightPose.ReadValue<PoseState>();
        head.position = headPosition;
        head.rotation = headRotation;
        leftHand.position = left.position;
        leftHand.rotation = left.rotation;
        rightHand.position = right.position;
        rightHand.rotation = right.rotation;
    }
}
