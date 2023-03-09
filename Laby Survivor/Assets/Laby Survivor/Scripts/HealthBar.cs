using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR;
using UnityEngine.UI;
using UnityEngine.XR.Interaction.Toolkit;
using UnityEngine.InputSystem;

public class HealthBar : MonoBehaviour
{
    GameObject _obj;
    public Player player;

    bool hpDisplayActive;
    public Image barFill;

    public InputActionReference triggerAction;

    // Start is called before the first frame update
    void Start()
    {
        _obj = gameObject;
        _obj.SetActive(false);
        hpDisplayActive = false;
        triggerAction.action.performed += displayHP;
    }

    void displayHP(InputAction.CallbackContext context) {
        barFill.fillAmount = player.health / player.getMaxHP();
        hpDisplayActive = !hpDisplayActive;
        _obj.SetActive(hpDisplayActive);
    }

    // Update is called once per frame
    void Update()
    {

    }
}
