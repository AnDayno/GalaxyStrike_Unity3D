using System;
using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerWeapon : MonoBehaviour
{
    [SerializeField] GameObject[] lasers;
    [SerializeField] RectTransform crosshair;

    bool isFiring = false;

    void Start()
    {
        Cursor.visible = false;
    }

    void Update()
    {
        processFiring();
        MoveCrosshair();
    }

    public void OnFire(InputValue value)
    {
        isFiring = value.isPressed;
    }

    private void processFiring()
    {
        foreach (GameObject laser in lasers)
        {
            var emissionModule = laser.GetComponent<ParticleSystem>().emission;
            emissionModule.enabled = isFiring;
        }
    }

    void MoveCrosshair()
    {
        crosshair.position = Mouse.current.position.ReadValue();
    }
}
