using System.Collections;
using UnityEngine;

public class PlayerLife : MonoBehaviour
{
    [Header("References")]
    public GameObject explosionEfect;
    private Rigidbody2D oRigidbody2D;
    private Animator oAnimator;

    [Header("Values")]
    public float timeForDestroyPlayer;

    void Awake()
    {
        oRigidbody2D = GetComponent<Rigidbody2D>();
        oAnimator = GetComponent<Animator>();
    }

    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void HurtPlayer()
    {
        SFXManager.instance.damageSound.Play();
        FindAnyObjectByType<PlayerMovement>().playerIsAlive = false;
        oRigidbody2D.linearVelocity = Vector2.zero;
        oAnimator.Play("player-taking-damage");

        StartCoroutine(DestroyPlayer());
    }

    private IEnumerator DestroyPlayer()
    {
        yield return new WaitForSeconds(timeForDestroyPlayer);
        FindAnyObjectByType<GameManager>().GameOver();
        GameManager.score = 0; 
        Instantiate(explosionEfect, transform.position, transform.rotation);
        Destroy(gameObject);
    }
}
