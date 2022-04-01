using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyMovementBehaviour : MovementBehaviour
{
    [SerializeField]
    private Transform _target;
    [SerializeField]
    private float _speed;
    [SerializeField]
    private float _damage;

    public float Speed
    {
        get { return _speed; }
        set { _speed = value; }
    }


    public Transform Target
    {
        get { return _target; }
        set { _target = value; }
    }

    public override void Update()
    {
        Vector3 direction = _target.position - transform.position;
        Velocity = direction.normalized * Speed;

        base.Update();
    }

    private void OnTriggerEnter(Collider other)
    {
        if (other.transform == _target)
        {
            //Increment the enemy count if the target was a goal
            GoalBehavior goalHealth = other.GetComponent<GoalBehavior>();
            if (goalHealth)
                goalHealth.TakeDamage(_damage);
            //Destroy this enemy
            Destroy(gameObject);
        }
    }

    private void OnMouseDown()
    {
        Destroy(gameObject);
    }
}
