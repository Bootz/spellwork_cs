﻿using System;

namespace SpellWork
{
    public enum LocalesDBC
    {
        enUS,
        koKR,
        frFR,
        deDE,
        zhCN,
        zhTW,
        esES,
        esMX,
        ruRU
    };

    /// <summary>
    ///
    /// </summary>
    public enum SpellFamilyNames
    {
        SPELLFAMILY_GENERIC                                 = 0,
        SPELLFAMILY_UNK1                                    = 1, // events, holidays
        // unused                                           = 2,
        SPELLFAMILY_MAGE                                    = 3,
        SPELLFAMILY_WARRIOR                                 = 4,
        SPELLFAMILY_WARLOCK                                 = 5,
        SPELLFAMILY_PRIEST                                  = 6,
        SPELLFAMILY_DRUID                                   = 7,
        SPELLFAMILY_ROGUE                                   = 8,
        SPELLFAMILY_HUNTER                                  = 9,
        SPELLFAMILY_PALADIN                                 = 10,
        SPELLFAMILY_SHAMAN                                  = 11,
        SPELLFAMILY_UNK2                                    = 12, // 2 spells (silence resistance)
        SPELLFAMILY_POTION                                  = 13,
        // unused                                           = 14,
        SPELLFAMILY_DEATHKNIGHT                             = 15,
        // unused                                           = 16,
        SPELLFAMILY_PET                                     = 17
    };

    /// <summary>
    ///
    /// </summary>
    public enum SpellSpecific
    {
        SPELL_NORMAL                                        = 0,
        SPELL_SEAL                                          = 1,
        SPELL_BLESSING                                      = 2,
        SPELL_AURA                                          = 3,
        SPELL_STING                                         = 4,
        SPELL_CURSE                                         = 5,
        SPELL_ASPECT                                        = 6,
        SPELL_TRACKER                                       = 7,
        SPELL_WARLOCK_ARMOR                                 = 8,
        SPELL_MAGE_ARMOR                                    = 9,
        SPELL_ELEMENTAL_SHIELD                              = 10,
        SPELL_MAGE_POLYMORPH                                = 11,
        SPELL_POSITIVE_SHOUT                                = 12,
        SPELL_JUDGEMENT                                     = 13,
        SPELL_BATTLE_ELIXIR                                 = 14,
        SPELL_GUARDIAN_ELIXIR                               = 15,
        SPELL_FLASK_ELIXIR                                  = 16,
        SPELL_WARLOCK_CORRUPTION                            = 17,
        SPELL_WELL_FED                                      = 19,
        SPELL_FOOD                                          = 19,
        SPELL_DRINK                                         = 20,
        SPELL_FOOD_AND_DRINK                                = 21,
        SPELL_PRESENCE                                      = 22,
        SPELL_CHARM                                         = 23,
        SPELL_SCROLL                                        = 24,
        SPELL_MAGE_ARCANE_BRILLANCE                         = 25,
        SPELL_WARRIOR_ENRAGE                                = 26,
        SPELL_PRIEST_DIVINE_SPIRIT                          = 27,
        SPELL_HAND                                          = 28,
        SPELL_PHASE                                         = 29,
        SPELL_BANE                                          = 30
    };

    /// <summary>
    ///
    /// </summary>
    public enum SpellEffects
    {
        SPELL_EFFECT_NONE                                   = 0,
        SPELL_EFFECT_INSTAKILL                              = 1,
        SPELL_EFFECT_SCHOOL_DAMAGE                          = 2,
        SPELL_EFFECT_DUMMY                                  = 3,
        SPELL_EFFECT_PORTAL_TELEPORT                        = 4,
        SPELL_EFFECT_TELEPORT_UNITS                         = 5,
        SPELL_EFFECT_APPLY_AURA                             = 6,
        SPELL_EFFECT_ENVIRONMENTAL_DAMAGE                   = 7,
        SPELL_EFFECT_POWER_DRAIN                            = 8,
        SPELL_EFFECT_HEALTH_LEECH                           = 9,
        SPELL_EFFECT_HEAL                                   = 10,
        SPELL_EFFECT_BIND                                   = 11,
        SPELL_EFFECT_PORTAL                                 = 12,
        SPELL_EFFECT_RITUAL_BASE                            = 13,
        SPELL_EFFECT_RITUAL_SPECIALIZE                      = 14,
        SPELL_EFFECT_RITUAL_ACTIVATE_PORTAL                 = 15,
        SPELL_EFFECT_QUEST_COMPLETE                         = 16,
        SPELL_EFFECT_WEAPON_DAMAGE_NOSCHOOL                 = 17,
        SPELL_EFFECT_RESURRECT                              = 18,
        SPELL_EFFECT_ADD_EXTRA_ATTACKS                      = 19,
        SPELL_EFFECT_DODGE                                  = 20,
        SPELL_EFFECT_EVADE                                  = 21,
        SPELL_EFFECT_PARRY                                  = 22,
        SPELL_EFFECT_BLOCK                                  = 23,
        SPELL_EFFECT_CREATE_ITEM                            = 24,
        SPELL_EFFECT_WEAPON                                 = 25,
        SPELL_EFFECT_DEFENSE                                = 26,
        SPELL_EFFECT_PERSISTENT_AREA_AURA                   = 27,
        SPELL_EFFECT_SUMMON                                 = 28,
        SPELL_EFFECT_LEAP                                   = 29,
        SPELL_EFFECT_ENERGIZE                               = 30,
        SPELL_EFFECT_WEAPON_PERCENT_DAMAGE                  = 31,
        SPELL_EFFECT_TRIGGER_MISSILE                        = 32,
        SPELL_EFFECT_OPEN_LOCK                              = 33,
        SPELL_EFFECT_SUMMON_CHANGE_ITEM                     = 34,
        SPELL_EFFECT_APPLY_AREA_AURA_PARTY                  = 35,
        SPELL_EFFECT_LEARN_SPELL                            = 36,
        SPELL_EFFECT_SPELL_DEFENSE                          = 37,
        SPELL_EFFECT_DISPEL                                 = 38,
        SPELL_EFFECT_LANGUAGE                               = 39,
        SPELL_EFFECT_DUAL_WIELD                             = 40,
        SPELL_EFFECT_JUMP                                   = 41,
        SPELL_EFFECT_JUMP_DEST                              = 42,
        SPELL_EFFECT_TELEPORT_UNITS_FACE_CASTER             = 43,
        SPELL_EFFECT_SKILL_STEP                             = 44,
        SPELL_EFFECT_ADD_HONOR                              = 45,
        SPELL_EFFECT_SPAWN                                  = 46,
        SPELL_EFFECT_TRADE_SKILL                            = 47,
        SPELL_EFFECT_STEALTH                                = 48,
        SPELL_EFFECT_DETECT                                 = 49,
        SPELL_EFFECT_TRANS_DOOR                             = 50,
        SPELL_EFFECT_FORCE_CRITICAL_HIT                     = 51,
        SPELL_EFFECT_GUARANTEE_HIT                          = 52,
        SPELL_EFFECT_ENCHANT_ITEM                           = 53,
        SPELL_EFFECT_ENCHANT_ITEM_TEMPORARY                 = 54,
        SPELL_EFFECT_TAMECREATURE                           = 55,
        SPELL_EFFECT_SUMMON_PET                             = 56,
        SPELL_EFFECT_LEARN_PET_SPELL                        = 57,
        SPELL_EFFECT_WEAPON_DAMAGE                          = 58,
        SPELL_EFFECT_CREATE_RANDOM_ITEM                     = 59,
        SPELL_EFFECT_PROFICIENCY                            = 60,
        SPELL_EFFECT_SEND_EVENT                             = 61,
        SPELL_EFFECT_POWER_BURN                             = 62,
        SPELL_EFFECT_THREAT                                 = 63,
        SPELL_EFFECT_TRIGGER_SPELL                          = 64,
        SPELL_EFFECT_APPLY_AREA_AURA_RAID                   = 65,
        SPELL_EFFECT_CREATE_MANA_GEM                        = 66,
        SPELL_EFFECT_HEAL_MAX_HEALTH                        = 67,
        SPELL_EFFECT_INTERRUPT_CAST                         = 68,
        SPELL_EFFECT_DISTRACT                               = 69,
        SPELL_EFFECT_PULL                                   = 70,
        SPELL_EFFECT_PICKPOCKET                             = 71,
        SPELL_EFFECT_ADD_FARSIGHT                           = 72,
        SPELL_EFFECT_UNTRAIN_TALENTS                        = 73,
        SPELL_EFFECT_APPLY_GLYPH                            = 74,
        SPELL_EFFECT_HEAL_MECHANICAL                        = 75,
        SPELL_EFFECT_SUMMON_OBJECT_WILD                     = 76,
        SPELL_EFFECT_SCRIPT_EFFECT                          = 77,
        SPELL_EFFECT_ATTACK                                 = 78,
        SPELL_EFFECT_SANCTUARY                              = 79,
        SPELL_EFFECT_ADD_COMBO_POINTS                       = 80,
        SPELL_EFFECT_CREATE_HOUSE                           = 81,
        SPELL_EFFECT_BIND_SIGHT                             = 82,
        SPELL_EFFECT_DUEL                                   = 83,
        SPELL_EFFECT_STUCK                                  = 84,
        SPELL_EFFECT_SUMMON_PLAYER                          = 85,
        SPELL_EFFECT_ACTIVATE_OBJECT                        = 86,
        SPELL_EFFECT_GAMEOBJECT_DAMAGE                      = 87,
        SPELL_EFFECT_GAMEOBJECT_REPAIR                      = 88,
        SPELL_EFFECT_GAMEOBJECT_SET_DESTRUCTION_STATE       = 89,
        SPELL_EFFECT_KILL_CREDIT                            = 90,
        SPELL_EFFECT_THREAT_ALL                             = 91,
        SPELL_EFFECT_ENCHANT_HELD_ITEM                      = 92,
        SPELL_EFFECT_FORCE_DESELECT                         = 93,
        SPELL_EFFECT_SELF_RESURRECT                         = 94,
        SPELL_EFFECT_SKINNING                               = 95,
        SPELL_EFFECT_CHARGE                                 = 96,
        SPELL_EFFECT_CAST_BUTTON                            = 97,
        SPELL_EFFECT_KNOCK_BACK                             = 98,
        SPELL_EFFECT_DISENCHANT                             = 99,
        SPELL_EFFECT_INEBRIATE                              = 100,
        SPELL_EFFECT_FEED_PET                               = 101,
        SPELL_EFFECT_DISMISS_PET                            = 102,
        SPELL_EFFECT_REPUTATION                             = 103,
        SPELL_EFFECT_SUMMON_OBJECT_SLOT1                    = 104,
        SPELL_EFFECT_SUMMON_OBJECT_SLOT2                    = 105,
        SPELL_EFFECT_SUMMON_OBJECT_SLOT3                    = 106,
        SPELL_EFFECT_SUMMON_OBJECT_SLOT4                    = 107,
        SPELL_EFFECT_DISPEL_MECHANIC                        = 108,
        SPELL_EFFECT_SUMMON_DEAD_PET                        = 109,
        SPELL_EFFECT_DESTROY_ALL_TOTEMS                     = 110,
        SPELL_EFFECT_DURABILITY_DAMAGE                      = 111,
        SPELL_EFFECT_112                                    = 112,  // old SPELL_EFFECT_SUMMON_DEMON
        SPELL_EFFECT_RESURRECT_NEW                          = 113,
        SPELL_EFFECT_ATTACK_ME                              = 114,
        SPELL_EFFECT_DURABILITY_DAMAGE_PCT                  = 115,
        SPELL_EFFECT_SKIN_PLAYER_CORPSE                     = 116,
        SPELL_EFFECT_SPIRIT_HEAL                            = 117,
        SPELL_EFFECT_SKILL                                  = 118,
        SPELL_EFFECT_APPLY_AREA_AURA_PET                    = 119,
        SPELL_EFFECT_TELEPORT_GRAVEYARD                     = 120,
        SPELL_EFFECT_NORMALIZED_WEAPON_DMG                  = 121,
        SPELL_EFFECT_122                                    = 122,
        SPELL_EFFECT_SEND_TAXI                              = 123,
        SPELL_EFFECT_PULL_TOWARDS                           = 124,
        SPELL_EFFECT_MODIFY_THREAT_PERCENT                  = 125,
        SPELL_EFFECT_STEAL_BENEFICIAL_BUFF                  = 126,
        SPELL_EFFECT_PROSPECTING                            = 127,
        SPELL_EFFECT_APPLY_AREA_AURA_FRIEND                 = 128,
        SPELL_EFFECT_APPLY_AREA_AURA_ENEMY                  = 129,
        SPELL_EFFECT_REDIRECT_THREAT                        = 130,
        SPELL_EFFECT_131                                    = 131,
        SPELL_EFFECT_PLAY_MUSIC                             = 132,
        SPELL_EFFECT_UNLEARN_SPECIALIZATION                 = 133,
        SPELL_EFFECT_KILL_CREDIT2                           = 134,
        SPELL_EFFECT_CALL_PET                               = 135,
        SPELL_EFFECT_HEAL_PCT                               = 136,
        SPELL_EFFECT_ENERGIZE_PCT                           = 137,
        SPELL_EFFECT_LEAP_BACK                              = 138,
        SPELL_EFFECT_CLEAR_QUEST                            = 139,
        SPELL_EFFECT_FORCE_CAST                             = 140,
        SPELL_EFFECT_FORCE_CAST_WITH_VALUE                  = 141,
        SPELL_EFFECT_TRIGGER_SPELL_WITH_VALUE               = 142,
        SPELL_EFFECT_APPLY_AREA_AURA_OWNER                  = 143,
        SPELL_EFFECT_KNOCK_BACK_DEST                        = 144,
        SPELL_EFFECT_PULL_TOWARDS_DEST                      = 145,
        SPELL_EFFECT_ACTIVATE_RUNE                          = 146,
        SPELL_EFFECT_QUEST_FAIL                             = 147,
        SPELL_EFFECT_TRIGGER_MISSILE_SPELL_WITH_VALUE       = 148,
        SPELL_EFFECT_CHARGE_DEST                            = 149,
        SPELL_EFFECT_QUEST_START                            = 150,
        SPELL_EFFECT_TRIGGER_SPELL_2                        = 151,
        SPELL_EFFECT_SUMMON_RAF_FRIEND                      = 152,
        SPELL_EFFECT_CREATE_TAMED_PET                       = 153,
        SPELL_EFFECT_DISCOVER_TAXI                          = 154,
        SPELL_EFFECT_TITAN_GRIP                             = 155,
        SPELL_EFFECT_ENCHANT_ITEM_PRISMATIC                 = 156,
        SPELL_EFFECT_CREATE_ITEM_2                          = 157,
        SPELL_EFFECT_MILLING                                = 158,
        SPELL_EFFECT_ALLOW_RENAME_PET                       = 159,
        SPELL_EFFECT_160                                    = 160,
        SPELL_EFFECT_TALENT_SPEC_COUNT                      = 161,
        SPELL_EFFECT_TALENT_SPEC_SELECT                     = 162,
        SPELL_EFFECT_163                                    = 163,
        SPELL_EFFECT_REMOVE_AURA                            = 164,
        SPELL_EFFECT_DAMAGE_PCT_SELF                        = 165,
        SPELL_EFFECT_MOD_CURRENCY                           = 166,
        SPELL_EFFECT_UPDATE_PHASE_SHIFT                     = 167,
        SPELL_EFFECT_ALLOW_CONTROL_PET                      = 168,
        SPELL_EFFECT_REMOVE_ITEM                            = 169,
        SPELL_EFFECT_UPDATE_ZONE_AURAS                      = 170,
        SPELL_EFFECT_SUMMON_OBJECT_UNK                      = 171,  // Summons gameobject
        SPELL_EFFECT_RESURRECT_WITH_AURA                    = 172,  // Aoe resurrection
        SPELL_EFFECT_BUY_GUILD_TAB                          = 173,  // Guild tab unlocked (guild perk)
        SPELL_EFFECT_APPLY_AURA_2                           = 174,

