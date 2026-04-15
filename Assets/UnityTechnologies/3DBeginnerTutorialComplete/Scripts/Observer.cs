using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Observer : MonoBehaviour
{
    public Transform player;
    public GameEnding gameEnding;

    [Range(-1f, 1f)]
    public float viewThreshold = 0.5f;

    bool m_IsPlayerInRange;

    void OnTriggerEnter(Collider other)
    {
        if (other.transform == player)
        {
            m_IsPlayerInRange = true;
        }
    }

    void OnTriggerExit(Collider other)
    {
        if (other.transform == player)
        {
            m_IsPlayerInRange = false;
        }
    }

    void Update()
    {
        if (!m_IsPlayerInRange)
            return;

        // Direction to player
        Vector3 directionToPlayer = player.position - transform.position;
        directionToPlayer.Normalize();

        // Dot product (is player in front?)
        float dot = Vector3.Dot(transform.forward, directionToPlayer);

        if (dot < viewThreshold)
            return;

        // Raycast for line of sight
        Vector3 rayDirection = player.position - transform.position + Vector3.up;
        Ray ray = new Ray(transform.position, rayDirection);
        RaycastHit raycastHit;

        if (Physics.Raycast(ray, out raycastHit))
        {
            if (raycastHit.collider.transform == player)
            {
                gameEnding.CaughtPlayer();
            }
        }
    }
}
