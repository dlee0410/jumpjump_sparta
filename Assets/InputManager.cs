using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class InputManager : MonoSingleton<InputManager>
{
    protected Vector2 _movement = Vector2.zero;
    protected bool _isJump = false;

    public Vector2 Movement
    {
        get
        {
            return _movement;
        }
    }

    public bool IsJump
    {
        get
        {
            return _isJump;
        }
    }

    public virtual void SetMovement(Vector2 movement)
    {
        _movement.x = movement.x;
        _movement.y = movement.y;
    }

    public void StartJump()
    {
        if (_isJump)
        {
            return;
        }

        _isJump = true;
    }

    public void ClearJumpFlag()
    {
        if (!_isJump)
        {
            return;
        }

        _isJump = false;
    }
}