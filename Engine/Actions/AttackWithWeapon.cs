using Engine.Models;
using System;

namespace Engine.Actions
{
    public class AttackWithWeapon : BaseAction, IAction
    {
        private readonly int _maximumDamage;
        private readonly int _minimumDamage;

        public AttackWithWeapon(GameItem itemInUse, int minimumDamage, int maximumDamage)
            : base(itemInUse)
        {
            if (itemInUse.Category != GameItem.ItemCategory.Weapon)
            {
                throw new ArgumentException($"Item '{itemInUse.Name}' is not a weapon.");
            }

            if (minimumDamage < 0)
            {
                throw new ArgumentOutOfRangeException(nameof(minimumDamage), "Minimum damage must be 0 or larger.");
            }

            if (maximumDamage < minimumDamage)
            {
                throw new ArgumentException("Maximum damage must be greater than or equal to minimum damage.");
            }

            _minimumDamage = minimumDamage;
            _maximumDamage = maximumDamage;
        }

        public void Execute(LivingEntity actor, LivingEntity target)
        {
            try
            {
                int damage = RandomNumberGenerator.NumberBetween(_minimumDamage, _maximumDamage);
                string actorName = (actor is Player) ? "You" : $"The {actor.Name.ToLower()}";
                string targetName = (target is Player) ? "you" : $"the {target.Name.ToLower()}";
                if (damage == 0)
                {
                    ReportResult($"{actorName} missed {targetName}.");
                }
                else
                {
                    ReportResult($"{actorName} hit {targetName} for {damage} point{(damage > 1 ? "s" : "")}.");
                    target.TakeDamage(damage);
                }
            }
            catch (Exception ex)
            {
                // Log the exception for debugging or error reporting
                Console.WriteLine($"An error occurred during execution: {ex.Message}");
                // Optionally rethrow the exception if you want to propagate it further
                throw;
            }
        }
    }
}
