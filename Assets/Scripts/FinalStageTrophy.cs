using UnityEngine;

public class FinalStageTrophy : MonoBehaviour
{
    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            FindAnyObjectByType<GameManager>().RunCoroutinePassTheStage();
        }
    }
}