        TOTAL_SPELL_EFFECTS                                 = 175
    };

    /// <summary>
    ///
    /// </summary>
    public enum AuraType
    {
        SPELL_AURA_NONE                                      = 0,
        SPELL_AURA_BIND_SIGHT                                = 1,
        SPELL_AURA_MOD_POSSESS                               = 2,
        SPELL_AURA_PERIODIC_DAMAGE                           = 3,
        SPELL_AURA_DUMMY                                     = 4,
        SPELL_AURA_MOD_CONFUSE                               = 5,
        SPELL_AURA_MOD_CHARM                                 = 6,
        SPELL_AURA_MOD_FEAR                                  = 7,
        SPELL_AURA_PERIODIC_HEAL                             = 8,
        SPELL_AURA_MOD_ATTACKSPEED                           = 9,
        SPELL_AURA_MOD_THREAT                                = 10,
        SPELL_AURA_MOD_TAUNT                                 = 11,
        SPELL_AURA_MOD_STUN                                  = 12,
        SPELL_AURA_MOD_DAMAGE_DONE                           = 13,
        SPELL_AURA_MOD_DAMAGE_TAKEN                          = 14,
        SPELL_AURA_DAMAGE_SHIELD                             = 15,
        SPELL_AURA_MOD_STEALTH                               = 16,
        SPELL_AURA_MOD_STEALTH_DETECT                        = 17,
        SPELL_AURA_MOD_INVISIBILITY                          = 18,
        SPELL_AURA_MOD_INVISIBILITY_DETECT                   = 19,
        SPELL_AURA_OBS_MOD_HEALTH                            = 20,    // 20, 21 unofficial
        SPELL_AURA_OBS_MOD_POWER                             = 21,
        SPELL_AURA_MOD_RESISTANCE                            = 22,
        SPELL_AURA_PERIODIC_TRIGGER_SPELL                    = 23,
        SPELL_AURA_PERIODIC_ENERGIZE                         = 24,
        SPELL_AURA_MOD_PACIFY                                = 25,
        SPELL_AURA_MOD_ROOT                                  = 26,
        SPELL_AURA_MOD_SILENCE                               = 27,
        SPELL_AURA_REFLECT_SPELLS                            = 28,
        SPELL_AURA_MOD_STAT                                  = 29,
        SPELL_AURA_MOD_SKILL                                 = 30,
        SPELL_AURA_MOD_INCREASE_SPEED                        = 31,
        SPELL_AURA_MOD_INCREASE_MOUNTED_SPEED                = 32,
        SPELL_AURA_MOD_DECREASE_SPEED                        = 33,
        SPELL_AURA_MOD_INCREASE_HEALTH                       = 34,
        SPELL_AURA_MOD_INCREASE_ENERGY                       = 35,
        SPELL_AURA_MOD_SHAPESHIFT                            = 36,
        SPELL_AURA_EFFECT_IMMUNITY                           = 37,
        SPELL_AURA_STATE_IMMUNITY                            = 38,
        SPELL_AURA_SCHOOL_IMMUNITY                           = 39,
        SPELL_AURA_DAMAGE_IMMUNITY                           = 40,
        SPELL_AURA_DISPEL_IMMUNITY                           = 41,
        SPELL_AURA_PROC_TRIGGER_SPELL                        = 42,
        SPELL_AURA_PROC_TRIGGER_DAMAGE                       = 43,
        SPELL_AURA_TRACK_CREATURES                           = 44,
        SPELL_AURA_TRACK_RESOURCES                           = 45,
        SPELL_AURA_46                                        = 46,    // Ignore all Gear test spells
        SPELL_AURA_MOD_PARRY_PERCENT                         = 47,
        SPELL_AURA_48                                        = 48,    // One periodic spell
        SPELL_AURA_MOD_DODGE_PERCENT                         = 49,
        SPELL_AURA_MOD_CRITICAL_HEALING_AMOUNT               = 50,
        SPELL_AURA_MOD_BLOCK_PERCENT                         = 51,
        SPELL_AURA_MOD_WEAPON_CRIT_PERCENT                   = 52,
        SPELL_AURA_PERIODIC_LEECH                            = 53,
        SPELL_AURA_MOD_HIT_CHANCE                            = 54,
        SPELL_AURA_MOD_SPELL_HIT_CHANCE                      = 55,
        SPELL_AURA_TRANSFORM                                 = 56,
        SPELL_AURA_MOD_SPELL_CRIT_CHANCE                     = 57,
        SPELL_AURA_MOD_INCREASE_SWIM_SPEED                   = 58,
        SPELL_AURA_MOD_DAMAGE_DONE_CREATURE                  = 59,
        SPELL_AURA_MOD_PACIFY_SILENCE                        = 60,
        SPELL_AURA_MOD_SCALE                                 = 61,
        SPELL_AURA_PERIODIC_HEALTH_FUNNEL                    = 62,
        SPELL_AURA_63                                        = 63,   // old SPELL_AURA_PERIODIC_MANA_FUNNEL
        SPELL_AURA_PERIODIC_MANA_LEECH                       = 64,
        SPELL_AURA_MOD_CASTING_SPEED_NOT_STACK               = 65,
        SPELL_AURA_FEIGN_DEATH                               = 66,
        SPELL_AURA_MOD_DISARM                                = 67,
        SPELL_AURA_MOD_STALKED                               = 68,
        SPELL_AURA_SCHOOL_ABSORB                             = 69,
        SPELL_AURA_EXTRA_ATTACKS                             = 70,
        SPELL_AURA_MOD_SPELL_CRIT_CHANCE_SCHOOL              = 71,
        SPELL_AURA_MOD_POWER_COST_SCHOOL_PCT                 = 72,
        SPELL_AURA_MOD_POWER_COST_SCHOOL                     = 73,
        SPELL_AURA_REFLECT_SPELLS_SCHOOL                     = 74,
        SPELL_AURA_MOD_LANGUAGE                              = 75,
        SPELL_AURA_FAR_SIGHT                                 = 76,
        SPELL_AURA_MECHANIC_IMMUNITY                         = 77,
        SPELL_AURA_MOUNTED                                   = 78,
        SPELL_AURA_MOD_DAMAGE_PERCENT_DONE                   = 79,
        SPELL_AURA_MOD_PERCENT_STAT                          = 80,
        SPELL_AURA_SPLIT_DAMAGE_PCT                          = 81,
        SPELL_AURA_WATER_BREATHING                           = 82,
        SPELL_AURA_MOD_BASE_RESISTANCE                       = 83,
        SPELL_AURA_MOD_REGEN                                 = 84,
        SPELL_AURA_MOD_POWER_REGEN                           = 85,
        SPELL_AURA_CHANNEL_DEATH_ITEM                        = 86,
        SPELL_AURA_MOD_DAMAGE_PERCENT_TAKEN                  = 87,
        SPELL_AURA_MOD_HEALTH_REGEN_PERCENT                  = 88,
        SPELL_AURA_PERIODIC_DAMAGE_PERCENT                   = 89,
        SPELL_AURA_90                                        = 90,    // old SPELL_AURA_MOD_RESIST_CHANCE
        SPELL_AURA_MOD_DETECT_RANGE                          = 91,
        SPELL_AURA_PREVENTS_FLEEING                          = 92,
        SPELL_AURA_MOD_UNATTACKABLE                          = 93,
        SPELL_AURA_INTERRUPT_REGEN                           = 94,
        SPELL_AURA_GHOST                                     = 95,
        SPELL_AURA_SPELL_MAGNET                              = 96,
        SPELL_AURA_MANA_SHIELD                               = 97,
        SPELL_AURA_MOD_SKILL_TALENT                          = 98,
        SPELL_AURA_MOD_ATTACK_POWER                          = 99,
        SPELL_AURA_AURAS_VISIBLE                             = 100,
        SPELL_AURA_MOD_RESISTANCE_PCT                        = 101,
        SPELL_AURA_MOD_MELEE_ATTACK_POWER_VERSUS             = 102,
        SPELL_AURA_MOD_TOTAL_THREAT                          = 103,
        SPELL_AURA_WATER_WALK                                = 104,
        SPELL_AURA_FEATHER_FALL                              = 105,
        SPELL_AURA_HOVER                                     = 106,
        SPELL_AURA_ADD_FLAT_MODIFIER                         = 107,
        SPELL_AURA_ADD_PCT_MODIFIER                          = 108,
        SPELL_AURA_ADD_TARGET_TRIGGER                        = 109,
        SPELL_AURA_MOD_POWER_REGEN_PERCENT                   = 110,
        SPELL_AURA_ADD_CASTER_HIT_TRIGGER                    = 111,
        SPELL_AURA_OVERRIDE_CLASS_SCRIPTS                    = 112,
        SPELL_AURA_MOD_RANGED_DAMAGE_TAKEN                   = 113,
        SPELL_AURA_MOD_RANGED_DAMAGE_TAKEN_PCT               = 114,
        SPELL_AURA_MOD_HEALING                               = 115,
        SPELL_AURA_MOD_REGEN_DURING_COMBAT                   = 116,
        SPELL_AURA_MOD_MECHANIC_RESISTANCE                   = 117,
        SPELL_AURA_MOD_HEALING_PCT                           = 118,
        SPELL_AURA_119                                       = 119,    // old SPELL_AURA_SHARE_PET_TRACKING
        SPELL_AURA_UNTRACKABLE                               = 120,
        SPELL_AURA_EMPATHY                                   = 121,
        SPELL_AURA_MOD_OFFHAND_DAMAGE_PCT                    = 122,
        SPELL_AURA_MOD_TARGET_RESISTANCE                     = 123,
        SPELL_AURA_MOD_RANGED_ATTACK_POWER                   = 124,
        SPELL_AURA_MOD_MELEE_DAMAGE_TAKEN                    = 125,
        SPELL_AURA_MOD_MELEE_DAMAGE_TAKEN_PCT                = 126,
        SPELL_AURA_RANGED_ATTACK_POWER_ATTACKER_BONUS        = 127,
        SPELL_AURA_MOD_POSSESS_PET                           = 128,
        SPELL_AURA_MOD_SPEED_ALWAYS                          = 129,
        SPELL_AURA_MOD_MOUNTED_SPEED_ALWAYS                  = 130,
        SPELL_AURA_MOD_RANGED_ATTACK_POWER_VERSUS            = 131,
        SPELL_AURA_MOD_INCREASE_ENERGY_PERCENT               = 132,
        SPELL_AURA_MOD_INCREASE_HEALTH_PERCENT               = 133,
        SPELL_AURA_MOD_MANA_REGEN_INTERRUPT                  = 134,
        SPELL_AURA_MOD_HEALING_DONE                          = 135,
        SPELL_AURA_MOD_HEALING_DONE_PERCENT                  = 136,
        SPELL_AURA_MOD_TOTAL_STAT_PERCENTAGE                 = 137,
        SPELL_AURA_MOD_MELEE_HASTE                           = 138,
        SPELL_AURA_FORCE_REACTION                            = 139,
        SPELL_AURA_MOD_RANGED_HASTE                          = 140,
        SPELL_AURA_MOD_RANGED_AMMO_HASTE                     = 141,
        SPELL_AURA_MOD_BASE_RESISTANCE_PCT                   = 142,
        SPELL_AURA_MOD_RESISTANCE_EXCLUSIVE                  = 143,
        SPELL_AURA_SAFE_FALL                                 = 144,
        SPELL_AURA_MOD_PET_TALENT_POINTS                     = 145,
        SPELL_AURA_ALLOW_TAME_PET_TYPE                       = 146,
        SPELL_AURA_MECHANIC_IMMUNITY_MASK                    = 147,
        SPELL_AURA_RETAIN_COMBO_POINTS                       = 148,
        SPELL_AURA_REDUCE_PUSHBACK                           = 149,     // Reduce Pushback
        SPELL_AURA_MOD_SHIELD_BLOCKVALUE_PCT                 = 150,
        SPELL_AURA_TRACK_STEALTHED                           = 151,     // Track Stealthed
        SPELL_AURA_MOD_DETECTED_RANGE                        = 152,     // Mod Detected Range
        SPELL_AURA_SPLIT_DAMAGE_FLAT                         = 153,     // Split Damage Flat
        SPELL_AURA_MOD_STEALTH_LEVEL                         = 154,     // Stealth Level Modifier
        SPELL_AURA_MOD_WATER_BREATHING                       = 155,     // Mod Water Breathing
        SPELL_AURA_MOD_REPUTATION_GAIN                       = 156,     // Mod Reputation Gain
        SPELL_AURA_PET_DAMAGE_MULTI                          = 157,     // Mod Pet Damage
        SPELL_AURA_MOD_SHIELD_BLOCKVALUE                     = 158,
        SPELL_AURA_NO_PVP_CREDIT                             = 159,
        SPELL_AURA_MOD_AOE_AVOIDANCE                         = 160,
        SPELL_AURA_MOD_HEALTH_REGEN_IN_COMBAT                = 161,
        SPELL_AURA_POWER_BURN_MANA                           = 162,
        SPELL_AURA_MOD_CRIT_DAMAGE_BONUS                     = 163,
        SPELL_AURA_164                                       = 164,
        SPELL_AURA_MELEE_ATTACK_POWER_ATTACKER_BONUS         = 165,
        SPELL_AURA_MOD_ATTACK_POWER_PCT                      = 166,
        SPELL_AURA_MOD_RANGED_ATTACK_POWER_PCT               = 167,
        SPELL_AURA_MOD_DAMAGE_DONE_VERSUS                    = 168,
        SPELL_AURA_MOD_CRIT_PERCENT_VERSUS                   = 169,
        SPELL_AURA_DETECT_AMORE                              = 170,
        SPELL_AURA_MOD_SPEED_NOT_STACK                       = 171,
        SPELL_AURA_MOD_MOUNTED_SPEED_NOT_STACK               = 172,
        SPELL_AURA_173                                       = 173,     // old SPELL_AURA_ALLOW_CHAMPION_SPELLS
        SPELL_AURA_MOD_SPELL_DAMAGE_OF_STAT_PERCENT          = 174,     // by default intellect, dependent from SPELL_AURA_MOD_SPELL_HEALING_OF_STAT_PERCENT
        SPELL_AURA_MOD_SPELL_HEALING_OF_STAT_PERCENT         = 175,
        SPELL_AURA_SPIRIT_OF_REDEMPTION                      = 176,
        SPELL_AURA_AOE_CHARM                                 = 177,
        SPELL_AURA_MOD_DEBUFF_RESISTANCE                     = 178,
        SPELL_AURA_MOD_ATTACKER_SPELL_CRIT_CHANCE            = 179,
        SPELL_AURA_MOD_FLAT_SPELL_DAMAGE_VERSUS              = 180,
        SPELL_AURA_181                                       = 181,    // old SPELL_AURA_MOD_FLAT_SPELL_CRIT_DAMAGE_VERSUS - possible flat spell crit damage versus
        SPELL_AURA_MOD_RESISTANCE_OF_STAT_PERCENT            = 182,
        SPELL_AURA_MOD_CRITICAL_THREAT                       = 183,
        SPELL_AURA_MOD_ATTACKER_MELEE_HIT_CHANCE             = 184,
        SPELL_AURA_MOD_ATTACKER_RANGED_HIT_CHANCE            = 185,
        SPELL_AURA_MOD_ATTACKER_SPELL_HIT_CHANCE             = 186,
        SPELL_AURA_MOD_ATTACKER_MELEE_CRIT_CHANCE            = 187,
        SPELL_AURA_MOD_ATTACKER_RANGED_CRIT_CHANCE           = 188,
        SPELL_AURA_MOD_RATING                                = 189,
        SPELL_AURA_MOD_FACTION_REPUTATION_GAIN               = 190,
        SPELL_AURA_USE_NORMAL_MOVEMENT_SPEED                 = 191,
        SPELL_AURA_MOD_MELEE_RANGED_HASTE                    = 192,
        SPELL_AURA_MELEE_SLOW                                = 193,
        SPELL_AURA_MOD_TARGET_ABSORB_SCHOOL                  = 194,
        SPELL_AURA_MOD_TARGET_ABILITY_ABSORB_SCHOOL          = 195,
        SPELL_AURA_MOD_COOLDOWN                              = 196,   // only 24818 Noxious Breath
        SPELL_AURA_MOD_ATTACKER_SPELL_AND_WEAPON_CRIT_CHANCE = 197,
        SPELL_AURA_198                                       = 198,   // old SPELL_AURA_MOD_ALL_WEAPON_SKILLS
        SPELL_AURA_MOD_INCREASES_SPELL_PCT_TO_HIT            = 199,
        SPELL_AURA_MOD_XP_PCT                                = 200,
        SPELL_AURA_FLY                                       = 201,
        SPELL_AURA_IGNORE_COMBAT_RESULT                      = 202,
        SPELL_AURA_MOD_ATTACKER_MELEE_CRIT_DAMAGE            = 203,
        SPELL_AURA_MOD_ATTACKER_RANGED_CRIT_DAMAGE           = 204,
        SPELL_AURA_MOD_SCHOOL_CRIT_DMG_TAKEN                 = 205,
        SPELL_AURA_MOD_INCREASE_VEHICLE_FLIGHT_SPEED         = 206,
        SPELL_AURA_MOD_INCREASE_MOUNTED_FLIGHT_SPEED         = 207,
        SPELL_AURA_MOD_INCREASE_FLIGHT_SPEED                 = 208,
        SPELL_AURA_MOD_MOUNTED_FLIGHT_SPEED_ALWAYS           = 209,
        SPELL_AURA_MOD_VEHICLE_SPEED_ALWAYS                  = 210,
        SPELL_AURA_MOD_FLIGHT_SPEED_NOT_STACK                = 211,
        SPELL_AURA_MOD_RANGED_ATTACK_POWER_OF_STAT_PERCENT   = 212,
        SPELL_AURA_MOD_RAGE_FROM_DAMAGE_DEALT                = 213,
        SPELL_AURA_214                                       = 214,
        SPELL_AURA_ARENA_PREPARATION                         = 215,
        SPELL_AURA_HASTE_SPELLS                              = 216,
        SPELL_AURA_MOD_MELEE_HASTE_2                         = 217,   // NYI
        SPELL_AURA_HASTE_RANGED                              = 218,
        SPELL_AURA_MOD_MANA_REGEN_FROM_STAT                  = 219,
        SPELL_AURA_MOD_RATING_FROM_STAT                      = 220,
        SPELL_AURA_MOD_DETAUNT                               = 221,
        SPELL_AURA_222                                       = 222,
        SPELL_AURA_RAID_PROC_FROM_CHARGE                     = 223,
        SPELL_AURA_224                                       = 224,
        SPELL_AURA_RAID_PROC_FROM_CHARGE_WITH_VALUE          = 225,
        SPELL_AURA_PERIODIC_DUMMY                            = 226,
        SPELL_AURA_PERIODIC_TRIGGER_SPELL_WITH_VALUE         = 227,
        SPELL_AURA_DETECT_STEALTH                            = 228,
        SPELL_AURA_MOD_AOE_DAMAGE_AVOIDANCE                  = 229,
        SPELL_AURA_230                                       = 230,
        SPELL_AURA_PROC_TRIGGER_SPELL_WITH_VALUE             = 231,
        SPELL_AURA_MECHANIC_DURATION_MOD                     = 232,
        SPELL_AURA_CHANGE_MODEL_FOR_ALL_HUMANOIDS            = 233,   // client-side only
        SPELL_AURA_MECHANIC_DURATION_MOD_NOT_STACK           = 234,
        SPELL_AURA_MOD_DISPEL_RESIST                         = 235,
        SPELL_AURA_CONTROL_VEHICLE                           = 236,
        SPELL_AURA_MOD_SPELL_DAMAGE_OF_ATTACK_POWER          = 237,
        SPELL_AURA_MOD_SPELL_HEALING_OF_ATTACK_POWER         = 238,
        SPELL_AURA_MOD_SCALE_2                               = 239,
        SPELL_AURA_MOD_EXPERTISE                             = 240,
        SPELL_AURA_FORCE_MOVE_FORWARD                        = 241,
        SPELL_AURA_MOD_SPELL_DAMAGE_FROM_HEALING             = 242,
        SPELL_AURA_MOD_FACTION                               = 243,
        SPELL_AURA_COMPREHEND_LANGUAGE                       = 244,
        SPELL_AURA_MOD_AURA_DURATION_BY_DISPEL               = 245,
        SPELL_AURA_MOD_AURA_DURATION_BY_DISPEL_NOT_STACK     = 246,
        SPELL_AURA_CLONE_CASTER                              = 247,
        SPELL_AURA_MOD_COMBAT_RESULT_CHANCE                  = 248,
        SPELL_AURA_CONVERT_RUNE                              = 249,
        SPELL_AURA_MOD_INCREASE_HEALTH_2                     = 250,
        SPELL_AURA_MOD_ENEMY_DODGE                           = 251,
        SPELL_AURA_MOD_SPEED_SLOW_ALL                        = 252,
        SPELL_AURA_MOD_BLOCK_CRIT_CHANCE                     = 253,
        SPELL_AURA_MOD_DISARM_OFFHAND                        = 254,
        SPELL_AURA_MOD_MECHANIC_DAMAGE_TAKEN_PERCENT         = 255,
        SPELL_AURA_NO_REAGENT_USE                            = 256,
        SPELL_AURA_MOD_TARGET_RESIST_BY_SPELL_CLASS          = 257,
        SPELL_AURA_258                                       = 258,
        SPELL_AURA_MOD_HOT_PCT                               = 259,
        SPELL_AURA_SCREEN_EFFECT                             = 260,
        SPELL_AURA_PHASE                                     = 261,
        SPELL_AURA_ABILITY_IGNORE_AURASTATE                  = 262,
        SPELL_AURA_ALLOW_ONLY_ABILITY                        = 263,
        SPELL_AURA_264                                       = 264,
        SPELL_AURA_265                                       = 265,
        SPELL_AURA_266                                       = 266,
        SPELL_AURA_MOD_IMMUNE_AURA_APPLY_SCHOOL              = 267,
        SPELL_AURA_MOD_ATTACK_POWER_OF_STAT_PERCENT          = 268,
        SPELL_AURA_MOD_IGNORE_TARGET_RESIST                  = 269,
        SPELL_AURA_MOD_ABILITY_IGNORE_TARGET_RESIST          = 270,      // Possibly need swap vs 195 aura used only in 1 spell Chaos Bolt Passive
        SPELL_AURA_MOD_DAMAGE_FROM_CASTER                    = 271,
        SPELL_AURA_IGNORE_MELEE_RESET                        = 272,
        SPELL_AURA_X_RAY                                     = 273,
        SPELL_AURA_ABILITY_CONSUME_NO_AMMO                   = 274,
        SPELL_AURA_MOD_IGNORE_SHAPESHIFT                     = 275,
        SPELL_AURA_MOD_DAMAGE_DONE_FOR_MECHANIC              = 276,      // NYI
        SPELL_AURA_MOD_MAX_AFFECTED_TARGETS                  = 277,
        SPELL_AURA_MOD_DISARM_RANGED                         = 278,
        SPELL_AURA_INITIALIZE_IMAGES                         = 279,
        SPELL_AURA_MOD_ARMOR_PENETRATION_PCT                 = 280,
        SPELL_AURA_MOD_HONOR_GAIN_PCT                        = 281,
        SPELL_AURA_MOD_BASE_HEALTH_PCT                       = 282,
        SPELL_AURA_MOD_HEALING_RECEIVED                      = 283,      // Possibly only for some spell family class spells
        SPELL_AURA_LINKED                                    = 284,
        SPELL_AURA_MOD_ATTACK_POWER_OF_ARMOR                 = 285,
        SPELL_AURA_ABILITY_PERIODIC_CRIT                     = 286,
        SPELL_AURA_DEFLECT_SPELLS                            = 287,
        SPELL_AURA_IGNORE_HIT_DIRECTION                      = 288,
        SPELL_AURA_289                                       = 289,
        SPELL_AURA_MOD_CRIT_PCT                              = 290,
        SPELL_AURA_MOD_XP_QUEST_PCT                          = 291,
        SPELL_AURA_OPEN_STABLE                               = 292,
        SPELL_AURA_OVERRIDE_SPELLS                           = 293,
        SPELL_AURA_PREVENT_REGENERATE_POWER                  = 294,
        SPELL_AURA_295                                       = 295,
        SPELL_AURA_SET_VEHICLE_ID                            = 296,
        SPELL_AURA_BLOCK_SPELL_FAMILY                        = 297,
        SPELL_AURA_STRANGULATE                               = 298,
        SPELL_AURA_299                                       = 299,       // 299 unused (3.2.2a - 5.0.1)
        SPELL_AURA_SHARE_DAMAGE_PCT                          = 300,
        SPELL_AURA_SCHOOL_HEAL_ABSORB                        = 301,
        SPELL_AURA_302                                       = 302,       // 302 unused (3.2.2a - 5.0.1)
        SPELL_AURA_MOD_DAMAGE_DONE_VERSUS_AURASTATE          = 303,
        SPELL_AURA_MOD_FAKE_INEBRIATE                        = 304,
        SPELL_AURA_MOD_MINIMUM_SPEED                         = 305,
        SPELL_AURA_306                                       = 306,       // 306 unused
        SPELL_AURA_HEAL_ABSORB_TEST                          = 307,
        SPELL_AURA_MOD_CRIT_CHANCE_FOR_CASTER_SPELL          = 308,
        SPELL_AURA_309                                       = 309,       // 309 unused
        SPELL_AURA_MOD_CREATURE_AOE_DAMAGE_AVOIDANCE         = 310,
        SPELL_AURA_311                                       = 311,       // some kind of stun effect
        SPELL_AURA_312                                       = 312,       // some cosmetic auras
        SPELL_AURA_313                                       = 313,
        SPELL_AURA_PREVENT_RESURRECTION                      = 314,
        SPELL_AURA_UNDERWATER_WALKING                        = 315,
        SPELL_AURA_PERIODIC_HASTE                            = 316,
        SPELL_AURA_MOD_SPELL_POWER_PCT                       = 317,
        SPELL_AURA_MASTERY                                   = 318,
        SPELL_AURA_MOD_MELEE_ATTACK_SPEED                    = 319,    // (melee?) attack speed
        SPELL_AURA_MOD_RANGED_ATTACK_SPEED                   = 320,    // NYI
        SPELL_AURA_321                                       = 321,
        SPELL_AURA_INTERFERE_TARGETING                       = 322,    // NYI SPELL_AURA_INTERFERE_TARGETING 6 spells
        SPELL_AURA_323                                       = 323,
        SPELL_AURA_MOD_EXPERTISE2                            = 324,    // 2 test spells
        SPELL_AURA_325                                       = 325,
        SPELL_AURA_326                                       = 326,    // 24 spells in phase auras
        SPELL_AURA_327                                       = 327,
        SPELL_AURA_PROC_ON_POWER_AMOUNT                      = 328,    // 3 spells Eclipse Mastery Driver Passive
        SPELL_AURA_MOD_RUNIC_POWER_REGEN                     = 329,    // NYI - 3 spells SPELL_AURA_MOD_RUNIC_POWER_REGEN
        SPELL_AURA_CAST_WHILE_MOVING                         = 330,    // 16 spells SPELL_AURA_ALLOW_CAST_WHILE_MOVING
        SPELL_AURA_MOD_WEATHER                               = 331,    // 10 spells SPELL_AURA_MOD_WEATHER
        SPELL_AURA_SWAP_SPELLS                               = 332,    // 16 spells SPELL_AURA_OVERRIDE_ACTIONBAR_SPELLS(this is correct aura name)
        SPELL_AURA_SWAP_SPELLS_2                             = 333,    // 10 spells SPELL_AURA_OVERRIDE_ACTIONBAR_SPELLS_2(this is correct aura name)
        SPELL_AURA_334                                       = 334,    // This aura blinds the target, makes all npcs and players invisible but they still can see you
        SPELL_AURA_335                                       = 335,    // Something related to invisibility
        SPELL_AURA_FLIGHT_RESTRICTIONS                       = 336,    // 8 spells SPELL_AURA_FLIGHT_RESTRICTIONS
        SPELL_AURA_MOD_VENDOR_PRICE                          = 337,    // guild perk, 1 spell SPELL_AURA_MOD_VENDOR_PRICE this aura reduces the price of the items from all vendors by (GetBasePoints())%
        SPELL_AURA_REDUCE_DURABILITY_LOSS                    = 338,    // Reduces durability loss on death
        SPELL_AURA_MOD_SKILLCHANCE                           = 339,    // guild perk aura, 1 spell SPELL_AURA_MOD_SKILLCHANCE
        SPELL_AURA_MOD_RESSURECTED_HEALTH_PCT                = 340,    // guild perk aura, 1 spell SPELL_AURA_MOD_RESSURECTED_HEALTH_PCT, Increases health gained when resurrected by a guild member by (GetBasePoints())%.  Does not function in combat or while in a Battleground or Arena.
        SPELL_AURA_MOD_ITEM_COOLDOWN                         = 341,    // 2 spells modifies cooldown of hearthstone and cast time of archaeology mining
        SPELL_AURA_MOD_TIME_BETWEEN_ATTACKS                  = 342,    // Increases the time between attacks of the target
        SPELL_AURA_MOD_ALL_DAMAGE_FROM_CASTER                = 343,    // 2 spells SPELL_AURA_MOD_ALL_DAMAGE_FROM_CASTER
        SPELL_AURA_MOD_AUTOATTACK_DAMAGE                     = 344,    // Increases damage done (white damage)
        SPELL_AURA_MOD_ARMOR_EFFECTIVENESS_FOR_CASTER        = 345,    // Allows caster to bypass (GetAmount())% of the targets armor
        SPELL_AURA_PROGRESS_BAR                              = 346,    // 32 spells shows progressbar- UI like
        SPELL_AURA_MOD_SPELL_COOLDOWN_BY_HASTE               = 347,    // NYI -  2 spells SPELL_AURA_MOD_CD_FROM_HASTE
        SPELL_AURA_MOD_MONEY_TO_GUILD_BANK                   = 348,    // guild perk, 2 spells SPELL_AURA_MOD_MONEY_TO_GUILD_BANK, Each time you loot money from an enemy, an extra (Getbasepoints())% money is generated and deposited directly into your guild bank.
        SPELL_AURA_MOD_CURRENCY_GAIN                         = 349,    // 16 spells SPELL_AURA_MOD_CURRENCY_GAIN, Increases (GetMiscValue()) gained by (Getbasepoints())% miscvalue 392 = honor points, its mostly used for honor points
        SPELL_AURA_MOD_GATHERING_ITEMS_GAINED_PERCENT        = 350,    // Increases the quantity of materials gained from Mining, Skinning, Herbalism, and Disenchanting. 15%
        SPELL_AURA_MOD_ARCHAEOLOGY_ITEM_FINDS                = 351,    // 8 spells archaeology-related - (i think it increases rating of rare items or something like that)
        SPELL_AURA_ENABLE_SWITCH_RACES                       = 352,    // 1 spell enables worgen<>human form switches
        SPELL_AURA_MOD_CAMOUFLAGE                            = 353,    // 3 spells SPELL_AURA_MOD_CAMOUFLAGE

