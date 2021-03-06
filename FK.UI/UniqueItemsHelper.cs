﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FK.UI
{

    public class UniqueItem
    {
        public string ItemName { get; set; }
        public UniqueItemType LegendaryItemType { get; set; }
        public string Override { get; set; }
    }

    public enum UniqueItemType
    {
        NotUsedTransmogOrConsole = -1,
        Amulet = -365243096,
        Axe_1H = 109694,
        Axe_2H = 119458520,
        Belt = 3635495,
        Belt_Barbarian = -479768568,
        Belt_Crusader = -1029603201,
        Belt_DemonHunter = 9087215,
        Belt_Monk = 1555631483,
        Belt_WitchDoctor = 994235600,
        Belt_Wizard = -2044734313,
        BloodShard = 1932948546,
        Boots = 120334087,
        Boots_Barbarian = -2097752600,
        Boots_Crusader = -1989686689,
        Boots_DemonHunter = -1038932273,
        Boots_Monk = 1931831131,
        Boots_WitchDoctor = -53783888,
        Boots_Wizard = -385210761,
        Bow = 110504,
        Bracer = -1999984446,
        Bracers_Barbarian = 1143143779,
        Bracers_Crusader = 60780154,
        Bracers_DemonHunter = 2129074442,
        Bracers_Monk = 1160852982,
        Bracers_WitchDoctor = -1180744469,
        Bracers_Wizard = 1833174994,
        CeremonialDagger = -199811863,
        Chest_Armor = -1028103400,
        ChestArmor_Barbarian = -1289348295,
        ChestArmor_Crusader = -1054135920,
        ChestArmor_DemonHunter = -1154939808,
        ChestArmor_Monk = 1667159564,
        ChestArmor_WitchDoctor = -169791423,
        ChestArmor_Wizard = -849738392,
        Cloak = 121411562,
        CombatStaff = -1620551894,
        Plan_Jeweler = 371712870,
        Plan_Mystic = 1323615825,
        Plan_MysticTransmog = 1295639964,
        Plan_Smith = -1515023331,
        PlanGeneric = 185803478,
        PlanLegendary = -1323275628,
        PlanLegendary_Smith = -1669219336,
        Crossbow = -1338851342,
        CrusaderShield = 602099538,
        Dagger = -262576534,
        Demonic_KeyP2 = -2019730316,
        Demonic_Key = -1979915768,
        Demonic_Organ = -49494186,
        EnchantressSpecial = -464307745,
        Fist_Weapon = -2094596416,
        Flail_1H = -1363671135,
        Flail_2H = -1363671102,
        FollowerSpecial = 1637769035,
        Gem = 115609,
        GenericBelt = -948083356,
        GenericBowWeapon = 395678127,
        GenericChestArmor = 828360981,
        GenericHelm = -947867741,
        GenericOffHand = 344906995,
        GenericRangedWeapon = 165564792,
        GenericSwingWeapon = 1846932879,
        GenericThrustWeapon = 998499313,
        Gloves = -131821392,
        Gloves_Barbarian = 444212945,
        Gloves_Crusader = 299901480,
        Gloves_DemonHunter = 1202607608,
        Gloves_Monk = 922698404,
        Gloves_WitchDoctor = -2107211303,
        Gloves_Wizard = 180877312,
        GreaterShard = 1331402556,
        HandXbow = 763102523,
        HealthPotion = -1916071921,
        Helm = 3851110,
        Helm_Barbarian = -1587563257,
        Helm_Crusader = -2104376930,
        Helm_DemonHunter = 506481070,
        Helm_Monk = 122656538,
        Helm_WitchDoctor = 1491629455,
        Helm_Wizard = 813646326,
        Pants = 3994699,
        Legs_Barbarian = -1177810900,
        Legs_Crusader = 1031652387,
        Legs_DemonHunter = 50199059,
        Legs_Monk = 1717378847,
        Legs_WitchDoctor = 1035347444,
        Legs_Wizard = -1995514053,
        Mace_1H = 4026134,
        Mace_2H = 89494384,
        Melee = 133016072,
        MightyWeapon_1H = -1488678091,
        MightyWeapon_2H = -1488678058,
        Mojo = 4041621,
        MysteryWeapon_1H = -241705760,
        MysteryWeapon_2H = -241705727,
        Gift = -1380314094,
        Offhand = -720431272,
        Orb = 124739,
        Polearm = -1203595600,
        Potion = 224120761,
        PowerPotion = -910124122,
        Quiver = 269990204,
        Ring = 4214896,
        ScoundrelSpecial = -953512528,
        Shard = 140227858,
        Shield = 332825721,
        Shoulders = -940830407,
        Shoulders_Barbarian = 1212065434,
        Shoulders_Crusader = 62868689,
        Shoulders_DemonHunter = -124654591,
        Shoulders_Monk = -821460787,
        Shoulders_WitchDoctor = 860493794,
        Shoulders_Wizard = -832936855,
        Spear = 140519163,
        Spirit_Stone = 576647032,
        Staff = 140658708,
        Swing = 140775496,
        Sword_1H = 140782159,
        Sword_2H = -1307049751,
        TemplarSpecial = 129668150,
        TreasureBag = 1650316949,
        Wand = 4385866,
        Wizard_Hat = -1499089042,
        Voodoo_Mask = -333341566,
        LegendaryGem = 1888008307,
        /* Not sure about*/
    }
}
