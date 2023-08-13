using UnityEngine;

public class WoodDropper : MonoBehaviour
{
    [SerializeField] private GatherableResource _prefab;
    public void Drop(int gathered, Vector3 position)
    {
        var resource = Instantiate(_prefab, position, Quaternion.identity);
        resource.SetAvailable(gathered);
    }
}