﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerKeyboardMouse : PlayerController
{
    #region GetInputs
    protected override void GetInputs()
    {
        Vector2 mouseScreenPos = Input.mousePosition;
        Vector2 mouseWorldPos = Camera.main.ScreenToWorldPoint(new Vector3(mouseScreenPos.x, mouseScreenPos.y, Mathf.Abs(transform.position.z - Camera.main.transform.position.z)));
        movementDirection = mouseWorldPos - (Vector2)(transform.position);

        float cumulativeThrust = 0f;
        if (Input.GetKey(KeyCode.W) || Input.GetKey(KeyCode.Space) || Input.GetKey(KeyCode.UpArrow))
        {
            cumulativeThrust += thrust;
        }
        if (Input.GetKey(KeyCode.S) || Input.GetKey(KeyCode.DownArrow))
        {
            cumulativeThrust -= thrust;
        }

        thrustingForce = cumulativeThrust;

        if (Input.GetMouseButtonDown(0))
        {
            Shoot();
        }
    }
    #endregion
}