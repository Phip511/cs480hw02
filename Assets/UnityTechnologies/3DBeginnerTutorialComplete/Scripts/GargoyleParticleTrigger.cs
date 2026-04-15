using UnityEngine;

public class GargoyleParticleTrigger : MonoBehaviour
{
    public Transform player;
    public ParticleSystem particleEffect;
    public float triggerDistance = 5f;

    private bool hasPlayed = false;

    void Update()
    {
        if (player == null || particleEffect == null)
            return;

        float distance = Vector3.Distance(transform.position, player.position);

        if (distance <= triggerDistance)
        {
            if (!hasPlayed)
            {
                particleEffect.Play();
                hasPlayed = true;
            }
        }
        else
        {
            hasPlayed = false;
        }
    }
}
