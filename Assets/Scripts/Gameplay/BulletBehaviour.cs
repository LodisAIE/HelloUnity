using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BulletBehaviour : MonoBehaviour
{
    private string _ownerTag;
    [SerializeField]
    private float _damage;

    public string OwnerTag
    {
        get { return _ownerTag; }
        set { _ownerTag = value; }
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.tag == OwnerTag)
            return;

        HealthBehaviour otherHealth = other.GetComponent<HealthBehaviour>();

        if (!otherHealth)
            return;

        otherHealth.TakeDamage(_damage);
    }
}
