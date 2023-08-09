using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class ActivateTeleportRay : MonoBehaviour
{

    public GameObject leftTeleportion;
    public GameObject rightTeleportion;

    public InputActionProperty leftActivate;
    public InputActionProperty rightActivate;

    // Update is called once per frame
    void Update()
    {
        leftTeleportion.SetActive(leftActivate.action.ReadValue<float>() > 0.1f);
        rightTeleportion.SetActive(rightActivate.action.ReadValue<float>() > 0.1f);
    }
}
