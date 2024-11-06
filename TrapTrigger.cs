using UnityEngine;

public class TrapTrigger : MonoBehaviour
{
    public GameObject spikes; // The spikes you want to activate
    public float riseHeight = 2f; // How high the spikes will move
    public float speed = 2f; // Speed of the spikes rising
    private Vector3 startPosition;
    private Vector3 endPosition;
    private bool activated = false;

    void Start()
    {
        startPosition = spikes.transform.position;
        endPosition = startPosition + Vector3.up * riseHeight;
    }

    void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player")) // Only trigger for the player
        {
            activated = true;
        }
    }

    void Update()
    {
        if (activated)
        {
            spikes.transform.position = Vector3.MoveTowards(spikes.transform.position, endPosition, speed * Time.deltaTime);
        }
    }
}