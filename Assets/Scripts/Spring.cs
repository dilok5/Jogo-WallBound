using UnityEngine;

public class Spring : MonoBehaviour
{
    private Animator oAnimator;
    public float springForce;

    void Awake()
    {
        oAnimator = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SFXManager.instance.jumpSound.Play();
            oAnimator.Play("spring-going-up-animation");
            other.gameObject.GetComponent<PlayerMovement>().BoostPlayer(springForce);
        }
    }
}
