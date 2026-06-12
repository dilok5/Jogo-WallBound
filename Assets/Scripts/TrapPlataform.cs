using System.Collections;
using UnityEngine;

public class TrapPlataform : MonoBehaviour
{
    public GameObject explosionEfect;
    private Animator oAnimator;

    public float timeToOff;

    void Awake()
    {
        oAnimator = GetComponent<Animator>();
    }


    public void WhellCoroutineShutdownPlataform()
    {
        StartCoroutine(TurnOffPlataform());
    }

    private IEnumerator TurnOffPlataform()
    {
        oAnimator.Play("plataform-stop-animation");
        yield return new WaitForSeconds(timeToOff);
        Instantiate(explosionEfect, transform.position, transform.rotation);
        Destroy(this.gameObject);
    }
}
