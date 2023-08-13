using System.Collections;
using UnityEngine;

public class EnemyDetector : MonoBehaviour // NOTE : Does not handle multiple beast entering/exiting
{
    public bool EnemyInRange => _detectedBeast != null;

    private Beast _detectedBeast;
    
    private void OnTriggerEnter(Collider other)
    {
        if (other.GetComponent<Beast>())
        {
            _detectedBeast = other.GetComponent<Beast>(); 
        }
    }
    
    private void OnTriggerExit(Collider other)
    {
        if (other.GetComponent<Beast>())
        {
            StartCoroutine(ClearDetectedBeastAfterDelay());
        }
    }

    private IEnumerator ClearDetectedBeastAfterDelay()
    {
        yield return new WaitForSeconds(3f);
        _detectedBeast = null;
    }

    public Vector3 GetNearestBeastPosition()
    {
        return _detectedBeast?.transform.position ?? Vector3.zero;
    }
}