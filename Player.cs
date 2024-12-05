using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Strategy_Pattern
{
    public class Player
    {
        private IWeapon _currentWeapon;

        public Player(IWeapon initialWeapon)
        {
            _currentWeapon = initialWeapon;
        }

        public void SetWeapon(IWeapon weapon)
        {
            _currentWeapon = weapon;
            Console.WriteLine("Оружие изменено.");
        }

        public void Attack()
        {
            if (_currentWeapon != null)
            {
                _currentWeapon.UseWeapon();
            }
            else
            {
                Console.WriteLine("Оружие не выбрано.");
            }
        }
    }
}
