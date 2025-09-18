using UnityEngine;

public class CollisionHandler : MonoBehaviour
{
    [SerializeField] GameObject playerDestroyedVFX;
    private void OnTriggerEnter(Collider other)
    {
        Instantiate(playerDestroyedVFX, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }
}
