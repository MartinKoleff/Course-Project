﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RPGGame.Champions.Enemies
{
    internal class Werewolf : Enemy
    {
        public Werewolf()
        {
            hp = 110;
            damage = 15;
            damageMultiplier = 1;
            defense = 25;
            luck = 10;
            type = Type.WEREWOLF;

            if (MainWindow.GetGameWindow().enemyIsScaling)
            {
                this.Scale();
            }
        }

        public override void Attack()
        {
            base.Attack();
        }

        public override void Scale()
        {
            base.Scale();
        }
    }
}
