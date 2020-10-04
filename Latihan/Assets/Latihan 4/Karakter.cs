using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Karakter : MonoBehaviour
{
    private string name;
    private int health;
    private int damage;

    public string Name
    {
        get
        {
            return name;
        }
        set
        {
            name = value;
        }
    }

    public int Health
    {
        get
        {
            return health;
        }
        set
        {
            health = value;
        }
    }
    public int Damage
    {
        get
        {
            return damage;
        }
        set
        {
            damage = value;
        }
    }
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }

    public void MoveLeft()
    {
        Debug.Log("Gerak ke kiri");
    }
    public void MoveRight()
    {
        Debug.Log("Gerak ke kekanan");
    }
    public void Jump()
    {
        Debug.Log("Loncat");
    }
    public void Attack()
    {
        Debug.Log("Serang");
    }
}
