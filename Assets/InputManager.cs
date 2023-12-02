using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InputManager : MonoBehaviour {
    public static InputManager Instance { get; set; }

    [SerializeField] private CharacterMovement characterMovement;
    [SerializeField] private FixedJoystick joystick;

    void Awake() {
        if (Instance != null) {
            Debug.LogError("<b>Input Manager:</b> Already Instantiated, Destroying Current instance");
            Destroy(this);
            return;
        }

        Instance = this;
    }


    void Update() {
        Debug.Log($"<b><color=yellow>{joystick.Vertical} | {joystick.Horizontal}<color></b>");

        // Controlling the player
        characterMovement.Forward(joystick.Vertical);
        characterMovement.Right(joystick.Horizontal);
    }
}
