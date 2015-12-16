using NLog;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Auth
{
    public class Config
    {
        public static Logger log;
        /*Debug/release mode */
        public static bool DEBUG;
        /* Enable/disable assertions */
        public static bool ASSERT;
        /* Enable/disable code 'in progress' */
        public static bool DEVELOPER;

        public static bool TEST_SERVER;

        /* Game/Login Server ports */
        public static int PORT_GAME;
        public static int PORT_LOGIN;
        public static int LOGIN_TRY_BEFORE_BAN;
        public static string GAMESERVER_HOSTNAME;

        public static string DATABASE_DRIVER;
        public static string DATABASE_URL;
        public static string DATABASE_LOGIN;
        public static string DATABASE_PASSWORD;
        public static int DATABASE_MAX_CONNECTIONS;

        public static int MAXIMUM_ONLINE_USERS;

        public static bool SERVER_LIST_BRACKET;
        public static bool SERVER_LIST_CLOCK;
        public static bool SERVER_LIST_TESTSERVER;
        public static bool SERVER_GMONLY;

        /* Thread pools size */
        public static int THREAD_P_HIGH;
        public static int THREAD_P_MED;
        public static int THREAD_P_LOW;

        /* Auto-loot? */
        public static bool AUTO_LOOT;

        /* Character name template */
        public static String CNAME_TEMPLATE;

        /* Global chat state */
        public static String DEFAULT_GLOBAL_CHAT;
        /* For test servers - evrybody has admin rights */
        public static bool EVERYBODY_HAS_ADMIN_RIGHTS;
        /* Alternative game crafting */
        public static bool ALT_GAME_CREATION;
        /* Alternative game skill learning */
        public static bool ALT_GAME_SKILL_LEARN;
        /* Cancel ATTACK/cast by hit */
        public static bool ALT_GAME_CANCEL_ALL;
        public static bool ALT_GAME_CANCEL_BOW;
        public static bool ALT_GAME_CANCEL_CAST;

        /* Alternative game - use tiredness, instead of CP */
        public static bool ALT_GAME_TIREDNESS;

        /* Alternative shield defence */
        public static bool ALT_GAME_SHIELD_BLOCKS;

        /* Alternative game mob ATTACK AI */
        public static bool ALT_GAME_MOB_ATTACK_AI;

        /* Alternative success rate formulas for skills such root/sleep/stun */
        public static string ALT_GAME_SKILL_FORMULAS;

        /* Alternative freight modes - Freights can be withdrawed from any village */
        public static bool ALT_GAME_FREIGHTS;
        /* Alternative freight modes - Sets the price value for each freightened item */
        public static int ALT_GAME_FREIGHT_PRICE;

        /* Fast or slow multiply coefficient for skill hit time */
        public static float ALT_GAME_SKILL_HIT_RATE;

        /* Alternative gameing - loss of XP on death */
        public static bool ALT_GAME_DELEVEL;

        /* Alternative gaming - player must be in a castle-owning clan or ally to sign up for Dawn. */
        public static bool ALT_GAME_REQUIRE_CASTLE_DAWN;

        /* Alternative gaming - allow clan-based castle ownage check rather than ally-based. */
        public static bool ALT_GAME_REQUIRE_CLAN_CASTLE;

        /* Alternative gaming - allow free teleporting around the world. */
        public static bool ALT_GAME_FREE_TELEPORT;

        /* Alternative gaming - allow sub-class addition without quest completion. */
        public static bool ALT_GAME_SUBCLASS_WITHOUT_QUESTS;

        /* Enable Rate Hp  */
        public static bool ENABLE_RATE_HP;

        /* Spell Book needed to learn skill */
        public static bool SP_BOOK_NEEDED;
        /* Logging Chat Window */
        public static bool LOG_CHAT;
        public static bool LOG_ITEMS;

        public static bool ALT_PRIVILEGES_ADMIN;
        public static bool ALT_PRIVILEGES_SECURE_CHECK;
        public static int ALT_PRIVILEGES_DEFAULT_LEVEL;

        /***************************************************************************
         * GM CONFIG General GM AccessLevel *
         **************************************************************************/

        public static int GM_ACCESSLEVEL;
        /* General GM Minimal AccessLevel */
        public static int GM_MIN;
        /* General GM AccessLevel to change announcements */
        public static int GM_ANNOUNCE;
        /* General GM AccessLevel can /ban /unban */
        public static int GM_BAN;
        public static int GM_BAN_CHAT;
        /* General GM AccessLevel can /create_item and /gmshop */
        public static int GM_CREATE_ITEM;
        /* General GM AccessLevel can /delete */
        public static int GM_DELETE;
        /* General GM AccessLevel can /kick /disconnect */
        public static int GM_KICK;
        /* General GM AccessLevel for access to GMMenu */
        public static int GM_MENU;
        /* General GM AccessLevel tu use god mode command */
        public static int GM_GODMODE;
        /* General GM AccessLevel with character edit rights */
        public static int GM_CHAR_EDIT;
        public static int GM_CHAR_EDIT_OTHER;
        public static int GM_CHAR_VIEW;
        /* General GM AccessLevel with NPC edit rights */
        public static int GM_NPC_EDIT;
        public static int GM_NPC_VIEW;
        /* General GM AccessLevel to teleport to any location */
        public static int GM_TELEPORT;
        public static int GM_TELEPORT_OTHER;
        /* General GM AccessLevel to restart server */
        public static int GM_RESTART;
        /* General GM AccessLevel for MonsterRace */
        public static int GM_MONSTERRACE;
        /* General GM AccessLevel to ride Wyvern */
        public static int GM_RIDER;
        /* General GM AccessLevel to unstuck without 5min delay */
        public static int GM_ESCAPE;
        /* General GM AccessLevel to resurect fixed after death */
        public static int GM_FIXED;
        /* General GM AccessLevel to create Path Nodes */
        public static int GM_CREATE_NODES;
        /* General GM AccessLevel to close/open Doors */
        public static int GM_DOOR;
        /* General GM AccessLevel with Resurrection rights */
        public static int GM_RES;
        /* General GM AccessLevel to attack in the peace zone */
        public static int GM_PEACEATTACK;
        /* General GM AccessLevel to heal */
        public static int GM_HEAL;
        /* General GM AccessLevel to unblock IPs detected as hack IPs */
        public static int GM_UNBLOCK;
        /* General GM AccessLevel to use Cache commands */
        public static int GM_CACHE;
        /* General GM AccessLevel to use test&st commands */
        public static int GM_TEST;
        /* Disable transaction on AccessLevel **/
        public static bool GM_DISABLE_TRANSACTION;
        public static int GM_TRANSACTION_MIN;
        public static int GM_TRANSACTION_MAX;

        /* Rate control */
        public static float RATE_XP;
        public static float RATE_SP;
        public static float RATE_PARTY_XP;
        public static float RATE_PARTY_SP;
        public static float RATE_QUESTS_REWARD;
        public static float RATE_DROP_ADENA;
        public static float RATE_DROP_ITEMS;
        public static float RATE_DROP_SPOIL;
        public static float RATE_DROP_EQUIPMENT;
        public static float RATE_KARMA_EXP_LOST;
        public static float RATE_SIEGE_GUARDS_PRICE;
        public static float RATE_RAID_REGEN_HP;
        public static float RATE_RAID_REGEN_MP;
        public static float ALT_GAME_EXPONENT_XP;
        public static float ALT_GAME_EXPONENT_SP;

        /* Player Drop Rate control */
        public static int PLAYER_RATE_DROP;
        public static int PLAYER_RATE_DROP_ITEM;
        public static int PLAYER_RATE_DROP_EQUIP;
        public static int PLAYER_RATE_DROP_EQUIP_WEAPON;

        public static int AUTODESTROY_ITEM_AFTER;

        public static int DELETE_DAYS;


        /* Datapack root directory */
        // public static File DATAPACK_ROOT;
        public static FileStream DATAPACK_ROOT;

        /* Maximum range mobs can randomly go from spawn point */
        public static int MAX_DRIFT_RANGE;


        // Allow L2Walker client
        public enum L2WalkerAllowed
        {
            True,
            False,
            GM
        }

        public static L2WalkerAllowed ALLOW_L2WALKER_CLIENT;
        public static bool AUTOBAN_L2WALKER_ACC;
        public static int L2WALKER_REVISION;

        public static bool ALLOW_DISCARDITEM;
        public static bool ALLOW_FREIGHT;
        public static bool ALLOW_WAREHOUSE;
        public static bool ALLOW_WEAR;
        public static bool ALLOW_WATER;
        public static bool ALLOW_RENTPET;

        // Pets
        public static int WYVERN_SPEED;
        public static int STRIDER_SPEED;

        // protocol revision
        public static int MIN_PROTOCOL_REVISION;
        public static int MAX_PROTOCOL_REVISION;

        // random animation interval
        public static int MIN_NPC_ANIMATION;
        public static int MAX_NPC_ANIMATION;

        public static bool ACTIVATE_POSITION_RECORDER;
        public static bool USE_3D_MAP;

        // Community Board
        public static bool SHOW_LEVEL_COMMUNITYBOARD;
        public static bool SHOW_STATUS_COMMUNITYBOARD;
        public static int NAME_PAGE_SIZE_COMMUNITYBOARD;
        public static int NAME_PER_ROW_COMMUNITYBOARD;

        /* Configuration files */
        public static string  ID_CONFIG_FILE				    = "/config/idfactory.cfg";
        public static string  OTHER_CONFIG_FILE			        = "/config/other.cfg";
        public static string  SPOIL_CONFIG_FILE			        = "/config/spoil.cfg";
        public static string  ALT_SETTINGS_FILE			        = "/config/altsettings.cfg";
        public static string  PVP_CONFIG_FILE				    = "/config/pvp.cfg";
        public static string  GM_ACCESS_FILE				    = "/config/GMAccess.cfg";
        public static string  TELNET_FILE					    = "/config/telnet.cfg";
        public static string  CONFIGURATION_FILE			    = "/config/server.cfg";
        public static string  LOGIN_CONFIGURATION_FILE	        = "/config/loginserver.cfg";
        public static string  VERSION_FILE				        = "/config/l2j-version.cfg";
        public static string  SIEGE_CONFIGURATION_FILE	        = "/config/siege.cfg";
        public static string  BANNED_IP_XML				        = "/config/banned.xml";
        public static string  HEXID_FILE					    = "./config/hexid.txt";
        public static string  COMMAND_PRIVILEGES_FILE           = "./config/command-privileges.cfg";

        public static bool CHECK_KNOWN;

        public static int GAME_SERVER_LOGIN_PORT;
        public static string GAME_SERVER_LOGIN_HOST;
        public static string INTERNAL_HOSTNAME;
        public static string EXTERNAL_HOSTNAME;
        public static int PATH_NODE_RADIUS;
        public static int NEW_NODE_ID;
        public static int SELECTED_NODE_ID;
        public static int LINKED_NODE_ID;
        public static string NEW_NODE_TYPE;
        public static bool SERVER_SIDE_NPC_NAME;
        public static bool SERVER_SIDE_NPC_NAME_WITH_LVL;
        public static bool ALLOW_GUARDS;
        public static bool ALLOW_CLASS_MASTERS;

        public static string SERVER_VERSION;
        public static string SERVER_BUILD_DATE;

        /* Zone Setting */
        public static int ZONE_TOWN;

        /* Crafting Enabled? */
        public static bool IS_CRAFTING_ENABLED;

        /* Inventory slots limits */
        public static int INVENTORY_MAXIMUM_NO_DWARF;
        public static int INVENTORY_MAXIMUM_DWARF;
        public static int INVENTORY_MAXIMUM_GM;

        /* Warehouse slots limits */
        public static int WAREHOUSE_SLOTS_NO_DWARF;
        public static int WAREHOUSE_SLOTS_DWARF;
        public static int WAREHOUSE_SLOTS_CLAN;
        public static int FREIGHT_SLOTS;

        /* Spoil Rates */
        public static bool CAN_SPOIL_LOWER_LEVEL_MOBS;
        public static bool CAN_DELEVEL_AND_SPOIL_MOBS;
        public static float MAXIMUM_PLAYER_AND_MOB_LEVEL_DIFFERENCE;
        public static float BASE_SPOIL_RATE;
        public static float MINIMUM_SPOIL_RATE;
        public static float SPOIL_LEVEL_DIFFERENCE_LIMIT;
        public static float SPOIL_LEVEL_DIFFERENCE_MULTIPLIER;
        public static int LAST_LEVEL_SPOIL_IS_LEARNED;

        /* Karma System Variables */
        public static int KARMA_MIN_KARMA;
        public static int KARMA_MAX_KARMA;
        public static int KARMA_XP_DIVIDER;
        public static int KARMA_LOST_BASE;
        public static bool KARMA_DROP_GM;
        public static bool KARMA_AWARD_PK_KILL;
        public static int KARMA_DROP_CONSTANT;
        public static int KARMA_PK_LIMIT;
        public static int KARMA_DROP_ITEM_LIMIT;
        public static int KARMA_RANDOM_DROP_LOCATION_LIMIT;
        public static float KARMA_DROPCHANCE_INITIAL_CHECK;
        public static float KARMA_DROPCHANCE_EQUIPPED_WEAPON;
        public static float KARMA_DROPCHANCE_EQUIPPED_OTHER;
        public static float KARMA_DROPCHANCE_UNEQUIPPED_ITEMS;

        public static string KARMA_NONDROPPABLE_PET_ITEMS;
        public static string KARMA_NONDROPPABLE_ITEMS;

        public static List<int> KARMA_LIST_NONDROPPABLE_PET_ITEMS = new List<int>();
        public static List<int> KARMA_LIST_NONDROPPABLE_ITEMS = new List<int>();

        public static string PET_RENT_NPC;

        public static List<int> LIST_PET_RENT_NPC = new List<int>();

        public static int PVP_TIME;

        /* Karma Punishment */
        public static bool ALT_GAME_KARMA_PLAYER_CAN_BE_KILLED_IN_PEACEZONE;
        public static bool ALT_GAME_KARMA_PLAYER_CAN_SHOP;
        public static bool ALT_GAME_KARMA_PLAYER_CAN_TELEPORT;
        public static bool ALT_GAME_KARMA_PLAYER_CAN_TRADE;
        public static bool ALT_GAME_KARMA_PLAYER_CAN_USE_WAREHOUSE;

        /** Day/Night Status **/
        public static bool DAY_STATUS_FORCE_CLIENT_UPDATE;
        public static int DAY_STATUS_SUN_RISE_AT;
        public static int DAY_STATUS_SUN_SET_AT;

        /**  
         * Counting of amount of packets per minute  
         */
        public static bool COUNT_PACKETS = false;
        public static bool DUMP_PACKET_COUNTS = false;
        public static int DUMP_INTERVAL_SECONDS = 60;

        public static int EXECUTOR_PRI_LOW;
        public static int EXECUTOR_PRI_MED;
        public static int EXECUTOR_PRI_HIGH;

        public enum IdFactoryType
        {
            Compaction,
            BitSet,
            Stack
        }

        public static IdFactoryType IDFACTORY_TYPE;
        public static bool BAD_ID_CHECKING;

        public enum ObjectMapType
        {
            L2ObjectHashMap,
            WorldObjectMap
        }

        public enum ObjectSetType
        {
            L2ObjectHashSet,
            WorldObjectSet
        }

        public static ObjectMapType MAP_TYPE;
        public static ObjectSetType SET_TYPE;

        public static bool EFFECT_CANCELING;

        public static bool AUTODELETE_INVALID_QUEST_DATA;

        /* Chance that an item will succesfully be enchanted */
        public static int ENCHANT_CHANCE;
        public static int ENCHANT_MAX;

        public static double HP_REGEN_MULTIPLIER;
        public static double MP_REGEN_MULTIPLIER;
        public static double CP_REGEN_MULTIPLIER;

        public static int STARTING_ADENA;

        /* Deep Blue Mobs' Drop Rules Enabled */
        public static bool DEEPBLUE_DROP_RULES;
        public static int UNSTUCK_INTERVAL;

        // telnet enabled
        public static bool IS_TELNET_ENABLED;

        /* Define Party XP cutoff point method - Possible values: level and percentage */
        public static String PARTY_XP_CUTOFF_METHOD;
        /* Define the cutoff point value for the "level" method */
        public static int PARTY_XP_CUTOFF_LEVEL;
        /* Define the cutoff point value for the "percentage" method */
        public static double PARTY_XP_CUTOFF_PERCENT;

        /* Percent CP is restore on respawn */
        public static double RESPAWN_RESTORE_CP;
        /* Percent HP is restore on respawn */
        public static double RESPAWN_RESTORE_HP;
        /* Percent MP is restore on respawn */
        public static double RESPAWN_RESTORE_MP;

        /* Maximum number of available slots for pvt stores (sell/buy) - Dwarves */
        public static int MAX_PVTSTORE_SLOTS_DWARF;
        /* Maximum number of available slots for pvt stores (sell/buy) - Others */
        public static int MAX_PVTSTORE_SLOTS_OTHER;

        /* Store skills cooltime on char exit/relogin */
        public static bool STORE_SKILL_COOLTIME;
        /* Show licence or not just after login (if false, will directly go to the Server List */
        public static bool SHOW_LICENCE;

        /* Deafult punishment for illegal actions */
        public static int DEFAULT_PUNISH;

        public static bool ACCEPT_NEW_GAMESERVER;
        public static byte[] HEX_ID;
        public static bool ACCEPT_ALTERNATE_ID;
        public static int REQUEST_ID;
        public static bool RESERVE_HOST_ON_LOGIN = false;

        public static int MINIMUM_UPDATE_DISTANCE;
        public static int KNOWNLIST_FORGET_DELAY;
        public static int MINIMUN_UPDATE_TIME;

        public static bool ANNOUNCE_MAMMON_SPAWN;
        public static bool LAZY_CACHE;

        public static void load()
        {
                log.Info("Загрузка конфигурации Gameserver");

        }


    }
}
