using UnityEngine;

public class DangerLight : MonoBehaviour
{
    public Light targetLight;
    public Transform player;

    public float safeIntensity = 0.5f;
    public float dangerIntensity = 3f;
    public float maxDistance = 10f;
    public float lerpSpeed = 2f;

    void Update()
    {
        if (targetLight == null || player == null)
            return;

        float distance = Vector3.Distance(transform.position, player.position);

        float t = Mathf.Clamp01(1f - (distance / maxDistance));
        float targetIntensity = Mathf.Lerp(safeIntensity, dangerIntensity, t);

        targetLight.intensity = Mathf.Lerp(
            targetLight.intensity,
            targetIntensity,
            Time.deltaTime * lerpSpeed
        );
    }
}
