using UnityEngine;

public class Monster : MonoBehaviour
{
    public AudioClip clip;

    private void OnTriggerEnter(Collider other)
    {
        Managers.Sound.Play(Define.Sound.Effect, "univ0001");
    }
}
