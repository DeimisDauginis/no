using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject Point;
    public GameObject SmallBall;
    public GameObject MediumSBall;
    public GameObject MediumBall;

    public Vector2 PointerPosition;

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.Mouse0))
        {
            PointerPosition = Point.transform.position;
            SpawnBall();
        }
    }

    public void SpawnBall()
    {
        float rndFloat = Random.Range(0f, 100f);
        Vector2 spawnPosition = new Vector3(PointerPosition.x, PointerPosition.y);

        if (rndFloat <= 60f)
        {
            Instantiate(SmallBall, spawnPosition, Quaternion.identity);
        }
        else if (rndFloat <= 85f)
        {
            Instantiate(MediumSBall, spawnPosition, Quaternion.identity);
        }
        else
        {
            Instantiate(MediumBall, spawnPosition, Quaternion.identity);
        }
    }
}
