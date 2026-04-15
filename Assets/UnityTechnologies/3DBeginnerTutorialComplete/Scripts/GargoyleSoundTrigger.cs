using UnityEngine;

public class GargoyleSoundTrigger : MonoBehaviour
{
    public Transform player;
    public AudioSource audioSource;
    public float triggerDistance = 5f;

    private bool hasPlayed = false;

    void Update()
    {
        if (player == null || audioSource == null)
            return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= triggerDistance)
        {
            if (!hasPlayed)
            {
                audioSource.Play();
                hasPlayed = true;
            }
        }
        else
        {
            hasPlayed = false;
        }
    }
}