        TOTAL_AURAS                                          = 354
    }

    /// <summary>
    /// Target
    /// </summary>
    public enum Targets
    {
        TARGET_NONE                                          = 0,
        TARGET_UNIT_CASTER                                 = 1,
        TARGET_UNIT_NEARBY_ENEMY                           = 2,
        TARGET_UNIT_NEARBY_PARTY                           = 3,
        TARGET_UNIT_NEARBY_ALLY                            = 4,
        TARGET_UNIT_PET                                    = 5,
        TARGET_UNIT_TARGET_ENEMY                           = 6,
        TARGET_UNIT_SRC_AREA_ENTRY                         = 7,
        TARGET_UNIT_DEST_AREA_ENTRY                        = 8,
        TARGET_DEST_HOME                                   = 9,
        TARGET_UNIT_SRC_AREA_UNK_11                        = 11,
        TARGET_UNIT_SRC_AREA_ENEMY                         = 15,
        TARGET_UNIT_DEST_AREA_ENEMY                        = 16,
        TARGET_DEST_DB                                     = 17,
        TARGET_DEST_CASTER                                 = 18,
        TARGET_UNIT_CASTER_AREA_PARTY                      = 20,
        TARGET_UNIT_TARGET_ALLY                            = 21,
        TARGET_SRC_CASTER                                  = 22,
        TARGET_GAMEOBJECT_TARGET                           = 23,
        TARGET_UNIT_CONE_ENEMY_24                          = 24,
        TARGET_UNIT_TARGET_ANY                             = 25,
        TARGET_GAMEOBJECT_ITEM_TARGET                      = 26,
        TARGET_UNIT_MASTER                                 = 27,
        TARGET_DEST_DYNOBJ_ENEMY                           = 28,
        TARGET_DEST_DYNOBJ_ALLY                            = 29,
        TARGET_UNIT_SRC_AREA_ALLY                          = 30,
        TARGET_UNIT_DEST_AREA_ALLY                         = 31,
        TARGET_DEST_CASTER_SUMMON                          = 32, // front left, doesn't use radius
        TARGET_UNIT_SRC_AREA_PARTY                         = 33,
        TARGET_UNIT_DEST_AREA_PARTY                        = 34,
        TARGET_UNIT_TARGET_PARTY                           = 35,
        TARGET_DEST_CASTER_UNK_36                          = 36,
        TARGET_UNIT_LASTTARGET_AREA_PARTY                  = 37,
        TARGET_UNIT_NEARBY_ENTRY                           = 38,
        TARGET_DEST_CASTER_FISHING                         = 39,
        TARGET_GAMEOBJECT_NEARBY_ENTRY                     = 40,
        TARGET_DEST_CASTER_FRONT_RIGHT                     = 41,
        TARGET_DEST_CASTER_BACK_RIGHT                      = 42,
        TARGET_DEST_CASTER_BACK_LEFT                       = 43,
        TARGET_DEST_CASTER_FRONT_LEFT                      = 44,
        TARGET_UNIT_TARGET_CHAINHEAL_ALLY                  = 45,
        TARGET_DEST_NEARBY_ENTRY                           = 46,
        TARGET_DEST_CASTER_FRONT                           = 47,
        TARGET_DEST_CASTER_BACK                            = 48,
        TARGET_DEST_CASTER_RIGHT                           = 49,
        TARGET_DEST_CASTER_LEFT                            = 50,
        TARGET_GAMEOBJECT_SRC_AREA                         = 51,
        TARGET_GAMEOBJECT_DEST_AREA                        = 52,
        TARGET_DEST_TARGET_ENEMY                           = 53,
        TARGET_UNIT_CONE_ENEMY_54                          = 54,
        TARGET_DEST_CASTER_FRONT_LEAP                      = 55, // for a leap spell
        TARGET_UNIT_CASTER_AREA_RAID                       = 56,
        TARGET_UNIT_TARGET_RAID                            = 57,
        TARGET_UNIT_NEARBY_RAID                            = 58,
        TARGET_UNIT_CONE_ALLY                              = 59,
        TARGET_UNIT_CONE_ENTRY                             = 60,
        TARGET_UNIT_TARGET_AREA_RAID_CLASS                 = 61,
        TARGET_UNK_62                                      = 62,
        TARGET_DEST_TARGET_ANY                             = 63,
        TARGET_DEST_TARGET_FRONT                           = 64,
        TARGET_DEST_TARGET_BACK                            = 65,
        TARGET_DEST_TARGET_RIGHT                           = 66,
        TARGET_DEST_TARGET_LEFT                            = 67,
        TARGET_DEST_TARGET_FRONT_RIGHT                     = 68,
        TARGET_DEST_TARGET_BACK_RIGHT                      = 69,
        TARGET_DEST_TARGET_BACK_LEFT                       = 70,
        TARGET_DEST_TARGET_FRONT_LEFT                      = 71,
        TARGET_DEST_CASTER_RANDOM                          = 72,
        TARGET_DEST_CASTER_RADIUS                          = 73,
        TARGET_DEST_TARGET_RANDOM                          = 74,
        TARGET_DEST_TARGET_RADIUS                          = 75,
        TARGET_DEST_CHANNEL_TARGET                         = 76,
        TARGET_UNIT_CHANNEL_TARGET                         = 77,
        TARGET_DEST_DEST_FRONT                             = 78,
        TARGET_DEST_DEST_BACK                              = 79,
        TARGET_DEST_DEST_RIGHT                             = 80,
        TARGET_DEST_DEST_LEFT                              = 81,
        TARGET_DEST_DEST_FRONT_RIGHT                       = 82,
        TARGET_DEST_DEST_BACK_RIGHT                        = 83,
        TARGET_DEST_DEST_BACK_LEFT                         = 84,
        TARGET_DEST_DEST_FRONT_LEFT                        = 85,
        TARGET_DEST_DEST_RANDOM                            = 86,
        TARGET_DEST_DEST                                   = 87,
        TARGET_DEST_DYNOBJ_ALL_UNITS                       = 88,
        TARGET_DEST_TRAJ                                   = 89,
        TARGET_UNIT_TARGET_MINIPET                         = 90,
        TARGET_DEST_DEST_RADIUS                            = 91,
        TARGET_UNIT_SUMMONER                               = 92,
        TARGET_CORPSE_SRC_AREA_ENEMY                       = 93, // NYI
        TARGET_UNIT_VEHICLE                                = 94,
        TARGET_UNIT_TARGET_PASSENGER                       = 95,
        TARGET_UNIT_PASSENGER_0                            = 96,
        TARGET_UNIT_PASSENGER_1                            = 97,
        TARGET_UNIT_PASSENGER_2                            = 98,
        TARGET_UNIT_PASSENGER_3                            = 99,
        TARGET_UNIT_PASSENGER_4                            = 100,
        TARGET_UNIT_PASSENGER_5                            = 101,
        TARGET_UNIT_PASSENGER_6                            = 102,
        TARGET_UNIT_PASSENGER_7                            = 103,
        TARGET_UNIT_CONE_ENEMY_104                         = 104,
        TARGET_UNIT_UNK_105                                = 105, // 1 spell
        TARGET_DEST_CHANNEL_CASTER                         = 106,
        TARGET_UNK_DEST_AREA_UNK_107                       = 107, // not enough info - only generic spells available
        TARGET_GAMEOBJECT_CONE                             = 108,
        TARGET_DEST_UNK_110                                = 110, // 1 spell
        TARGET_UNK_111                                     = 111,
        TARGET_UNK_112                                     = 112,
        TARGET_UNK_113                                     = 113,
        TARGET_UNK_114                                     = 114,
        TARGET_UNK_115                                     = 115,
        TARGET_UNK_116                                     = 116,
        TARGET_UNK_117                                     = 117,
        TARGET_UNK_118                                     = 118,
        TARGET_UNK_119                                     = 119,   // 83968 Mass Resurrection
        TARGET_UNK_120                                     = 120,
        TARGET_UNK_121                                     = 121,
        TARGET_UNK_122                                     = 122,
        TARGET_UNK_123                                     = 123,
        TOTAL_SPELL_TARGETS
    };

