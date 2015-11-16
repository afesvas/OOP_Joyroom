using UnityEngine;
using System.Collections;

public struct Stat {
    public int health;
    public int charm;
    public int gpa;
    public Stat(int health, int charm, int gpa)
    {
        this.health = health;
        this.charm = charm;
        this.gpa = gpa;
    }
    public void SetStat(int health, int charm, int gpa)
    {
        this.health = health;
        this.charm = charm;
        this.gpa = gpa;
    }
    public void UpdateStat(Stat stat)
    {
        this.health += stat.health;
        this.charm += stat.charm;
        this.gpa += stat.gpa;
    }
}
