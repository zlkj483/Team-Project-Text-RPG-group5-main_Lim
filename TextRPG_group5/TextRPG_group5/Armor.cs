﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TextRPG_group5.ItemManagement
{
    internal class Armor : EquipItem
    {
        public int DefPower { get; protected set; }

        public Class Job { get; protected set; }

        public bool isCorrect { get; protected set; }

        public Armor(string name, string description, int defPower, int price, int job, bool isEquip)
        {
            string jobLimits;

            Name = name;
            Job = (Class)job;
            if ((int)Job == 1)
            {
                jobLimits = "전사";
            }
            else if ((int)Job == 2)
            {
                jobLimits = "마법사";
            }
            else
            {
                jobLimits = "공용";
            }
            DefPower = defPower;
            Price = price;
            Description = $"스탯 증가량 => 방어력 : +{defPower}, 장착 가능 직업 : {jobLimits}";
            IsEquip = isEquip;
        }
        public override void YouEquipItem() // ToDo : 플레이어 메서드 오브젝트를 매개변수로 추가 필요
        {
            // 장비 장착 후 능력치 상승 로직 추가
        }
    }
}
