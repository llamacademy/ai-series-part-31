using UnityEngine;

public class Collectable : MonoBehaviour
{
    [SerializeField]
    private Vector3 SpinAmount = new Vector3(0, 20, 0);
    public CollectableSpawner Spawner;

    void Update()
    {
        transform.rotation = Quaternion.Euler(transform.rotation.eulerAngles + (SpinAmount * Time.deltaTime));
    }

    private void OnTriggerEnter(Collider other)
    {
        Destroy(gameObject);
        Spawner.SpawnNewObject();
    }
}