    ///<summary>
    ///Spell proc event related declarations (accessed using SpellMgr functions)
    ///</summary>
    [Flags]
    public enum ProcFlags
    {
        PROC_FLAG_NONE                                  = 0x00000000,

        PROC_FLAG_KILLED                                = 0x00000001,    // 00 Killed by agressor - not sure about this flag
        PROC_FLAG_KILL                                  = 0x00000002,    // 01 Kill target (in most cases need XP/Honor reward)

        PROC_FLAG_DONE_MELEE_AUTO_ATTACK                = 0x00000004,    // 02 Done melee auto attack
        PROC_FLAG_TAKEN_MELEE_AUTO_ATTACK               = 0x00000008,    // 03 Taken melee auto attack

        PROC_FLAG_DONE_SPELL_MELEE_DMG_CLASS            = 0x00000010,    // 04 Done attack by Spell that has dmg class melee
        PROC_FLAG_TAKEN_SPELL_MELEE_DMG_CLASS           = 0x00000020,    // 05 Taken attack by Spell that has dmg class melee

        PROC_FLAG_DONE_RANGED_AUTO_ATTACK               = 0x00000040,    // 06 Done ranged auto attack
        PROC_FLAG_TAKEN_RANGED_AUTO_ATTACK              = 0x00000080,    // 07 Taken ranged auto attack

        PROC_FLAG_DONE_SPELL_RANGED_DMG_CLASS           = 0x00000100,    // 08 Done attack by Spell that has dmg class ranged
        PROC_FLAG_TAKEN_SPELL_RANGED_DMG_CLASS          = 0x00000200,    // 09 Taken attack by Spell that has dmg class ranged

        PROC_FLAG_DONE_SPELL_NONE_DMG_CLASS_POS         = 0x00000400,    // 10 Done positive spell that has dmg class none
        PROC_FLAG_TAKEN_SPELL_NONE_DMG_CLASS_POS        = 0x00000800,    // 11 Taken positive spell that has dmg class none

        PROC_FLAG_DONE_SPELL_NONE_DMG_CLASS_NEG         = 0x00001000,    // 12 Done negative spell that has dmg class none
        PROC_FLAG_TAKEN_SPELL_NONE_DMG_CLASS_NEG        = 0x00002000,    // 13 Taken negative spell that has dmg class none

        PROC_FLAG_DONE_SPELL_MAGIC_DMG_CLASS_POS        = 0x00004000,    // 14 Done positive spell that has dmg class magic
        PROC_FLAG_TAKEN_SPELL_MAGIC_DMG_CLASS_POS       = 0x00008000,    // 15 Taken positive spell that has dmg class magic

        PROC_FLAG_DONE_SPELL_MAGIC_DMG_CLASS_NEG        = 0x00010000,    // 16 Done negative spell that has dmg class magic
        PROC_FLAG_TAKEN_SPELL_MAGIC_DMG_CLASS_NEG       = 0x00020000,    // 17 Taken negative spell that has dmg class magic

        PROC_FLAG_DONE_PERIODIC                         = 0x00040000,    // 18 Successful do periodic (damage / healing)
        PROC_FLAG_TAKEN_PERIODIC                        = 0x00080000,    // 19 Taken spell periodic (damage / healing)

        PROC_FLAG_TAKEN_DAMAGE                          = 0x00100000,    // 20 Taken any damage
        PROC_FLAG_DONE_TRAP_ACTIVATION                  = 0x00200000,    // 21 On trap activation (possibly needs name change to ON_GAMEOBJECT_CAST or USE)

        PROC_FLAG_DONE_MAINHAND_ATTACK                  = 0x00400000,    // 22 Done main-hand melee attacks (spell and autoattack)
        PROC_FLAG_DONE_OFFHAND_ATTACK                   = 0x00800000,    // 23 Done off-hand melee attacks (spell and autoattack)

        PROC_FLAG_DEATH                                 = 0x01000000,    // 24 Died in any way
    };

