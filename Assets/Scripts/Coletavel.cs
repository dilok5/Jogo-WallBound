using UnityEngine;

public class Coletavel : MonoBehaviour
{
    public GameObject efeitoDeExplosão;

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            SFXManager.instance.soundOfCollection.Play();
            Instantiate(efeitoDeExplosão, transform.position, transform.rotation);
            Destroy(this.gameObject);
            GameManager.score += 1;
        }
    }
}
