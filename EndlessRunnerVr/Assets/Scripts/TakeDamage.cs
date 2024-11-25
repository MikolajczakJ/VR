using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering.PostProcessing;

public class TakeDamage : MonoBehaviour
{
    public float intensity = 0;
    private bool isTakingDamage = false;
    PostProcessVolume _volume;
    UnityEngine.Rendering.PostProcessing.Vignette _vignette;
    // Start is called before the first frame update
    void Start()
    {
        _volume = GetComponent<PostProcessVolume>();
        _volume.profile.TryGetSettings<Vignette>(out _vignette);
        if (_vignette != null)
        {
            _vignette.enabled.Override(false);
        }
    }
    public void TriggerDamage()
    {
        isTakingDamage = true; Debug.Log("Damage triggered");
    }
    // Update is called once per frame
    void Update()
    {
        if (isTakingDamage)
        {
            Debug.Log("Update detected damage");
            isTakingDamage = false;
            StartCoroutine(TakeDamageEffect());
        }

    }
    public IEnumerator TakeDamageEffect()
    {
        intensity = 0.4f;
        _vignette.enabled.Override(true);
        _vignette.intensity.Override(intensity);
        yield return new WaitForSeconds(0.4f);
        while (intensity > 0)
        {
            intensity -= 0.01f;
            if(intensity < 0) intensity = 0;
            _vignette.intensity.Override(intensity);
            yield return new WaitForSeconds(0.1f);
        }
        _vignette.enabled.Override(false);
        yield break;
    }
}
