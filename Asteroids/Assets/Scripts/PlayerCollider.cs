﻿using UnityEngine;

public class PlayerCollider : MonoBehaviour {

    #region Private attributes
    PlayerManager playerManager;
    #endregion

    #region Start
    private void Start()
    {
        playerManager = GetComponentInParent<PlayerManager>();
    }
    #endregion

    #region Collisions
    private void OnTriggerEnter(Collider other)
    {
        if (!playerManager.IsDead() && !playerManager.IsSpawning() && other.gameObject.tag == "Asteroid")
        {
            playerManager.Die();
        }
    }
    #endregion
}
