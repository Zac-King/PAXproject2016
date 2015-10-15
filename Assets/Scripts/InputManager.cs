using UnityEngine;
using System;
using System.Collections;
using System.Collections.Generic;

public class InputManager : MonoBehaviour
{
    [Serializable]
    Dictionary<PlayerInputs, KeyboardInput> _inputs;

    [SerializeField]
    private KeyboardInput _forward  = KeyboardInput.W;
    [SerializeField]
    private KeyboardInput _backward = KeyboardInput.S;
    [SerializeField]
    private KeyboardInput _left     = KeyboardInput.A;
    [SerializeField]
    private KeyboardInput _right    = KeyboardInput.D;
    [SerializeField]
    private KeyboardInput _jump     = KeyboardInput.SPACE;

    void Recieve(char input)
    {

    }



    void OnMoveForward()
    {

    }

    void OnMoveRight()
    {

    }

    void OnMoveLeft()
    {

    }

    void OnMoveBackward()
    {

    }

    void OnJump()
    {

    }
}

enum PlayerInputs
{
    MOVE_FORWARD,
    MOVE_RIGHT,
    MOVE_LEFT,
    MOVE_BACKWARD,
    JUMP
}

enum KeyboardInput
{
    A,
    B,
    C,
    D,
    E,
    F,
    G,
    H,
    I,
    J,
    K,
    L,
    M,
    N,
    O,
    P,
    Q,
    R,
    S,
    T,
    U,
    V,
    W,
    X,
    Y,
    Z,
    ARROW_UP,
    ARROW_LEFT,
    ARROW_DOWN,
    ARROW_RIGHT,
    SPACE,
    ESCAPE,
    SHIFT,
    NUM_LOCK,
    SCROLL_LOCK,
    CAP_LOCK,
    Num_0,
    Num_1,
    Num_2,
    Num_3,
    Num_4,
    Num_5,
    Num_6,
    Num_7,
    Num_8,
    Num_9,
    F1,
    F2,
    F3,
    F4,
    F5,
    F6,
    F7,
    F8,
    F9,
    F10,
    F11,
    F12
}
