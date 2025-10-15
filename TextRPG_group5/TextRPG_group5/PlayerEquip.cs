﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG_group5
{
    using TextRPG_group5.ItemManagement;
    internal class PlayerEquip
    {
    private GamePlayer.Player player;
    public Weapon? EquippedWeapon { get; private set; }
    public Armor? EquippedArmor { get; private set; }
    public PlayerEquip(GamePlayer.Player player)
    { this.player = player; }
    public void EquipItem(EquipItem item)
        {
            if(item is Weapon weapon)
            {
                if(EquippedWeapon != null)
                {
                    Console.WriteLine($"{EquippedWeapon.Name}을(를) 해제합니다.");
                    UnEquipItem(EquippedWeapon);
                }
                if(!IsJobMacth(weapon.Job))
                {
                    Console.WriteLine($"[{weapon.Name}]은(는) {weapon.Job} 전용 무기 입니다.");
                    return;
                }
                EquippedWeapon = weapon;
                player.Attack += weapon.AtkPower;
                ((GamePlayer.Player)player).Critical += weapon.CriPro / 100.0;
                weapon.IsEquip = true;
                Console.WriteLine($"{weapon.Name}을(를) 장착했습니다.");
            }
        }

    }
}