    [Flags]
    public enum ProcFlagsEx
    {
        PROC_EX_NONE                                    = 0x0000000,                 // If none can tigger on Hit/Crit only (passive spells MUST defined by SpellFamily flag)
        PROC_EX_NORMAL_HIT                              = 0x0000001,                 // If set only from normal hit (only damage spells)
        PROC_EX_CRITICAL_HIT                            = 0x0000002,
        PROC_EX_MISS                                    = 0x0000004,
        PROC_EX_RESIST                                  = 0x0000008,
        PROC_EX_DODGE                                   = 0x0000010,
        PROC_EX_PARRY                                   = 0x0000020,
        PROC_EX_BLOCK                                   = 0x0000040,
        PROC_EX_EVADE                                   = 0x0000080,
        PROC_EX_IMMUNE                                  = 0x0000100,
        PROC_EX_DEFLECT                                 = 0x0000200,
        PROC_EX_ABSORB                                  = 0x0000400,
        PROC_EX_REFLECT                                 = 0x0000800,
        PROC_EX_INTERRUPT                               = 0x0001000,                 // Melee hit result can be Interrupt (not used)
        PROC_EX_FULL_BLOCK                              = 0x0002000,                 // block al attack damage
        PROC_EX_RESERVED2                               = 0x0004000,
        PROC_EX_NOT_ACTIVE_SPELL                        = 0x0008000,                 // Spell mustn't do damage/heal to proc
        PROC_EX_EX_TRIGGER_ALWAYS                       = 0x0010000,                 // If set trigger always no matter of hit result
        PROC_EX_EX_ONE_TIME_TRIGGER                     = 0x0020000,                 // If set trigger always but only one time (not implemented yet)
        PROC_EX_ONLY_ACTIVE_SPELL                       = 0x0040000,                 // Spell has to do damage/heal to proc
    };

    public enum SpellSchoolsForProcs
    {
        NONE           = 0,
        PHYSICAL       = 1,
        HOLY           = 2,
        FIRE           = 3,
        NATURE         = 4,
        FROST          = 5,
        SHADOW         = 6,
        ARCANE         = 7
    };

    public enum SpellSchools
    {
        PHYSICAL       = 0,
        HOLY           = 1,
        FIRE           = 2,
        NATURE         = 3,
        FROST          = 4,
        SHADOW         = 5,
        ARCANE         = 6
    };

    [Flags]
    public enum SpellSchoolMask
    {
        MASK_NONE      = 0x00,                         // not exist
        MASK_PHYSICAL  = (1 << SpellSchools.PHYSICAL), // PHYSICAL (Armor)
        MASK_HOLY      = (1 << SpellSchools.HOLY),
        MASK_FIRE      = (1 << SpellSchools.FIRE),
        MASK_NATURE    = (1 << SpellSchools.NATURE),
        MASK_FROST     = (1 << SpellSchools.FROST),
        MASK_SHADOW    = (1 << SpellSchools.SHADOW),
        MASK_ARCANE    = (1 << SpellSchools.ARCANE),

        // unions

        // 124, not include normal and holy damage
        MASK_SPELL     = (MASK_FIRE | MASK_NATURE | MASK_FROST | MASK_SHADOW | MASK_ARCANE),
        // 126
        MASK_MAGIC     = (MASK_HOLY | MASK_SPELL),
        // 127
        MASK_ALL       = (MASK_PHYSICAL | MASK_MAGIC)
    };

    public enum Mechanics
    {
        MECHANIC_NONE                   = 0,
        MECHANIC_CHARM                  = 1,
        MECHANIC_DISORIENTED            = 2,
        MECHANIC_DISARM                 = 3,
        MECHANIC_DISTRACT               = 4,
        MECHANIC_FEAR                   = 5,
        MECHANIC_GRIP                   = 6,
        MECHANIC_ROOT                   = 7,
        MECHANIC_SLOW_ATTACK            = 8,
        MECHANIC_SILENCE                = 9,
        MECHANIC_SLEEP                  = 10,
        MECHANIC_SNARE                  = 11,
        MECHANIC_STUN                   = 12,
        MECHANIC_FREEZE                 = 13,
        MECHANIC_KNOCKOUT               = 14,
        MECHANIC_BLEED                  = 15,
        MECHANIC_BANDAGE                = 16,
        MECHANIC_POLYMORPH              = 17,
        MECHANIC_BANISH                 = 18,
        MECHANIC_SHIELD                 = 19,
        MECHANIC_SHACKLE                = 20,
        MECHANIC_MOUNT                  = 21,
        MECHANIC_INFECTED               = 22,
        MECHANIC_TURN                   = 23,
        MECHANIC_HORROR                 = 24,
        MECHANIC_INVULNERABILITY        = 25,
        MECHANIC_INTERRUPT              = 26,
        MECHANIC_DAZE                   = 27,
        MECHANIC_DISCOVERY              = 28,
        MECHANIC_IMMUNE_SHIELD          = 29,                         // Divine (Blessing) Shield/Protection and Ice Block
        MECHANIC_SAPPED                 = 30,
        MECHANIC_ENRAGED                = 31
    };

    public enum SpellMissInfo
    {
        SPELL_MISS_NONE                 = 0,
        SPELL_MISS_MISS                 = 1,
        SPELL_MISS_RESIST               = 2,
        SPELL_MISS_DODGE                = 3,
        SPELL_MISS_PARRY                = 4,
        SPELL_MISS_BLOCK                = 5,
        SPELL_MISS_EVADE                = 6,
        SPELL_MISS_IMMUNE               = 7,
        SPELL_MISS_IMMUNE2              = 8,
        SPELL_MISS_DEFLECT              = 9,
        SPELL_MISS_ABSORB               = 10,
        SPELL_MISS_REFLECT              = 11
    };

    [Flags]
    public enum SpellHitType
    {
        SPELL_HIT_TYPE_UNK1             = 0x00001,
        SPELL_HIT_TYPE_CRIT             = 0x00002,
        SPELL_HIT_TYPE_UNK3             = 0x00004,
        SPELL_HIT_TYPE_UNK4             = 0x00008,
        SPELL_HIT_TYPE_UNK5             = 0x00010,                          // replace caster?
        SPELL_HIT_TYPE_UNK6             = 0x00020
    };

    public enum SpellDmgClass
    {
        SPELL_DAMAGE_CLASS_NONE         = 0,
        SPELL_DAMAGE_CLASS_MAGIC        = 1,
        SPELL_DAMAGE_CLASS_MELEE        = 2,
        SPELL_DAMAGE_CLASS_RANGED       = 3
    };

    public enum SpellPreventionType
    {
        SPELL_PREVENTION_TYPE_NONE      = 0,
        SPELL_PREVENTION_TYPE_SILENCE   = 1,
        SPELL_PREVENTION_TYPE_PACIFY    = 2
    };

    [Flags]
    public enum ShapeshiftFormMask
    {
        FORM_ALL                        = -1,
        FORM_NONE                       = 0,
        FORM_CAT                        = 1 << 0x00,
        FORM_TREE                       = 1 << 0x01,
        FORM_TRAVEL                     = 1 << 0x02,
        FORM_AQUA                       = 1 << 0x03,
        FORM_BEAR                       = 1 << 0x04,
        FORM_AMBIENT                    = 1 << 0x05,
        FORM_GHOUL                      = 1 << 0x06,
        //FORM_DIREBEAR                 = 0x07, // removed in 4.0.1
        FORM_STEVES_GHOUL               = 1 << 0x08,
        FORM_THARONJA_SKELETON          = 1 << 0x09,
        FORM_TEST_OF_STRENGTH           = 1 << 0x0A,
        FORM_BLB_PLAYER                 = 1 << 0x0B,
        FORM_SHADOW_DANCE               = 1 << 0x0C,
        FORM_CREATUREBEAR               = 1 << 0x0D,
        FORM_CREATURECAT                = 1 << 0x0E,
        FORM_GHOSTWOLF                  = 1 << 0x0F,
        FORM_BATTLESTANCE               = 1 << 0x10,
        FORM_DEFENSIVESTANCE            = 1 << 0x11,
        FORM_BERSERKERSTANCE            = 1 << 0x12,
        FORM_TEST                       = 1 << 0x13,
        FORM_ZOMBIE                     = 1 << 0x14,
        FORM_METAMORPHOSIS              = 1 << 0x15,
        FORM_UNDEAD                     = 1 << 0x18,
        FORM_MASTER_ANGLER              = 1 << 0x19,
        FORM_FLIGHT_EPIC                = 1 << 0x1A,
        FORM_SHADOW                     = 1 << 0x1B,
        FORM_FLIGHT                     = 1 << 0x1C,
        FORM_STEALTH                    = 1 << 0x1D,
        FORM_MOONKIN                    = 1 << 0x1E,
        FORM_SPIRITOFREDEMPTION         = 1 << 0x1F
   };

    public enum DispelType
    {
        DISPEL_NONE                     = 0,
        DISPEL_MAGIC                    = 1,
        DISPEL_CURSE                    = 2,
        DISPEL_DISEASE                  = 3,
        DISPEL_POISON                   = 4,
        DISPEL_STEALTH                  = 5,
        DISPEL_INVISIBILITY             = 6,
        DISPEL_ALL                      = 7,
        DISPEL_SPE_NPC_ONLY             = 8,
        DISPEL_ENRAGE                   = 9,
        DISPEL_ZG_TICKET                = 10,
        DESPEL_OLD_UNUSED               = 11
    };

    public enum SpellModOp
    {
        SPELLMOD_DAMAGE                 = 0,
        SPELLMOD_DURATION               = 1,
        SPELLMOD_THREAT                 = 2,
        SPELLMOD_EFFECT1                = 3,
        SPELLMOD_CHARGES                = 4,
        SPELLMOD_RANGE                  = 5,
        SPELLMOD_RADIUS                 = 6,
        SPELLMOD_CRITICAL_CHANCE        = 7,
        SPELLMOD_ALL_EFFECTS            = 8,
        SPELLMOD_NOT_LOSE_CASTING_TIME  = 9,
        SPELLMOD_CASTING_TIME           = 10,
        SPELLMOD_COOLDOWN               = 11,
        SPELLMOD_EFFECT2                = 12,
        SPELLMOD_IGNORE_ARMOR           = 13,
        SPELLMOD_COST                   = 14,
        SPELLMOD_CRIT_DAMAGE_BONUS      = 15,
        SPELLMOD_RESIST_MISS_CHANCE     = 16,
        SPELLMOD_JUMP_TARGETS           = 17,
        SPELLMOD_CHANCE_OF_SUCCESS      = 18,
        SPELLMOD_ACTIVATION_TIME        = 19,
        SPELLMOD_DAMAGE_MULTIPLIER      = 20,
        SPELLMOD_GLOBAL_COOLDOWN        = 21,
        SPELLMOD_DOT                    = 22,
        SPELLMOD_EFFECT3                = 23,
        SPELLMOD_BONUS_MULTIPLIER       = 24,
        // spellmod 25
        SPELLMOD_PROC_PER_MINUTE        = 26,
        SPELLMOD_VALUE_MULTIPLIER       = 27,
        SPELLMOD_RESIST_DISPEL_CHANCE   = 28,
        SPELLMOD_CRIT_DAMAGE_BONUS_2    = 29, //one not used spell
        SPELLMOD_SPELL_COST_REFUND_ON_FAIL = 30
    };

    [Flags]
    public enum SpellCastTargetFlags
    {
        TARGET_FLAG_NONE            = 0x00000000,
        TARGET_FLAG_UNUSED_1        = 0x00000001,               // not used
        TARGET_FLAG_UNIT            = 0x00000002,               // pguid
        TARGET_FLAG_UNIT_RAID       = 0x00000004,               // not sent, used to validate target (if raid member)
        TARGET_FLAG_UNIT_PARTY      = 0x00000008,               // not sent, used to validate target (if party member)
        TARGET_FLAG_ITEM            = 0x00000010,               // pguid
        TARGET_FLAG_SOURCE_LOCATION = 0x00000020,               // pguid, 3 float
        TARGET_FLAG_DEST_LOCATION   = 0x00000040,               // pguid, 3 float
        TARGET_FLAG_UNIT_ENEMY      = 0x00000080,               // not sent, used to validate target (if enemy)
        TARGET_FLAG_UNIT_ALLY       = 0x00000100,               // not sent, used to validate target (if ally)
        TARGET_FLAG_CORPSE_ENEMY    = 0x00000200,               // pguid
        TARGET_FLAG_UNIT_DEAD       = 0x00000400,               // not sent, used to validate target (if dead creature)
        TARGET_FLAG_GAMEOBJECT      = 0x00000800,               // pguid, used with TARGET_GAMEOBJECT_TARGET
        TARGET_FLAG_TRADE_ITEM      = 0x00001000,               // pguid
        TARGET_FLAG_STRING          = 0x00002000,               // string
        TARGET_FLAG_GAMEOBJECT_ITEM = 0x00004000,               // not sent, used with TARGET_GAMEOBJECT_ITEM_TARGET
        TARGET_FLAG_CORPSE_ALLY     = 0x00008000,               // pguid
        TARGET_FLAG_UNIT_MINIPET    = 0x00010000,               // pguid, used to validate target (if non combat pet)
        TARGET_FLAG_GLYPH_SLOT      = 0x00020000,               // used in glyph spells
        TARGET_FLAG_DEST_TARGET     = 0x00040000,               // sometimes appears with DEST_TARGET spells (may appear or not for a given spell)
        TARGET_FLAG_UNUSED20        = 0x00080000,               // uint32 counter, loop { vec3 - screen position (?), guid }, not used so far
        TARGET_FLAG_UNIT_PASSENGER  = 0x00100000,               // guessed, used to validate target (if vehicle passenger)
    };

    public enum Powers : uint
    {
        POWER_MANA                               = 0,
        POWER_RAGE                               = 1,
        POWER_FOCUS                              = 2,
        POWER_ENERGY                             = 3,
        POWER_HAPPINESS                          = 4,
        POWER_RUNE                               = 5,
        POWER_RUNIC_POWER                        = 6,
        POWER_SOULSHARDS                         = 7,
        POWER_ECLIPSE                            = 8,
        POWER_HOLY_POWER                         = 9,
        // POWER_ALTERNATIVE                     = 10,  // Used in some quests
        MAX_POWERS                               = 10,
        POWER_ALL                                = 127, // default for class?
        POWER_HEALTH                             = 0xFFFFFFFE // (-2 as signed value)
    };

