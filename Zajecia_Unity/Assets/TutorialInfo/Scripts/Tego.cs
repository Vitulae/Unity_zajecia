using UnityEngine;
using DG.Tweening;



public class Tego : MonoBehaviour
{
    public Transform targetPosition;

    public float duration = 1f;
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            this.gameObject.transform.DOMove(targetPosition.position, duration);
        }
    }
}
