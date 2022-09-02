﻿namespace Assignment5
{
    public enum RaceCategory { Elf, Orc, Human }
    public class Character
    {
        public string Name { get; set; }
        public RaceCategory Race { get; set; }
        public int Health { get; set; }
        public bool IsAlive { get; set; }
        public int MaxHealth { get; set; }

        /// <summary>
        /// Default Constructor
        /// </summary>
        public Character()
        {
        }

        /// <summary>
        /// Constructor
        /// </summary>
        /// <param name="name"></param>
        /// <param name="race"></param>
        /// <param name="hp"></param>
        public Character(string name, RaceCategory race, int hp)
        {
            MaxHealth = hp;
            Health = hp;
            Race = race;
            Name = name;
            IsAlive = true;
        }

        /// <summary>
        /// Reduce the health by the damage specified to character
        /// if the damage taken is more than the health then the IsAlive is set to false.
        /// </summary>
        /// <param name="damage">The amount of damage taken</param>
        public void TakeDamage(int damage)
        {
            Health -= damage;

            if (Health <= 0)
            {
                IsAlive = false;
            }
        }

        /// <summary>
        /// Restore the health of the player by the amount specified up to the max health.
        /// </summary>
        /// <param name="amount">The amount of health to recover</param>
        public void RestoreHealth(int amount)
        {
            if (Health + amount > MaxHealth)
            {
                Health = MaxHealth;
            }
            else
            {
                Health += amount;
            }

            if (Health > 0)
            {
                IsAlive = true;
            }
        }

        public override string ToString()
        {
            return string.Format($"{Name} : {Race} - HP {Health}/{MaxHealth}");
        }
    }
}