    public enum AuraState
    {   // (C) used in caster aura state     (T) used in target aura state
        // (c) used in caster aura state-not (t) used in target aura state-not
        AURA_STATE_NONE                                     = 0,            // C   |
        AURA_STATE_DEFENSE                                  = 1,            // C   |
        AURA_STATE_HEALTHLESS_20_PERCENT                    = 2,            // CcT |
        AURA_STATE_BERSERKING                               = 3,            // C T |
        AURA_STATE_FROZEN                                   = 4,            //  c t| frozen target
        AURA_STATE_JUDGEMENT                                = 5,            // C   |
        //AURA_STATE_UNKNOWN6                               = 6,            //     | not used
        AURA_STATE_HUNTER_PARRY                             = 7,            // C   |
        //AURA_STATE_UNKNOWN7                               = 7,            //  c  | creature cheap shot / focused bursts spells
        //AURA_STATE_UNKNOWN8                               = 8,            //    t| test spells
        //AURA_STATE_UNKNOWN9                               = 9,            //     |
        AURA_STATE_WARRIOR_VICTORY_RUSH                     = 10,           // C   | warrior victory rush
        //AURA_STATE_UNKNOWN11                              = 11,           // C  t| 60348 - Maelstrom Ready!, test spells
        AURA_STATE_FAERIE_FIRE                              = 12,           //  c t|
        AURA_STATE_HEALTHLESS_35_PERCENT                    = 13,           // C T |
        AURA_STATE_CONFLAGRATE                              = 14,           //   T |
        AURA_STATE_SWIFTMEND                                = 15,           //   T |
        AURA_STATE_DEADLY_POISON                            = 16,           //   T |
        AURA_STATE_ENRAGE                                   = 17,           // C   |
        AURA_STATE_BLEEDING                                 = 18,           //    T|
        AURA_STATE_UNKNOWN19                                = 19,           //     |
        //AURA_STATE_UNKNOWN20                              = 20,           //  c  | only (45317 Suicide)
        //AURA_STATE_UNKNOWN21                              = 21,           //     | not used
        AURA_STATE_UNKNOWN22                                = 22,           // C  t| various spells (63884, 50240)
        AURA_STATE_HEALTH_ABOVE_75_PERCENT                  = 23,           // C   |
    };

    [Flags]
    enum InventoryTypeMask
    {
        ALL             = -1,
        NON_EQUIP       = 1 << 0,
        HEAD            = 1 << 1,
        NECK            = 1 << 2,
        SHOULDERS       = 1 << 3,
        BODY            = 1 << 4,
        CHEST           = 1 << 5,
        WAIST           = 1 << 6,
        LEGS            = 1 << 7,
        FEET            = 1 << 8,
        WRISTS          = 1 << 9,
        HANDS           = 1 << 10,
        FINGER          = 1 << 11,
        TRINKET         = 1 << 12,
        WEAPON          = 1 << 13,
        SHIELD          = 1 << 14,
        RANGED          = 1 << 15,
        CLOAK           = 1 << 16,
        WEAPON_2H       = 1 << 17,
        BAG             = 1 << 18,
        TABARD          = 1 << 19,
        ROBE            = 1 << 20,
        WEAPONMAINHAND  = 1 << 21,
        WEAPONOFFHAND   = 1 << 22,
        HOLDABLE        = 1 << 23,
        AMMO            = 1 << 24,
        THROWN          = 1 << 25,
        RANGEDRIGHT     = 1 << 26,
        QUIVER          = 1 << 27,
        RELIC           = 1 << 28,
    };

    public enum ItemClass
    {
        CONSUMABLE                       = 0,
        CONTAINER                        = 1,
        WEAPON                           = 2,
        GEM                              = 3,
        ARMOR                            = 4,
        REAGENT                          = 5,
        PROJECTILE                       = 6,
        TRADE_GOODS                      = 7,
        GENERIC                          = 8,
        RECIPE                           = 9,
        MONEY                            = 10,
        QUIVER                           = 11,
        QUEST                            = 12,
        KEY                              = 13,
        NOT_EXIST                        = 14,
        MISC                             = 15,
        GLYPH                            = 16,
        MAX
    };

    [Flags]
    public enum ItemSubClassWeaponMask
    {
        ALL             = -1,
        AXE             = 1 << 0,
        AXE2            = 1 << 1,
        BOW             = 1 << 2,
        GUN             = 1 << 3,
        MACE            = 1 << 4,
        MACE2           = 1 << 5,
        POLEARM         = 1 << 6,
        SWORD           = 1 << 7,
        SWORD2          = 1 << 8,
        //obsolete        = 1 << 9,
        STAFF           = 1 << 10,
        //EXOTIC          = 1 << 11,
        //EXOTIC2         = 1 << 12,
        FIST            = 1 << 13,
        MISC            = 1 << 14,
        DAGGER          = 1 << 15,
        THROWN          = 1 << 16,
        //SPEAR           = 1 << 17,
        CROSSBOW        = 1 << 18,
        WAND            = 1 << 19,
        FISHING_POLE    = 1 << 20
    };

    [Flags]
    public enum ItemSubClassArmorMask
    {
        ALL             = -1,
        MISC            = 1 << 0,
        CLOTH           = 1 << 1,
        LEATHER         = 1 << 2,
        MAIL            = 1 << 3,
        PLATE           = 1 << 4,
        //BUCKLER       = 1 << 5,
        SHIELD          = 1 << 6,
        //LIBRAM        = 1 << 7,
        //IDOL          = 1 << 8,
        //TOTEM         = 1 << 9,
        //SIGIL         = 1 << 10,
        RELIC           = 1 << 11
    };

    [Flags]
    public enum ItemSubClassMiscMask
    {
        ALL             = -1,
        JUNK            = 1 << 0,
        REAGENT         = 1 << 1,
        PET             = 1 << 2,
        HOLIDAY         = 1 << 3,
        OTHER           = 1 << 4,
        MOUNT           = 1 << 5,
        UNK12           = 1 << 12
    }

    [Flags]
    public enum CreatureTypeMask
    {
        ALL             = -1,
        NONE            = 0,
        BEAST           = 1 << 0,
        DRAGONKIN       = 1 << 1,
        DEMON           = 1 << 2,
        ELEMENTAL       = 1 << 3,
        GIANT           = 1 << 4,
        UNDEAD          = 1 << 5,
        HUMANOID        = 1 << 6,
        CRITTER         = 1 << 7,
        MECHANICAL      = 1 << 8,
        NOT_SPECIFIED   = 1 << 9,
        TOTEM           = 1 << 10,
        NON_COMBAT_PET  = 1 << 11,
        GAS_CLOUD       = 1 << 12
    };

    [Flags]
    public enum SpellAtribute
    {
        SPELL_ATTR_EX0_ALL                              = -1,
        SPELL_ATTR0_UNK0                                = 0x00000001, //  0
        SPELL_ATTR0_REQ_AMMO                            = 0x00000002, //  1 on next ranged
        SPELL_ATTR0_ON_NEXT_SWING                       = 0x00000004, //  2
        SPELL_ATTR0_UNK3                                = 0x00000008, //  3 not set in 3.0.3
        SPELL_ATTR0_ABILITY                             = 0x00000010, //  4 client puts 'ability' instead of 'spell' in game strings for these spells
        SPELL_ATTR0_TRADESPELL                          = 0x00000020, //  5 trade spells (recipes), will be added by client to a sublist of profession spell
        SPELL_ATTR0_PASSIVE                             = 0x00000040, //  6 Passive spell
        SPELL_ATTR0_HIDDEN_CLIENTSIDE                   = 0x00000080, //  7 Spells with this attribute are not visible in spellbook or aura bar
        SPELL_ATTR0_HIDE_IN_COMBAT_LOG                  = 0x00000100, //  8 This attribite controls whether spell appears in combat logs
        SPELL_ATTR0_TARGET_MAINHAND_ITEM                = 0x00000200, //  9 Client automatically selects item from mainhand slot as a cast target
        SPELL_ATTR0_ON_NEXT_SWING_2                     = 0x00000400, // 10
        SPELL_ATTR0_UNK11                               = 0x00000800, // 11
        SPELL_ATTR0_DAYTIME_ONLY                        = 0x00001000, // 12 only useable at daytime, not set in 2.4.2
        SPELL_ATTR0_NIGHT_ONLY                          = 0x00002000, // 13 only useable at night, not set in 2.4.2
        SPELL_ATTR0_INDOORS_ONLY                        = 0x00004000, // 14 only useable indoors, not set in 2.4.2
        SPELL_ATTR0_OUTDOORS_ONLY                       = 0x00008000, // 15 Only useable outdoors.
        SPELL_ATTR0_NOT_SHAPESHIFT                      = 0x00010000, // 16 Not while shapeshifted
        SPELL_ATTR0_ONLY_STEALTHED                      = 0x00020000, // 17 Must be in stealth
        SPELL_ATTR0_DONT_AFFECT_SHEATH_STATE            = 0x00040000, // 18 client won't hide unit weapons in sheath on cast/channel
        SPELL_ATTR0_LEVEL_DAMAGE_CALCULATION            = 0x00080000, // 19 spell damage depends on caster level
        SPELL_ATTR0_STOP_ATTACK_TARGET                  = 0x00100000, // 20 Stop attack after use this spell (and not begin attack if use)
        SPELL_ATTR0_IMPOSSIBLE_DODGE_PARRY_BLOCK        = 0x00200000, // 21 Cannot be dodged/parried/blocked
        SPELL_ATTR0_CAST_TRACK_TARGET                   = 0x00400000, // 22 Client automatically forces player to face target when casting
        SPELL_ATTR0_CASTABLE_WHILE_DEAD                 = 0x00800000, // 23 can cast while dead?
        SPELL_ATTR0_CASTABLE_WHILE_MOUNTED              = 0x01000000, // 24 can cast while mounted
        SPELL_ATTR0_DISABLED_WHILE_ACTIVE               = 0x02000000, // 25 Activate and start cooldown after aura fade or remove summoned creature or go
        SPELL_ATTR0_NEGATIVE_1                          = 0x04000000, // 26 Many negative spells have this attr
        SPELL_ATTR0_CASTABLE_WHILE_SITTING              = 0x08000000, // 27 can cast while sitting
        SPELL_ATTR0_CANT_USED_IN_COMBAT                 = 0x10000000, // 28 Cannot be used in combat
        SPELL_ATTR0_UNAFFECTED_BY_INVULNERABILITY       = 0x20000000, // 29 unaffected by invulnerability (hmm possible not...)
        SPELL_ATTR0_BREAKABLE_BY_DAMAGE                 = 0x40000000, // 30
        SPELL_ATTR0_CANT_CANCEL                         = 0x1F,  // 31 positive aura can't be cancelled
    };

    [Flags]
    public enum SpellAtributeEx
    {
        SPELL_ATTR_EX1_ALL                              = -1,
        SPELL_ATTR1_DISMISS_PET                         = 0x00000001, //  0 for spells without this flag client doesn't allow to summon pet if caster has a pet
        SPELL_ATTR1_DRAIN_ALL_POWER                     = 0x00000002, //  1 use all power (Only paladin Lay of Hands and Bunyanize)
        SPELL_ATTR1_CHANNELED_1                         = 0x00000004, //  2 clientside checked? cancelable?
        SPELL_ATTR1_CANT_BE_REDIRECTED                  = 0x00000008, //  3 used for detecting if a spell can/can not be reflected
        SPELL_ATTR1_UNK4                                = 0x00000010, //  4 stealth and whirlwind
        SPELL_ATTR1_NOT_BREAK_STEALTH                   = 0x00000020, //  5 Not break stealth
        SPELL_ATTR1_CHANNELED_2                         = 0x00000040, //  6
        SPELL_ATTR1_CANT_BE_REFLECTED                   = 0x00000080, //  7
        SPELL_ATTR1_CANT_TARGET_IN_COMBAT               = 0x00000100, //  8 Spell req target not to be in combat state
        SPELL_ATTR1_MELEE_COMBAT_START                  = 0x00000200, //  9 player starts melee combat after this spell is cast
        SPELL_ATTR1_NO_THREAT                           = 0x00000400, // 10 no generates threat on cast 100% (old NO_INITIAL_AGGRO)
        SPELL_ATTR1_UNK11                               = 0x00000800, // 11 aura
        SPELL_ATTR1_UNK12                               = 0x00001000, // 12
        SPELL_ATTR1_FARSIGHT                            = 0x00002000, // 13 Client removes farsight on aura loss
        SPELL_ATTR1_CHANNEL_TRACK_TARGET                = 0x00004000, // 14 Client automatically forces player to face target when channeling
        SPELL_ATTR1_DISPEL_AURAS_ON_IMMUNITY            = 0x00008000, // 15 remove auras on immunity
        SPELL_ATTR1_UNAFFECTED_BY_SCHOOL_IMMUNE         = 0x00010000, // 16 unaffected by school immunity
        SPELL_ATTR1_UNAUTOCASTABLE_BY_PET               = 0x00020000, // 17 for auras SPELL_AURA_TRACK_CREATURES, SPELL_AURA_TRACK_RESOURCES and SPELL_AURA_TRACK_STEALTHED select non-stacking tracking spells
        SPELL_ATTR1_UNK18                               = 0x00040000, // 18 auras with this attribute are broken by any damage (not CrowdControl auras)
        SPELL_ATTR1_CANT_TARGET_SELF                    = 0x00080000, // 19
        SPELL_ATTR1_REQ_COMBO_POINTS1                   = 0x00100000, // 20 Req combo points on target
        SPELL_ATTR1_UNK21                               = 0x00200000, // 21
        SPELL_ATTR1_REQ_COMBO_POINTS2                   = 0x00400000, // 22 Use combo points (in 4.x not required combo point target selected)
        SPELL_ATTR1_UNK23                               = 0x00800000, // 23
        SPELL_ATTR1_UNK24                               = 0x01000000, // 24 only fishing spells
        SPELL_ATTR1_UNK25                               = 0x02000000, // 25
        SPELL_ATTR1_UNK26                               = 0x04000000, // 26 works correctly with [target=focus] and [target=mouseover] macros?
        SPELL_ATTR1_UNK27                               = 0x08000000, // 27
        SPELL_ATTR1_DONT_DISPLAY_IN_AURA_BAR            = 0x10000000, // 28 client doesn't display these spells in aura bar
        SPELL_ATTR1_CHANNEL_DISPLAY_SPELL_NAME          = 0x20000000, // 29 spell name is displayed in cast bar instead of 'channeling' text
        SPELL_ATTR1_ENABLE_AT_DODGE                     = 0x40000000, // 30 Overpower, Wolverine Bite
        SPELL_ATTR1_UNK31                               = 0x1F,  // 31
    };

