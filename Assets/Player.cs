using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

public class Player : MonoBehaviour
{
    [SerializeField] InputActionAsset actionAsset;
    InputActionMap rightHandMap;
    InputAction selectAction;
    InputAction activateAction;

    private void Awake()
    {
        rightHandMap = actionAsset.FindActionMap("XRI RightHand Interaction");
        selectAction = rightHandMap.FindAction("Select");
        activateAction = rightHandMap.FindAction("Activate");
    }

    private void Update()
    {
        if(selectAction.IsPressed())
        {
            print("Grip");
        }

        if(activateAction.IsPressed())
        {
            print("Trigger");
        }
    }
}
