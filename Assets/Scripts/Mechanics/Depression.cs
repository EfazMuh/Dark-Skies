using UnityEngine;
using Platformer.Mechanics;

public class Depression : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        var rb = other.attachedRigidbody;
        if (rb == null) return;
        var player = rb.GetComponent<PlayerController>();
        if (player == null) return;
        AddVelocity(player);
    }

    void AddVelocity(PlayerController player)
    {
        player.maxSpeed = 1.5f;
        player.jumpTakeOffSpeed = 6f;
    }
}