    [Flags]
    public enum SpellAtributeEx2
    {
        SPELL_ATTR_EX2_ALL                              = -1,
        SPELL_ATTR2_CAN_TARGET_DEAD                     = 0x00000001, //  0 can target dead unit or corpse
        SPELL_ATTR2_UNK1                                = 0x00000002, //  1 ? many triggered spells have this flag
        SPELL_ATTR2_CAN_TARGET_NOT_IN_LOS               = 0x00000004, //  2 do not need LOS (26368 4.0.1 dbc change)
        SPELL_ATTR2_UNK3                                = 0x00000008, //  3 auto targeting? (e.g. fishing skill enhancement items)
        SPELL_ATTR2_DISPLAY_IN_STANCE_BAR               = 0x00000010, //  4 client displays icon in stance bar when learned, even if not shapeshift
        SPELL_ATTR2_AUTOREPEAT_FLAG                     = 0x00000020, //  5
        SPELL_ATTR2_CANT_TARGET_TAPPED                  = 0x00000040, //  6 target must be tapped by caster
        SPELL_ATTR2_UNK7                                = 0x00000080, //  7
        SPELL_ATTR2_UNK8                                = 0x00000100, //  8 not set in 3.0.3
        SPELL_ATTR2_UNK9                                = 0x00000200, //  9
        SPELL_ATTR2_UNK10                               = 0x00000400, // 10
        SPELL_ATTR2_HEALTH_FUNNEL                       = 0x00000800, // 11
        SPELL_ATTR2_UNK12                               = 0x00001000, // 12
        SPELL_ATTR2_UNK13                               = 0x00002000, // 13 Items enchanted by spells with this flag preserve the enchant to arenas
        SPELL_ATTR2_UNK14                               = 0x00004000, // 14
        SPELL_ATTR2_UNK15                               = 0x00008000, // 15 not set in 3.0.3
        SPELL_ATTR2_TAME_BEAST                          = 0x00010000, // 16
        SPELL_ATTR2_NOT_RESET_AUTO_ACTIONS              = 0x00020000, // 17 don't reset timers for melee autoattacks (swings) or ranged autoattacks (autoshots)
        SPELL_ATTR2_UNK18                               = 0x00040000, // 18 Only Revive pet - possible req dead pet
        SPELL_ATTR2_NOT_NEED_SHAPESHIFT                 = 0x00080000, // 19 does not necessarily need shapeshift
        SPELL_ATTR2_UNK20                               = 0x00100000, // 20
        SPELL_ATTR2_DAMAGE_REDUCED_SHIELD               = 0x00200000, // 21 for ice blocks, paladin immunity buffs, priest absorb shields, but used also for other spells -> not sure!
        SPELL_ATTR2_UNK22                               = 0x00400000, // 22
        SPELL_ATTR2_UNK23                               = 0x00800000, // 23 Only mage Arcane Concentration have this flag
        SPELL_ATTR2_UNK24                               = 0x01000000, // 24
        SPELL_ATTR2_UNK25                               = 0x02000000, // 25
        SPELL_ATTR2_UNK26                               = 0x04000000, // 26 unaffected by school immunity
        SPELL_ATTR2_UNK27                               = 0x08000000, // 27
        SPELL_ATTR2_UNK28                               = 0x10000000, // 28 no breaks stealth if it fails??
        SPELL_ATTR2_CANT_CRIT                           = 0x20000000, // 29 Spell can't crit
        SPELL_ATTR2_TRIGGERED_CAN_TRIGGER_PROC          = 0x40000000, // 30 spell can trigger even if triggered
        SPELL_ATTR2_FOOD_BUFF                           = 0x1F,  // 31 Food or Drink Buff (like Well Fed)
    };

    [Flags]
    public enum SpellAtributeEx3
    {
        SPELL_ATTR_EX3_ALL                              = -1,
        SPELL_ATTR3_UNK0                                = 0x00000001, //  0
        SPELL_ATTR3_UNK1                                = 0x00000002, //  1
        SPELL_ATTR3_UNK2                                = 0x00000004, //  2
        SPELL_ATTR3_BLOCKABLE_SPELL                     = 0x00000008, //  3 Only dmg class melee in 3.1.3
        SPELL_ATTR3_IGNORE_RESURRECTION_TIMER           = 0x00000010, //  4 you don't have to wait to be resurrected with these spells
        SPELL_ATTR3_UNK5                                = 0x00000020, //  5
        SPELL_ATTR3_UNK6                                = 0x00000040, //  6
        SPELL_ATTR3_STACK_FOR_DIFF_CASTERS              = 0x00000080, //  7 separate stack for every caster
        SPELL_ATTR3_ONLY_TARGET_PLAYERS                 = 0x00000100, //  8 can only target players
        SPELL_ATTR3_TRIGGERED_CAN_TRIGGER_PROC_2        = 0x00000200, //  9 triggered from effect?
        SPELL_ATTR3_MAIN_HAND                           = 0x00000400, // 10 Main hand weapon required
        SPELL_ATTR3_BATTLEGROUND                        = 0x00000800, // 11 Can casted only on battleground
        SPELL_ATTR3_ONLY_TARGET_GHOSTS                  = 0x00001000, // 12
        SPELL_ATTR3_UNK13                               = 0x00002000, // 13
        SPELL_ATTR3_UNK14                               = 0x00004000, // 14 "Honorless Target" only this spells have this flag
        SPELL_ATTR3_UNK15                               = 0x00008000, // 15 Auto Shoot, Shoot, Throw,  - this is autoshot flag
        SPELL_ATTR3_CANT_TRIGGER_PROC                   = 0x00010000, // 16 confirmed with many patch notes
        SPELL_ATTR3_NO_INITIAL_AGGRO                    = 0x00020000, // 17 Soothe Animal, 39758, Mind Soothe
        SPELL_ATTR3_IGNORE_HIT_RESULT                   = 0x00040000, // 18 Spell should always hit its target
        SPELL_ATTR3_DISABLE_PROC                        = 0x00080000, // 19 during aura proc no spells can trigger (20178, 20375)
        SPELL_ATTR3_DEATH_PERSISTENT                    = 0x00100000, // 20 Death persistent spells
        SPELL_ATTR3_UNK21                               = 0x00200000, // 21
        SPELL_ATTR3_REQ_WAND                            = 0x00400000, // 22 Req wand
        SPELL_ATTR3_UNK23                               = 0x00800000, // 23
        SPELL_ATTR3_REQ_OFFHAND                         = 0x01000000, // 24 Req offhand weapon
        SPELL_ATTR3_UNK25                               = 0x02000000, // 25 no cause spell pushback ?
        SPELL_ATTR3_CAN_PROC_WITH_TRIGGERED             = 0x04000000, // 26 auras with this attribute can proc from triggered spell casts with SPELL_ATTR3_TRIGGERED_CAN_TRIGGER_PROC_2 (67736 + 52999)
        SPELL_ATTR3_DRAIN_SOUL                          = 0x08000000, // 27 only drain soul has this flag
        SPELL_ATTR3_UNK28                               = 0x10000000, // 28
        SPELL_ATTR3_NO_DONE_BONUS                       = 0x20000000, // 29 Ignore caster spellpower and done damage mods?  client doesn't apply spellmods for those spells
        SPELL_ATTR3_DONT_DISPLAY_RANGE                  = 0x40000000, // 30 client doesn't display range in tooltip for those spells
        SPELL_ATTR3_UNK31                               = 0x1F,  // 31
    };

    [Flags]
    public enum SpellAtributeEx4
    {
        SPELL_ATTR_EX4_ALL                              = -1,
        SPELL_ATTR4_IGNORE_RESISTANCES                  = 0x00000001, //  0 spells with this attribute will completely ignore the target resistances (these spells cant be resisted)
        SPELL_ATTR4_PROC_ONLY_ON_DUMMY                  = 0x00000002, //  1 proc only on SPELL_EFFECT_DUMMY?
        SPELL_ATTR4_UNK2                                = 0x00000004, //  2
        SPELL_ATTR4_UNK3                                = 0x00000008, //  3
        SPELL_ATTR4_UNK4                                = 0x00000010, //  4 This will no longer cause guards to attack on use??
        SPELL_ATTR4_UNK5                                = 0x00000020, //  5
        SPELL_ATTR4_NOT_STEALABLE                       = 0x00000040, //  6 although such auras might be dispelled, they cannot be stolen
        SPELL_ATTR4_TRIGGERED                           = 0x00000080, //  7 spells forced to be triggered
        SPELL_ATTR4_UNK8                                = 0x00000100, //  8 ignores taken percent damage mods (no effect on non DoTs)
        SPELL_ATTR4_UNK9                                = 0x00000200, //  9
        SPELL_ATTR4_SPELL_VS_EXTEND_COST                = 0x00000400, // 10 Rogue Shiv have this flag
        SPELL_ATTR4_UNK11                               = 0x00000800, // 11
        SPELL_ATTR4_UNK12                               = 0x00001000, // 12
        SPELL_ATTR4_UNK13                               = 0x00002000, // 13
        SPELL_ATTR4_DAMAGE_DOESNT_BREAK_AURAS           = 0x00004000, // 14 doesn't break auras by damage from these spells
        SPELL_ATTR4_UNK15                               = 0x00008000, // 15
        SPELL_ATTR4_NOT_USABLE_IN_ARENA                 = 0x00010000, // 16 not usable in arena
        SPELL_ATTR4_USABLE_IN_ARENA                     = 0x00020000, // 17 usable in arena
        SPELL_ATTR4_AREA_TARGET_CHAIN                   = 0x00040000, // 18 (NYI)hits area targets one after another instead of all at once
        SPELL_ATTR4_UNK19                               = 0x00080000, // 19
        SPELL_ATTR4_NOT_CHECK_SELFCAST_POWER            = 0x00100000, // 20 supersedes message "More powerful spell applied" for self casts.
        SPELL_ATTR4_UNK21                               = 0x00200000, // 21
        SPELL_ATTR4_UNK22                               = 0x00400000, // 22
        SPELL_ATTR4_UNK23                               = 0x00800000, // 23
        SPELL_ATTR4_UNK24                               = 0x01000000, // 24
        SPELL_ATTR4_UNK25                               = 0x02000000, // 25 pet scaling auras
        SPELL_ATTR4_CAST_ONLY_IN_OUTLAND                = 0x04000000, // 26 Can only be used in Outland.
        SPELL_ATTR4_UNK27                               = 0x08000000, // 27
        SPELL_ATTR4_UNK28                               = 0x10000000, // 28
        SPELL_ATTR4_UNK29                               = 0x20000000, // 29
        SPELL_ATTR4_UNK30                               = 0x40000000, // 30
        SPELL_ATTR4_UNK31                               = 0x1F,  // 31
    };

    [Flags]
    public enum SpellAtributeEx5
    {
        SPELL_ATTR_EX5_ALL                              = -1,
        SPELL_ATTR5_UNK0                                = 0x00000001, //  0
        SPELL_ATTR5_NO_REAGENT_WHILE_PREP               = 0x00000002, //  1 not need reagents if UNIT_FLAG_PREPARATION
        SPELL_ATTR5_UNK2                                = 0x00000004, //  2 removed at enter arena (e.g. 31850 since 3.3.3)
        SPELL_ATTR5_USABLE_WHILE_STUNNED                = 0x00000008, //  3 usable while stunned
        SPELL_ATTR5_UNK4                                = 0x00000010, //  4
        SPELL_ATTR5_SINGLE_TARGET_SPELL                 = 0x00000020, //  5 Only one target can be apply at a time
        SPELL_ATTR5_UNK6                                = 0x00000040, //  6
        SPELL_ATTR5_UNK7                                = 0x00000080, //  7
        SPELL_ATTR5_UNK8                                = 0x00000100, //  8
        SPELL_ATTR5_START_PERIODIC_AT_APPLY             = 0x00000200, //  9 begin periodic tick at aura apply
        SPELL_ATTR5_HIDE_DURATION                       = 0x00000400, // 10 do not send duration to client
        SPELL_ATTR5_ALLOW_TARGET_OF_TARGET_AS_TARGET    = 0x00000800, // 11 (NYI) uses target's target as target if original target not valid (intervene for example)
        SPELL_ATTR5_UNK12                               = 0x00001000, // 12
        SPELL_ATTR5_HASTE_AFFECT_DURATION               = 0x00002000, // 13 haste effects decrease duration of this
        SPELL_ATTR5_UNK14                               = 0x00004000, // 14
        SPELL_ATTR5_UNK15                               = 0x00008000, // 15
        SPELL_ATTR5_SPECIAL_ITEM_CLASS_CHECK            = 0x00010000, // 16 this allows spells with EquippedItemClass to affect spells from other items if the required item is equipped
        SPELL_ATTR5_USABLE_WHILE_FEARED                 = 0x00020000, // 17 usable while feared
        SPELL_ATTR5_USABLE_WHILE_CONFUSED               = 0x00040000, // 18 usable while confused
        SPELL_ATTR5_UNK19                               = 0x00080000, // 19
        SPELL_ATTR5_UNK20                               = 0x00100000, // 20
        SPELL_ATTR5_UNK21                               = 0x00200000, // 21
        SPELL_ATTR5_UNK22                               = 0x00400000, // 22
        SPELL_ATTR5_UNK23                               = 0x00800000, // 23
        SPELL_ATTR5_UNK24                               = 0x01000000, // 24
        SPELL_ATTR5_UNK25                               = 0x02000000, // 25
        SPELL_ATTR5_UNK26                               = 0x04000000, // 26
        SPELL_ATTR5_UNK27                               = 0x08000000, // 27
        SPELL_ATTR5_UNK28                               = 0x10000000, // 28
        SPELL_ATTR5_UNK29                               = 0x20000000, // 29
        SPELL_ATTR5_UNK30                               = 0x40000000, // 30
        SPELL_ATTR5_UNK31                               = 0x1F,  // 31 Forces all nearby enemies to focus attacks caster
    };

    [Flags]
    public enum SpellAtributeEx6
    {
        SPELL_ATTR_EX6_ALL                              =        -1,
        SPELL_ATTR6_DONT_DISPLAY_COOLDOWN               = 0x00000001, //  0 client doesn't display cooldown in tooltip for these spells
        SPELL_ATTR6_ONLY_IN_ARENA                       = 0x00000002, //  1 only usable in arena
        SPELL_ATTR6_IGNORE_CASTER_AURAS                 = 0x00000004, //  2
        SPELL_ATTR6_UNK3                                = 0x00000008, //  3
        SPELL_ATTR6_UNK4                                = 0x00000010, //  4
        SPELL_ATTR6_UNK5                                = 0x00000020, //  5
        SPELL_ATTR6_UNK6                                = 0x00000040, //  6
        SPELL_ATTR6_UNK7                                = 0x00000080, //  7
        SPELL_ATTR6_CANT_TARGET_CROWD_CONTROLLED        = 0x00000100, //  8
        SPELL_ATTR6_UNK9                                = 0x00000200, //  9
        SPELL_ATTR6_CAN_TARGET_POSSESSED_FRIENDS        = 0x00000400, // 10 NYI!
        SPELL_ATTR6_NOT_IN_RAID_INSTANCE                = 0x00000800, // 11 not usable in raid instance
        SPELL_ATTR6_CASTABLE_WHILE_ON_VEHICLE           = 0x00001000, // 12 castable while caster is on vehicle
        SPELL_ATTR6_CAN_TARGET_INVISIBLE                = 0x00002000, // 13 ignore visibility requirement for spell target (phases, invisibility, etc.)
        SPELL_ATTR6_UNK14                               = 0x00004000, // 14
        SPELL_ATTR6_UNK15                               = 0x00008000, // 15 not set in 3.0.3
        SPELL_ATTR6_UNK16                               = 0x00010000, // 16
        SPELL_ATTR6_UNK17                               = 0x00020000, // 17
        SPELL_ATTR6_CAST_BY_CHARMER                     = 0x00040000, // 18 client won't allow to cast these spells when unit is not possessed && charmer of caster will be original caster
        SPELL_ATTR6_UNK19                               = 0x00080000, // 19
        SPELL_ATTR6_UNK20                               = 0x00100000, // 20
        SPELL_ATTR6_CLIENT_UI_TARGET_EFFECTS            = 0x00200000, // 21 it's only client-side attribute
        SPELL_ATTR6_UNK22                               = 0x00400000, // 22
        SPELL_ATTR6_UNK23                               = 0x00800000, // 23
        SPELL_ATTR6_CAN_TARGET_UNTARGETABLE             = 0x01000000, // 24
        SPELL_ATTR6_UNK25                               = 0x02000000, // 25
        SPELL_ATTR6_UNK26                               = 0x04000000, // 26
        SPELL_ATTR6_UNK27                               = 0x08000000, // 27
        SPELL_ATTR6_UNK28                               = 0x10000000, // 28
        SPELL_ATTR6_NO_DONE_PCT_DAMAGE_MODS             = 0x20000000, // 29 ignores done percent damage mods?
        SPELL_ATTR6_UNK30                               = 0x40000000, // 30
        SPELL_ATTR6_UNK31                               = 0x1F,  // 31 some special cooldown calc?
    };

