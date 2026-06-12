using UnityEngine;

public class SFXManager : MonoBehaviour
{
    public static SFXManager instance;
    public AudioSource soundOfCollection, damageSound, jumpSound;

    void Awake()
    {
        instance = this;
    }
}
