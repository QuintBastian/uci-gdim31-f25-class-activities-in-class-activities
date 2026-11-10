using UnityEngine;

// Write the BatW6 class here.

public class BatW6 : MonoBehaviour
{
    [SerializeField] float speed = 5f;
    [SerializeField] GameObject player;
    private Transform playerTransform;
    private bool chasing = false;
    public void start_chasing()
    {
        chasing = true;
    }

    public void stop_chasing()
    {
        chasing = false;
    }

    void Start()
    {
        playerTransform = player.GetComponent<Transform>();
    }

    void Update()
    {
        if (chasing)
        {
            transform.position = Vector3.MoveTowards(transform.position, playerTransform.position, speed * Time.deltaTime);
        }
    }
}
