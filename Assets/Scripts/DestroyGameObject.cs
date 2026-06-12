using UnityEngine;

public class DestroyGameObject : MonoBehaviour
{
    public float timeOfLife;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        Destroy(this.gameObject, timeOfLife);
    }
}
