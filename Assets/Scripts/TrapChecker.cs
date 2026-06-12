using UnityEngine;

public class TrapChecker : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.GetComponent<TrapPlataform>())
        {
            other.gameObject.GetComponent<TrapPlataform>().WhellCoroutineShutdownPlataform();
        }
    }
}
