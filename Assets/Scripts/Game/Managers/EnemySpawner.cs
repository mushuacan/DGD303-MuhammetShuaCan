using UnityEngine;

public class GameManager : MonoBehaviour
{
    [SerializeField] private MultiObjectPool objectPool;

    void Start()
    {
        // "Enemy" anahtarına sahip nesneyi al ve pozisyonla
        GameObject enemy = objectPool.GetObject("Enemy");
        if (enemy != null)
        {
            enemy.transform.position = new Vector3(0, 0, 0);
        }

        // "Bullet" anahtarına sahip nesneyi al ve pozisyonla
        GameObject bullet = objectPool.GetObject("Bullet");
        if (bullet != null)
        {
            bullet.transform.position = new Vector3(1, 1, 0);
        }
    }
}
