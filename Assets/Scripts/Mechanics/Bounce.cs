using UnityEngine;
using Platformer.Mechanics;

public class Bounce : MonoBehaviour
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
        player.velocity.y += 7;
    }
}
