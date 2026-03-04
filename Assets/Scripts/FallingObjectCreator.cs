using System.Collections;
using Unity.VisualScripting;
using UnityEngine;
public class FallingObjectCreator : MonoBehaviour
{
    [SerializeField] private GameObject objectPrefab;
    [SerializeField] private float objectTime;
    [SerializeField] private float objectHigh;

    private GameObject currentObject = null;
    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag("Player"))
        {
            currentObject = GameObject.Instantiate(objectPrefab, other.transform.position + new Vector3(0, objectHigh), Quaternion.identity);
            if (currentObject != null)
            {
                StartCoroutine(Delete(currentObject));
            }
        }
    }


    IEnumerator Delete(GameObject Object)
    {
        yield return new WaitForSeconds(objectTime);
        Destroy(Object);
    }
}
