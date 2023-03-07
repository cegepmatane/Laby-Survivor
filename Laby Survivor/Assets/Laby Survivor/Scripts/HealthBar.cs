using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class HealthBar : MonoBehaviour
{
    GameObject _obj;
    public Player player;

    public InputActionReference triggerAction;

    // Start is called before the first frame update
    void Start()
    {
        //_obj = gameObject;
        //_obj.SetActive(false);
        Debug.Log("Healthbar lancée");
        triggerAction.action.performed += displayHP;
    }

    void displayHP(InputAction.CallbackContext context) {
        Debug.Log("Test affichage HP");
    }

    // Update is called once per frame
    void Update()
    {
        //bool pressed;
        /**leftHand.IsPressed(button, out pressed);
 
        if (pressed) {
            Debug.Log("Hello - " + button);
        }**/
    }
}
