using UnityEngine;
using Platformer.Mechanics;
using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;

public class DLCDoor : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        var rb = other.attachedRigidbody;
        if (rb == null) return;
        var player = rb.GetComponent<PlayerController>();
        if (player == null) return;
        SceneManager.LoadScene(sceneName: "DLC");
    }
}
