using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [Header("Set Inspector: Enemy")]
    public float speed = 10f;       // —корость в м/с
    public float fireRate = 0.3f;   // —екунд мужду выстрелами
    public float health = 10;
    public int score = 100;         // ќчки за уничтожение этого корабл€

    // Ёто свойство: метод, действующий как поле
    public Vector3 pos
    {
        get
        {
            return (this.transform.position);
        }
        set
        {
            this.transform.position = value;
        }
    }

    void Update()
    {
        Move();
    }

    public virtual void Move()
    { 
        Vector3 tempPos = pos;
        tempPos.y -= speed * Time.deltaTime;
        pos = tempPos;
    }

}
