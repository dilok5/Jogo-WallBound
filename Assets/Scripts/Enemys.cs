using UnityEngine;

public class Enemys : MonoBehaviour
{
    [Header("Path of the Enemy")]
    public Transform[] pointsOnThePath;
    public int currentPoint;

    [Header("Enemy Movement")]
    public float enemySpeed;
    public float lastPositionX;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        currentPoint = 0;
        transform.position = pointsOnThePath[0].position;
    }

    // Update is called once per frame
    void Update()
    {
        MoveEnemy();
        MirrorEnemy();
    }

    private void MoveEnemy()
    {
        // Move o inimigo para o próximo ponto do array de currentPoint
        transform.position = Vector2.MoveTowards(transform.position, pointsOnThePath[currentPoint].position, enemySpeed * Time.deltaTime);

        // Veirfica se o inimigo chegou no ponto especificado
        if (transform.position == pointsOnThePath[currentPoint].position)
        {
            // Troca o próximo ponto de destino do inimigo
            currentPoint += 1;

            // Armazena a posição atual X do inimigo
            lastPositionX = transform.localPosition.x;

            // Verifica se o próximo ponto existe no array
            if(currentPoint >= pointsOnThePath.Length)
            {
                currentPoint = 0;
            }
        }
    
    }

    private void MirrorEnemy()
    {
        // Espelha o inimigo dependendo da sua direção
        if (transform.localPosition.x < lastPositionX)
        {
            GetComponent<SpriteRenderer>().flipX = false;
        }
        else if(transform.localPosition.x > lastPositionX)
        {
            GetComponent<SpriteRenderer>().flipX = true;
        }
    }

}