    [Flags]
    public enum SpellAtributeEx7
    {
        SPELL_ATTR_EXG_ALL                              =        -1,
        SPELL_ATTR7_UNK0                                = 0x00000001, //  0 Shaman's new spells (Call of the ...), Feign Death.
        SPELL_ATTR7_UNK1                                = 0x00000002, //  1 Not set in 3.2.2a.
        SPELL_ATTR7_REACTIVATE_AT_RESURRECT             = 0x00000004, //  2 Paladin's auras and 65607 only.
        SPELL_ATTR7_IS_CHEAT_SPELL                      = 0x00000008, //  3 Cannot cast if caster doesn't have UnitFlag2 & UNIT_FLAG2_ALLOW_CHEAT_SPELLS
        SPELL_ATTR7_UNK4                                = 0x00000010, //  4 Only 66109 test spell.
        SPELL_ATTR7_SUMMON_PLAYER_TOTEM                 = 0x00000020, //  5 Only Shaman player totems.
        SPELL_ATTR7_UNK6                                = 0x00000040, //  6 Dark Surge, Surge of Light, Burning Breath triggers (boss spells).
        SPELL_ATTR7_UNK7                                = 0x00000080, //  7 66218 (Launch) spell.
        SPELL_ATTR7_HORDE_ONLY                          = 0x00000100, //  8 Teleports, mounts and other spells.
        SPELL_ATTR7_ALLIANCE_ONLY                       = 0x00000200, //  9 Teleports, mounts and other spells.
        SPELL_ATTR7_DISPEL_CHARGES                      = 0x00000400, // 10 Dispel and Spellsteal individual charges instead of whole aura.
        SPELL_ATTR7_INTERRUPT_ONLY_NONPLAYER            = 0x00000800, // 11 Only non-player casts interrupt, though Feral Charge - Bear has it.
        SPELL_ATTR7_UNK12                               = 0x00001000, // 12 Not set in 3.2.2a.
        SPELL_ATTR7_UNK13                               = 0x00002000, // 13 Not set in 3.2.2a.
        SPELL_ATTR7_UNK14                               = 0x00004000, // 14 Only 52150 (Raise Dead - Pet) spell.
        SPELL_ATTR7_UNK15                               = 0x00008000, // 15 Exorcism. Usable on players? 100% crit chance on undead and demons?
        SPELL_ATTR7_UNK16                               = 0x00010000, // 16 Druid spells (29166, 54833, 64372, 68285).
        SPELL_ATTR7_UNK17                               = 0x00020000, // 17 Only 27965 (Suicide) spell.
        SPELL_ATTR7_HAS_CHARGE_EFFECT                   = 0x00040000, // 18 Only spells that have Charge among effects.
        SPELL_ATTR7_ZONE_TELEPORT                       = 0x00080000, // 19 Teleports to specific zones.
        SPELL_ATTR7_UNK20                               = 0x00100000, // 20
        SPELL_ATTR7_UNK21                               = 0x00200000, // 21
        SPELL_ATTR7_UNK22                               = 0x00400000, // 22
        SPELL_ATTR7_UNK23                               = 0x00800000, // 23
        SPELL_ATTR7_UNK24                               = 0x01000000, // 24
        SPELL_ATTR7_UNK25                               = 0x02000000, // 25
        SPELL_ATTR7_UNK26                               = 0x04000000, // 26
        SPELL_ATTR7_UNK27                               = 0x08000000, // 27
        SPELL_ATTR7_UNK28                               = 0x10000000, // 28
        SPELL_ATTR7_UNK29                               = 0x20000000, // 29
        SPELL_ATTR7_UNK30                               = 0x40000000, // 30
        SPELL_ATTR7_UNK31                               = 0x1F,  // 31
    };


    [Flags]
    enum SpellAtributeEx8
    {
        SPELL_ATTR8_TAUNT                               = 0x00000001, // 0
        SPELL_ATTR8_WORGEN_TRANSFORMATION               = 0x00000002, // 1
        SPELL_ATTR8_UNK2                                = 0x00000004, // 2 3 spells : 72221, 90960, 90961
        SPELL_ATTR8_UNK3                                = 0x00000008, // 3 summoning and removing spells?
        SPELL_ATTR8_UNK4                                = 0x00000010, // 4
        SPELL_ATTR8_UNK5                                = 0x00000020, // 5
        SPELL_ATTR8_UNK6                                = 0x00000040, // 6 2 spells: 56817 and 83569
        SPELL_ATTR8_UNK7                                = 0x00000080, // 7
        SPELL_ATTR8_UNK8                                = 0x00000100, // 8 +stats.
        SPELL_ATTR8_UNK9                                = 0x00000200, // 9
        SPELL_ATTR8_CHANGE_MODEL                        = 0x00000400, // 10
        SPELL_ATTR8_UNK11                               = 0x00000800, // 11 one spell: 80224
        SPELL_ATTR8_UNK12                               = 0x00001000, // 12
        SPELL_ATTR8_UNK13                               = 0x00002000, // 13
        SPELL_ATTR8_UNK14                               = 0x00004000, // 14
        SPELL_ATTR8_UNK15                               = 0x00008000, // 15 one spell: 76203
        SPELL_ATTR8_UNK16                               = 0x00010000, // 16
        SPELL_ATTR8_UNK17                               = 0x00020000, // 17
        SPELL_ATTR8_UNK18                               = 0x00040000, // 18 spell with interactions?
        SPELL_ATTR8_UNK19                               = 0x00080000, // 19 requires combo points?
        SPELL_ATTR8_ARMOR_SPECIALIZATION                = 0x00100000, // 20
        SPELL_ATTR8_UNK21                               = 0x00200000, // 21
        SPELL_ATTR8_UNK22                               = 0x00400000, // 22
        SPELL_ATTR8_UNK23                               = 0x00800000, // 23 resurrection? soulstone?
        SPELL_ATTR8_UNK24                               = 0x01000000, // 24
        SPELL_ATTR8_UNK25                               = 0x02000000, // 25
        SPELL_ATTR8_RAID_MARKER                         = 0x04000000, // 26 raid marker. 6 spells in 4.0.6a
        SPELL_ATTR8_UNK27                               = 0x08000000, // 27 throw?
        SPELL_ATTR8_GUILD_PERKS                         = 0x10000000, // 28
        SPELL_ATTR8_MASTERY                             = 0x20000000, // 29
        SPELL_ATTR8_UNK30                               = 0x40000000, // 30 Not set in 4.0.6a
        SPELL_ATTR8_UNK31                               = 0x1F,  // 31
    };

    [Flags]
    public enum CombatRating
    {
        CR_WEAPON_SKILL             =      0x00,
        CR_DEFENSE_SKILL            = 1 << 0x00,
        CR_DODGE                    = 1 << 0x01,
        CR_PARRY                    = 1 << 0x02,
        CR_BLOCK                    = 1 << 0x03,
        CR_HIT_MELEE                = 1 << 0x04,
        CR_HIT_RANGED               = 1 << 0x05,
        CR_HIT_SPELL                = 1 << 0x06,
        CR_CRIT_MELEE               = 1 << 0x07,
        CR_CRIT_RANGED              = 1 << 0x08,
        CR_CRIT_SPELL               = 1 << 0x09,
        CR_HIT_TAKEN_MELEE          = 1 << 0x0A,
        CR_HIT_TAKEN_RANGED         = 1 << 0x0B,
        CR_HIT_TAKEN_SPELL          = 1 << 0x0C,
        CR_CRIT_TAKEN_MELEE         = 1 << 0x0D,
        CR_CRIT_TAKEN_RANGED        = 1 << 0x0E,
        CR_CRIT_TAKEN_SPELL         = 1 << 0x0F,
        CR_HASTE_MELEE              = 1 << 0x10,
        CR_HASTE_RANGED             = 1 << 0x11,
        CR_HASTE_SPELL              = 1 << 0x12,
        CR_WEAPON_SKILL_MAINHAND    = 1 << 0x13,
        CR_WEAPON_SKILL_OFFHAND     = 1 << 0x14,
        CR_WEAPON_SKILL_RANGED      = 1 << 0x15,
        CR_EXPERTISE                = 1 << 0x16,
        CR_ARMOR_PENETRATION        = 1 << 0x17,
    };

    public enum UnitMods
    {
        UNIT_MOD_STAT_STRENGTH          = 0,                  // UNIT_MOD_STAT_STRENGTH..UNIT_MOD_STAT_SPIRIT must be in existed order, it's accessed by index values of Stats enum.
        UNIT_MOD_STAT_AGILITY           = 1,
        UNIT_MOD_STAT_STAMINA           = 2,
        UNIT_MOD_STAT_INTELLECT         = 3,
        UNIT_MOD_STAT_SPIRIT            = 4,
        UNIT_MOD_HEALTH                 = 5,
        UNIT_MOD_MANA                   = 6,                  // UNIT_MOD_MANA..UNIT_MOD_RUNIC_POWER must be in existed order, it's accessed by index values of Powers enum.
        UNIT_MOD_RAGE                   = 7,
        UNIT_MOD_FOCUS                  = 8,
        UNIT_MOD_ENERGY                 = 9,
        UNIT_MOD_HAPPINESS              = 10,
        UNIT_MOD_RUNE                   = 11,
        UNIT_MOD_RUNIC_POWER            = 12,
        UNIT_MOD_ARMOR                  = 13,                 // UNIT_MOD_ARMOR..UNIT_MOD_RESISTANCE_ARCANE must be in existed order, it's accessed by index values of SpellSchools enum.
        UNIT_MOD_RESISTANCE_HOLY        = 14,
        UNIT_MOD_RESISTANCE_FIRE        = 15,
        UNIT_MOD_RESISTANCE_NATURE      = 16,
        UNIT_MOD_RESISTANCE_FROST       = 17,
        UNIT_MOD_RESISTANCE_SHADOW      = 18,
        UNIT_MOD_RESISTANCE_ARCANE      = 19,
        UNIT_MOD_ATTACK_POWER           = 20,
        UNIT_MOD_ATTACK_POWER_RANGED    = 21,
        UNIT_MOD_DAMAGE_MAINHAND        = 22,
        UNIT_MOD_DAMAGE_OFFHAND         = 23,
        UNIT_MOD_DAMAGE_RANGED          = 24,
        UNIT_MOD_END                    = 25,
        // synonyms
        UNIT_MOD_STAT_START             = UNIT_MOD_STAT_STRENGTH,
        UNIT_MOD_STAT_END               = UNIT_MOD_STAT_SPIRIT       + 1,
        UNIT_MOD_RESISTANCE_START       = UNIT_MOD_ARMOR,
        UNIT_MOD_RESISTANCE_END         = UNIT_MOD_RESISTANCE_ARCANE + 1,
        UNIT_MOD_POWER_START            = UNIT_MOD_MANA,
        UNIT_MOD_POWER_END              = UNIT_MOD_RUNIC_POWER       + 1,
    };

    public class SpellEnums
    {
        #region ProcFlagDesc

        public static readonly string[] ProcFlagDesc =
        {
            //00 0x00000001 000000000000000000000001 -
            "00 Killed by aggressor that receive experience or honor",
            //01 0x00000002 000000000000000000000010 -
            "01 Kill that yields experience or honor",

            //02 0x00000004 000000000000000000000100 -
            "02 Successful melee attack",
            //03 0x00000008 000000000000000000001000 -
            "03 Taken damage from melee strike hit",

            //04 0x00000010 000000000000000000010000 -
            "04 Successful attack by Spell that use melee weapon",
            //05 0x00000020 000000000000000000100000 -
            "05 Taken damage by Spell that use melee weapon",

            //06 0x00000040 000000000000000001000000 -
            "06 Successful Ranged attack(and wand spell cast)",
            //07 0x00000080 000000000000000010000000 -
            "07 Taken damage from ranged attack",

            //08 0x00000100 000000000000000100000000 -
            "08 Successful Ranged attack by Spell that use ranged weapon",
            //09 0x00000200 000000000000001000000000 -
            "09 Taken damage by Spell that use ranged weapon",

            //10 0x00000400 000000000000010000000000 -
            "10 Successful ??? spell hit",
            //11 0x00000800 000000000000100000000000 -
            "11 Taken ??? spell hit",

            //12 0x00001000 000000000001000000000000 -
            "12 Successful ??? spell cast",
            //13 0x00002000 000000000010000000000000 -
            "13 Taken ??? spell hit",

            //14 0x00004000 000000000100000000000000 -
            "14 Successful cast positive spell",
            //15 0x00008000 000000001000000000000000 -
            "15 Taken positive spell hit",

            //16 0x00010000 000000010000000000000000 -
            "16 Successful damage from harmful spell cast (каст дамажащего спелла)",
            //17 0x00020000 000000100000000000000000 -
            "17 Taken spell damage",

            //18 0x00040000 000001000000000000000000 -
            "18 Deal periodic damage",
            //19 0x00080000 000010000000000000000000 -
            "19 Taken periodic damage",

            //20 0x00100000 000100000000000000000000 -
            "20 Taken any damage",
            //21 0x00200000 001000000000000000000000 -
            "21 On trap activation (При срабатывании ловушки)",

            //22 0x00800000 010000000000000000000000 -
            "22 Taken off-hand melee attacks",
            //23 0x00800000 100000000000000000000000 -
            "23 Successful off-hand melee attacks",

            "24",
            "25",
            "26",
            "27",
            "28",
            "29",
            "30",
            "31"
        };
        #endregion
    }
}
