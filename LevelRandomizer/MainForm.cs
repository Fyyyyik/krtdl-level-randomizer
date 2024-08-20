using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using KirbyLib;
using KirbyLib.IO;
using KirbyLib.Mapping;
using KRtDL_Level_Randomizer.ext;
using KRtDL_Level_Randomizer.LevelRandomizer;

namespace KRtDL_Level_Randomizer
{
    public partial class MainForm : Form
    {
        readonly int[] enemyKinds = new int[]
        {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            10, 11, 12, 13, 14, 15, 16, 17,
            18, 19, 20, 21, 22, 23, 24, 25,
            26, 27, 28, 29, 30, 31, 32, 33,
            34, 35, 36, 37, 39, 40, 41,
            43, 44, 45, 46, 47, 48, 49, 50,
            51, 52, 53, 54, 55, 57, 58, 59,
            60, 61, 62, 63, 64, 65, 66, 67,
            68, 69, 70, 72, 73, 74, 75, 76,
            77, 78, 81, 82, 83, 84, 85, 86,
            87, 88, 89, 90, 92, 93, 94, 95,
            101, 102, 103, 104, 105, 106, 107,
            108, 109, 110, 112, 113, 114, 115,
            116, 117, 118, 119, 120, 121, 122,
            123, 124, 125, 126, 128, 129, 130,
            131, 132, 133, 134, 135, 145
        };

        readonly int[] gimmickKinds = new int[]
        {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            10, 11, 12, 14, 15, 16, 17, 18,
            19, 20, 26, 27, 28, 30, 31,
            32, 34, 35, 36, 37, 38, 39, 40,
            41, 42, 43, 44, 45, 46, 47, 48,
            49, 51, 52, 53, 54, 55, 56, 57,
            58, 59, 60, 61, 62, 63, 64, 66,
            68, 69, 70, 71, 72, 73, 74, 75,
            76, 77, 78, 79, 80, 82, 83, 84,
            85, 86, 87, 88, 90
        };

        readonly int[] bossKinds = new int[]
        {
            0, 1, 2, 3, 4, 5, 6, 7, 8, 9,
            10, 11, 12, 13, 14, 15, 16, 18,
            19, 20
        };

        readonly int[] blockKinds = new int[]
        {
            0, 1, 2, 3, 4, 5, 6, 7, 10, 11,
            13, 15, 17, 18, 19, 20, 21, 22,
            23, 24, 25, 26, 27, 28, 29, 30,
            31, 32, 33, 34, 36, 37, 38, 39,
            40, 41, 42, 43, 44, 45, 46, 47,
            48, 49, 50, 52, 53, 54, 55, 56,
            57, 58, 59
        };

        readonly int[] itemSubtypeKinds = new int[]
        {
            1, 2, 3, 6, 7, 8, 9, 10
        };

        readonly int[] gimmicksToIgnore = new int[]
        {
            0, 5, 6, 7, 9, 19, 43, 58, 75, 76
        };

        readonly int[] enemiesWithSuper = new int[]
        {
            3, 5, 16, 51
        };

        public Dictionary<string, int> tileProbabilities = new Dictionary<string, int>()
        {
            { "Boundary", 0 },
            { "Water", 0 },
            { "Spikes", 0 },
            { "Ladder", 0 },
            { "Auto Movement", 0 },
            { "Blocks", 0 }
        };

        // Dictionary taken from MagoCrate
        readonly Dictionary<uint, uint> MostLikelyBehaviorList = new Dictionary<uint, uint>()
        {
            {0, 19},
            {1, 6 },
            {2, 2 },
            {3, 18},
            {4, 9 },
            {5, 20},
            {6, 93},
            {9, 10},
            {10, 4},
            {11, 15},
            {12, 16},
            {13, 17},
            {14, 23},
            {15, 32},
            {16, 28},
            {17, 21},
            {18, 33},
            {19, 26},
            {20, 25},
            {21, 35},
            {22, 38},
            {23, 40},
            {24, 45},
            {25, 49},
            {26, 47},
            {27, 101},
            {28, 90},
            {29, 67},
            {30, 84},
            {31, 70},
            {32, 52},
            {33, 57},
            {34, 333},
            {35, 74},
            {36, 72},
            {37, 61},
            {39, 69},
            {40, 86},
            {41, 95},
            {42, 86},
            {43, 112},
            {44, 105},
            {45, 107},
            {46, 117},
            {47, 109},
            {48, 127},
            {49, 118},
            {50, 137},
            {51, 121},
            {52, 134},
            {53, 116},
            {54, 142},
            {55, 173},
            {57, 145},
            {58, 161},
            {59, 168},
            {60, 158},
            {61, 152},
            {62, 172},
            {63, 164},
            {64, 153},
            {65, 181},
            {66, 203},
            {67, 204},
            {68, 156},
            {69, 180},
            {70, 187},
            {73, 198},
            {74, 205},
            {75, 207},
            {76, 215},
            {77, 220},
            {78, 222},
            {81, 241},
            {82, 240},
            {83, 242},
            {84, 244},
            {85, 7},
            {87, 39},
            {88, 257},
            {89, 290},
            {93, 277},
            {94, 274},
            {95, 276}
        };

        // Also taken from MagoCrate
        readonly List<string> BGMList = new List<string>()
        {
            "BGM_LP_ARENALOBBY1",
            "BGM_LP_BMACHINE1",
            "BGM_LP_BOSSGNIGHT1",
            "BGM_LP_BOSSMAE1",
            "BGM_LP_BOSSMAE2",
            "BGM_LP_BOSSTYU1",
            "BGM_LP_BOSSTYU2",
            "BGM_LP_BOSSTYUM2",
            "BGM_LP_BOSSWADO1",
            "BGM_LP_BUKIMI1",
            "BGM_LP_CACTUS1",
            "BGM_LP_CANYON1",
            "BGM_LP_CASTLE1",
            "BGM_LP_CAVE1",
            "BGM_LP_COLD1",
            "BGM_LP_COLD2",
            "BGM_LP_COLDWIND1",
            "BGM_LP_COMIC1",
            "BGM_LP_COMIC2",
            "BGM_LP_COMICHAL2",
            "BGM_LP_CONGA1",
            "BGM_LP_CONTINUE1",
            "BGM_LP_CONTINUE2",
            "BGM_LP_CONTINUE3",
            "BGM_LP_DARK1",
            "BGM_LP_DB1",
            "BGM_LP_DEDEDE1",
            "BGM_LP_DEDEDE2",
            "BGM_LP_DEDEDE3",
            "BGM_LP_DEDEDE4",
            "BGM_LP_DESERT1",
            "BGM_LP_FIFTH1",
            "BGM_LP_FISH1",
            "BGM_LP_FUNK1",
            "BGM_LP_GB1",
            "BGM_LP_HALBERD1",
            "BGM_LP_HEITI1",
            "BGM_LP_HEN1",
            "BGM_LP_ICE1",
            "BGM_LP_IWA1",
            "BGM_LP_KAWASAKI1",
            "BGM_LP_KAZAN1",
            "BGM_LP_KIRAKIRA1",
            "BGM_LP_KIRAKIRA2",
            "BGM_LP_KUMO1",
            "BGM_LP_LASTBOSS1",
            "BGM_LP_LASTBOSS2",
            "BGM_LP_LEVEL1",
            "BGM_LP_LEVELBUKIMI1",
            "BGM_LP_LEVELKAZAN1",
            "BGM_LP_LEVELMACHINE1",
            "BGM_LP_LEVELOPEN1",
            "BGM_LP_MACHINE1",
            "BGM_LP_MACHINE2",
            "BGM_LP_MAGMA1",
            "BGM_LP_MENU1",
            "BGM_LP_MINE1",
            "BGM_LP_MINILOOP1",
            "BGM_LP_MINILOOP2",
            "BGM_LP_MINILOOP3",
            "BGM_LP_MINILOOP4",
            "BGM_LP_MORI1",
            "BGM_LP_MUTEKI1",
            "BGM_LP_NORMAL1",
            "BGM_LP_ORCH1",
            "BGM_LP_PLAIN1",
            "BGM_LP_PLANTS1",
            "BGM_LP_RAIN1",
            "BGM_LP_REGG1",
            "BGM_LP_RESULTMENU1",
            "BGM_LP_ROCK1",
            "BGM_LP_ROCKISOGI1",
            "BGM_LP_ROCKISOGINOI1",
            "BGM_LP_ROCKNOI1",
            "BGM_LP_ROOM1",
            "BGM_LP_SAMBA1",
            "BGM_LP_SAWAYAKA1",
            "BGM_LP_SETUNA1",
            "BGM_LP_SETUNA2",
            "BGM_LP_SLOW1",
            "BGM_LP_SUPERNOURYOKU1",
            "BGM_LP_SUPERNOURYOKU2",
            "BGM_LP_TECH1",
            "BGM_LP_TECHNO1",
            "BGM_LP_TOUT1",
            "BGM_LP_TRAINING1",
            "BGM_LP_UMI1",
            "BGM_LP_WADO2",
            "BGM_LP_WADOHAL2",
            "BGM_LP_WATER1",
            "BGM_LP_WATER2",
            "BGM_LP_WORLD1",
            "BGM_LP_YUMEKUMO1",
            "BGM_LP_YUMEKUMOHAL1",
            "BGM_NOLP_BANNER1",
            "BGM_NOLP_CLEAR1",
            "BGM_NOLP_CLEARDANCE1",
            "BGM_NOLP_CLEARDANCEMOVIE2",
            "BGM_NOLP_CLEARSH1",
            "BGM_NOLP_DANCE2NORMAL1",
            "BGM_NOLP_DANMATU1",
            "BGM_NOLP_DANMATU2",
            "BGM_NOLP_DANMATU3",
            "BGM_NOLP_DEAD1",
            "BGM_NOLP_ENDING1",
            "BGM_NOLP_FANF1",
            "BGM_NOLP_FANF2",
            "BGM_NOLP_FANF3",
            "BGM_NOLP_FANF4",
            "BGM_NOLP_FANF5",
            "BGM_NOLP_FANF6",
            "BGM_NOLP_FANF7",
            "BGM_NOLP_FANF8",
            "BGM_NOLP_FANF9",
            "BGM_NOLP_FUNEGATTAI1",
            "BGM_NOLP_FUNEGATTAI2",
            "BGM_NOLP_GAMEOVER1",
            "BGM_NOLP_HARUKANDORAHE1",
            "BGM_NOLP_MAHOROAYABOU1",
            "BGM_NOLP_MOVIEBATTLE1",
            "BGM_NOLP_MOVIEBATTLE2",
            "BGM_NOLP_MOVIEOPENING1",
            "BGM_NOLP_STAFF1",
            "BGM_NOLP_SUPERNOURYOKUEND1"
        };

        // Also taken from MagoCrate
        readonly Dictionary<uint, string> DecorationList = new Dictionary<uint, string>()
        {
            {1, "Kamitake" },
            {2, "Hasikura" },
            {3, "Morisita" },
            {4, "Noriko" },
            {5, "Cave" },
            {6, "Grass" },
            {7, "Fujiura" },
            {8, "Log" },
            {9, "GCK Beach" },
            {10, "GCK Canyon" },
            {11, "GCK Snow MT" },
            {12, "Lowper" },
            {13, "Desert" },
            {14, "Cave Normal" },
            {15, "Oasis" },
            {16, "Level Map 1" },
            {17, "Air Fort" },
            {18, "Air Island" },
            {19, "Air Temple" },
            {20, "Beach" },
            {21, "Bridge" },
            {22, "Factory" },
            {23, "GCK Cloud" },
            {24, "Hasiguti" },
            {25, "Hondayu" },
            {26, "Ice Building" },
            {27, "Ice Cave" },
            {28, "Lava" },
            {29, "Minami" },
            {30, "Pyramid" },
            {31, "Sea" },
            {32, "Sea Temple" },
            {33, "Snow" },
            {34, "Subway" },
            {35, "Sun" },
            {36, "Volcano" },
            {37, "H_Itoh" },
            {39, "Lowper2" },
            {40, "Level Map 2" },
            {41, "Level Map 3" },
            {42, "Level Map 4" },
            {43, "Level Map 5" },
            {44, "Level Map 6" },
            {45, "Level Map 7" },
            {47, "Ship" },
            {48, "Shooting" },
            {49, "Final" },
            {50, "Challenge 01" },
            {51, "Challenge 02" },
            {52, "Challenge 03" },
            {53, "Challenge 04" },
            {54, "Challenge 05" },
            {55, "Challenge 06" },
            {56, "Challenge 07" },
            {58, "GCK Cloud 2" },
            {63, "GCK Canyon 2" },
            {64, "Halcandra" },
            {65, "Air Temple 2" },
            {66, "Empty" },
            {67, "Hex" },
            {68, "Pop Star" },
            {69, "Sea Temple 2" }
        };

        public MainForm()
        {
            InitializeComponent();
        }

        private static void ShowRandomNumbers(Random rand)
        {
            Debug.WriteLine("");
            byte[] values = new byte[5];
            rand.NextBytes(values);
            foreach (byte value in values)
                Debug.Write("{0, 5} " + value);
            Debug.WriteLine("");
        }

        void AddOutputMessage(string message)
        {
            richTextBoxMessage.Text += " > " + message + "\n";
            richTextBoxMessage.SelectionStart = richTextBoxMessage.Text.Length;
            richTextBoxMessage.ScrollToCaret();
        }

        uint GenerateAreaGimmickLocation(Random rand, MapRtDL map)
        {
            uint xPos = (uint)rand.Next(map.Width * 16);
            uint yPos = (uint)rand.Next(map.Height * 16);

            string param = xPos.ToString();
            for (int i = 0; i != 4 - yPos.ToString("X").Length; i++)
            {
                param += "0";
            }
            param += yPos.ToString("X");
            return uint.Parse(param, System.Globalization.NumberStyles.HexNumber);
        }

        string GenerateAreaGimmickSize(Random rand)
        {
            uint xSize = (uint)rand.Next(481);
            uint ySize = (uint)rand.Next(481);
            string param = xSize.ToString("X");
            for (int i = 0; i != 3 - ySize.ToString("X").Length; i++)
            {
                param += "0";
            }
            param += ySize.ToString("X");
            return param;
        }

        FDG.Scene PatchFDG(FDG.Scene fdgScene, MapRtDL map)
        {
            // Load the contents of FDGPatching.txt into a dictionary of lists of strings
            // First string of each list will be for object name.
            Dictionary<string, List<string>> assets = new Dictionary<string, List<string>>();

            // First, load FDGPatching.txt into a single 53Kb string, what could go wrong
            string path = Application.StartupPath + $@"{Path.DirectorySeparatorChar}ext{Path.DirectorySeparatorChar}FDGPatching.txt";
            if (File.Exists(path))
            {
                AddOutputMessage("Patching FDG for scene " + fdgScene.Name);

                string content = File.ReadAllText(path);

                // Divide each line into an array of strings
                string[] lines = content.Split('\n');

                // Setup the dictionary of lists of strings where each key represents an object
                // The object name is stored as the key, the rest of the elements are the actual assets in the corresponding list.
                string storedKey = "";
                bool isRegisteringAssets = false;
                foreach (string line in lines)
                {
                    if (line.StartsWith("--- ") && line.Contains('/') && !isRegisteringAssets)
                    {
                        // Add the object name as the key
                        string name = line.Substring(line.IndexOf(' ') + 1);
                        name = name.Remove(name.Length - 1, 1);
                        assets.Add(name, new List<string>());

                        storedKey = name;
                        isRegisteringAssets = true;
                        continue;
                    }

                    if (isRegisteringAssets && line != "\r")
                    {
                        assets[storedKey].Add(line.Remove(line.Length - 1, 1));
                    }
                    else if (isRegisteringAssets && line == "\r")
                    {
                        isRegisteringAssets = false;
                    }
                }
            }
            else
            {
                AddOutputMessage("Error : could not find path for FDGPatching.txt file. FDG scene will not be patched.");
                return fdgScene;
            }

            // Now we can start changing stuff in the fdg by using the map data

            // Gimmicks
            foreach (MapRtDL.Gimmick gimmick in map.Gimmicks)
            {
                if (Objects.GimmickList.ContainsKey(gimmick.Kind) == false) continue;

                string objName = "objects/" + Objects.GimmickList[gimmick.Kind];

                if (assets.ContainsKey(objName) == false)
                {
                    continue;
                }

                fdgScene = TryToAddFDGAssets(fdgScene, assets[objName].ToArray());
            }

            // Carriables
            foreach (MapRtDL.CarryItem carryItem in map.CarryItems)
            {
                if (Objects.CarriablesList.ContainsKey(carryItem.Kind) == false) continue;

                string objName = "carriables/" + Objects.CarriablesList[carryItem.Kind];

                if (assets.ContainsKey(objName) == false)
                {
                    continue;
                }

                fdgScene = TryToAddFDGAssets(fdgScene, assets[objName].ToArray());

                // Check for bouncing ability star
                if (objName == "carriables/Bouncing Ability Star" && carryItem.AppearGroup != 0 && carryItem.AppearGroup <= 31)
                {
                    fdgScene = TryToAddFDGAssets(fdgScene, assets[objName + $"_a.[{carryItem.AppearGroup}]"].ToArray());
                }
            }

            // Items
            foreach (MapRtDL.Item item in map.Items)
            {
                if (Objects.ItemList.ContainsKey(item.Kind) == false) continue;

                string objName = "items/" + Objects.ItemList[item.Kind];

                // Check for food and copy essence and Lor part and Super Ability Star
                if (objName == "items/Food")
                {
                    fdgScene = TryToAddFDGAssets(fdgScene, assets[objName + $"_b.[{item.Variation}]"].ToArray());
                }
                else if (objName == "items/Copy Essence" && assets.ContainsKey(objName + $"_b.[{item.Level}]"))
                {
                    fdgScene = TryToAddFDGAssets(fdgScene, assets[objName + $"_b.[{item.Level}]"].ToArray());
                }
                else if (objName == "items/Lor Part")
                {
                    fdgScene = TryToAddFDGAssets(fdgScene, assets[objName + $"_b.[{item.Level}]"].ToArray());
                }
                else if (objName == "items/Super Ability Star" && assets.ContainsKey(objName + $"_b.[{item.Level}]"))
                {

                    fdgScene = TryToAddFDGAssets(fdgScene, assets[objName + $"_b.[{item.Level}]"].ToArray());
                }

                if (assets.ContainsKey(objName) == false)
                {
                    continue;
                }

                fdgScene = TryToAddFDGAssets(fdgScene, assets[objName].ToArray());
            }

            // Bosses
            foreach (MapRtDL.Boss boss in map.Bosses)
            {
                if (Objects.BossList.ContainsKey(boss.Kind) == false) continue;

                string objName = "bosses/" + Objects.BossList[boss.Kind];

                // Check for Sphere Doomer and Super Bonkers
                switch (objName)
                {
                    case "bosses/Bonkers":
                        if (boss.HasSuperAbility)
                        {
                            objName += "_super";
                        }
                        break;

                    case "bosses/Sphere Doomer":
                        fdgScene = TryToAddFDGAssets(fdgScene, assets[objName + $"_l.[{boss.Level}]"].ToArray());
                        break;
                }

                if (assets.ContainsKey(objName) == false)
                {
                    continue;
                }

                fdgScene = TryToAddFDGAssets(fdgScene, assets[objName].ToArray());
            }

            //Enemies
            foreach (MapRtDL.Enemy enemy in map.Enemies)
            {
                if (Objects.EnemyList.ContainsKey(enemy.Kind) == false) continue;

                string objName = "enemies/" + Objects.EnemyList[enemy.Kind];

                // Checking for special cases
                switch (objName)
                {
                    case "enemies/Blade Knight":
                        if (enemy.HasSuperAbility)
                        {
                            objName += "_super";
                        }
                        break;

                    case "enemies/Hothead":
                        if (enemy.HasSuperAbility)
                        {
                            objName += "_super";
                        }
                        break;

                    case "enemies/Waddle Doo":
                        if (enemy.HasSuperAbility)
                        {
                            objName += "_super";
                        }
                        break;

                    case "enemies/Chilly":
                        if (enemy.HasSuperAbility)
                        {
                            objName += "_super";
                        }
                        break;
                }

                if (assets.ContainsKey(objName) == false)
                {
                    continue;
                }

                fdgScene = TryToAddFDGAssets(fdgScene, assets[objName].ToArray());
            }

            AddOutputMessage("Finished patching FDG for this scene!");

            return fdgScene;
        }

        FDG.Scene TryToAddFDGAssets(FDG.Scene scene, string[] assets)
        {
            foreach (string asset in assets)
            {
                if (scene.Assets.Contains(asset) == false)
                {
                    scene.Assets.Add(asset);
                }
            }

            return scene;
        }

        MapRtDL.Enemy GetRandomEnemy(Random rand, GridPos xPos, GridPos yPos, bool randSize)
        {
            MapRtDL.Enemy enemy = new MapRtDL.Enemy();
            enemy.Kind = (uint)enemyKinds[rand.Next(enemyKinds.Length)];
            MostLikelyBehaviorList.TryGetValue(enemy.Kind, out enemy.Variation);
            enemy.Direction = 0;
            enemy.TerrainGroup = -1;
            enemy.HasSuperAbility = false;
            enemy.Level = (uint)rand.Next(5);
            enemy.X = xPos;
            enemy.Y = yPos;

            // Check if the enemy can have a super variant
            foreach (int id in enemiesWithSuper)
            {
                if (enemy.Kind == id)
                {
                    enemy.HasSuperAbility = rand.Next(3) == 0;
                }
            }

            if (randSize)
            {
                enemy.AnotherDimensionSize = (uint)rand.Next(6);
                enemy.ExtraModeSize = (uint)rand.Next(6);
            }

            return enemy;
        }

        MapRtDL.Boss GetRandomBoss(Random rand, GridPos xPos, GridPos yPos)
        {
            MapRtDL.Boss boss = new MapRtDL.Boss();
            boss.Kind = (uint)bossKinds[rand.Next(bossKinds.Length)];
            boss.Level = (uint)rand.Next(11);
            boss.SubKind = (uint)rand.Next(2);
            boss.HasSuperAbility = false;
            boss.Unknown = 0;
            boss.TerrainGroup = -1;
            switch (boss.Kind)
            {
                case 0:
                    boss.Level = (uint)rand.Next(4);
                    break;

                case 7:
                    if (rand.Next(2) == 0)
                    {
                        boss.HasSuperAbility = true;
                    }
                    break;
            }
            boss.X = xPos;
            boss.Y = yPos;
            return boss;
        }

        MapRtDL.Item GetRandomItem(Random rand, GridPos xPos, GridPos yPos)
        {
            MapRtDL.Item item = new MapRtDL.Item();
            item.Kind = (uint)rand.Next(15);
            item.Variation = (uint)itemSubtypeKinds[rand.Next(itemSubtypeKinds.Length)];
            if (item.Kind != 4 && item.Variation == 7) item.Variation = 8;
            item.Level = 0;
            item.TerrainGroup = -1;
            item.X = xPos;
            item.Y = yPos;
            switch (item.Kind)
            {
                case 3:
                    item.Level = (uint)rand.Next(35);
                    break;

                case 4:
                    item.Level = (uint)rand.Next(6);
                    break;

                case 8:
                    item.Level = (uint)rand.Next(34);
                    break;

                case 9:
                    item.Level = (uint)rand.Next(6);
                    break;

                case 11:
                    item.Level = (uint)rand.Next(5);
                    break;

                case 12:
                    item.Level = (uint)rand.Next(34);
                    break;
            }

            return item;
        }

        static MapRtDL.CarryItem GetRandomCarryItem(Random rand, GridPos xPos, GridPos yPos, MapRtDL.CarryItem[] itemsInMap)
        {
            MapRtDL.CarryItem carry = new MapRtDL.CarryItem();
            carry.Kind = (uint)rand.Next(10);
            carry.CanRespawn = rand.Next(2) == 0;
            carry.TerrainGroup = -1;
            carry.X = xPos;
            carry.Y = yPos;
            switch (carry.Kind)
            {
                case 0:
                    carry.AppearGroup = (uint)rand.Next(1, 34);
                    break;

                case 1:
                    uint appearId = 0;
                    foreach (MapRtDL.CarryItem item in itemsInMap)
                    {
                        if (item.AppearGroup >= appearId)
                        {
                            appearId = item.AppearGroup + 1;
                        }
                    }
                    carry.AppearGroup = appearId - 1;
                    break;
            }

            return carry;
        }

        MapRtDL.Gimmick GetRandomGimmick(Random rand, GridPos xPos, GridPos yPos, MapRtDL mapRtdl)
        {
            MapRtDL.Gimmick gimmick = new MapRtDL.Gimmick();
            gimmick.Kind = (uint)gimmickKinds[rand.Next(gimmickKinds.Length)];
            gimmick.Param1 = 0;
            gimmick.Param2 = 0;
            gimmick.Param3 = 0;
            gimmick.Param4 = 0;
            gimmick.Param5 = 0;
            gimmick.Param6 = 0;
            gimmick.Param7 = 0;
            gimmick.Param8 = 0;
            gimmick.Param9 = 0;
            gimmick.Param10 = 0;
            gimmick.Param11 = 0;
            gimmick.Param12 = 0;
            gimmick.Unknown = 0;
            gimmick.X = xPos;
            gimmick.Y = yPos;
            string param6 = "";
            string param7 = "";
            switch (gimmick.Kind)
            {
                case 0:
                    gimmick.Param6 = (uint)rand.Next(7);
                    if (rand.Next(4) == 0)
                    {
                        gimmick.Param2 = 1;
                        break;
                    }
                    gimmick.Param3 = 1;
                    break;

                case 1:
                    gimmick.Param7 = (uint)rand.Next(4);
                    break;

                case 2:
                    gimmick.Param6 = (uint)rand.Next(6);
                    break;

                case 8:
                    gimmick.Param6 = (uint)rand.Next(4);
                    break;

                case 10:
                    uint ropeLength = (uint)rand.Next(241);
                    uint fallDistance = (uint)rand.Next(241);

                    string hexRopeLength = ropeLength.ToString("X");
                    string hexFallDistance = ropeLength.ToString("X");

                    param6 = hexRopeLength;
                    for (int j = 0; j != 4 - hexFallDistance.Length; j++)
                    {
                        param6 += "0";
                    }
                    param6 += hexFallDistance;

                    gimmick.Param6 = uint.Parse(param6, System.Globalization.NumberStyles.HexNumber);

                    uint width = (uint)rand.Next(2);
                    uint type = (uint)rand.Next(2);
                    param7 = $"0{width}00000{type}";
                    gimmick.Param7 = uint.Parse(param7, System.Globalization.NumberStyles.HexNumber);

                    break;

                case 11:
                    gimmick.Param6 = (uint)rand.Next(15);
                    break;

                case 12:
                    gimmick.Param6 = (uint)rand.Next(3);
                    break;

                case 19:
                    gimmick.Param3 = 1;

                    uint startingDir = (uint)rand.Next(8);
                    uint rotType = (uint)rand.Next(6);
                    uint rotSpeed = (uint)rand.Next(10);
                    param6 = $"000{startingDir}0{rotType}0{rotSpeed}";
                    gimmick.Param6 = uint.Parse(param6, System.Globalization.NumberStyles.HexNumber);

                    uint cannonType = (uint)rand.Next(2);
                    uint cannonRoomChange = (uint)rand.Next(2);
                    param7 = $"000{cannonType}000{cannonRoomChange}";
                    gimmick.Param7 = uint.Parse(param7, System.Globalization.NumberStyles.HexNumber);

                    break;

                case 26:
                    gimmick.Param6 = (uint)rand.Next(12);
                    break;

                case 27:
                    gimmick.Param3 = 1;
                    break;

                case 30:
                    uint shutterDoorDir = (uint)rand.Next(3);
                    uint shutterDoorSize = (uint)rand.Next(2);
                    if (shutterDoorSize == 0)
                    {
                        uint shutterDoorSkin = (uint)rand.Next(3);
                        param6 = $"000{shutterDoorDir}0{shutterDoorSize}0{shutterDoorSkin}";
                    }
                    else
                    {
                        param6 = $"000{shutterDoorDir}0{shutterDoorSize}00";
                    }
                    gimmick.Param6 = uint.Parse(param6, System.Globalization.NumberStyles.HexNumber);
                    break;

                case 42:
                    gimmick.Param6 = GenerateAreaGimmickLocation(rand, mapRtdl);
                    gimmick.Param7 = uint.Parse($"{GenerateAreaGimmickSize(rand)}{rand.Next(4) * 2}{rand.Next(16).ToString("X")}", System.Globalization.NumberStyles.HexNumber);
                    break;

                case 44:
                    gimmick.Param6 = GenerateAreaGimmickLocation(rand, mapRtdl);
                    gimmick.Param7 = uint.Parse($"{GenerateAreaGimmickSize(rand)}1{rand.Next(2) * 2}", System.Globalization.NumberStyles.HexNumber);
                    break;

                case 45:
                    gimmick.Param6 = GenerateAreaGimmickLocation(rand, mapRtdl);
                    gimmick.Param7 = uint.Parse($"{GenerateAreaGimmickSize(rand)}{rand.Next(4) * 2}{rand.Next(16).ToString("X")}", System.Globalization.NumberStyles.HexNumber);
                    break;

                case 58:
                    gimmick.Param3 = 1;
                    break;

                case 75:
                    gimmick.Param6 = (uint)rand.Next(2, 5);
                    break;

                case 84:
                    uint aiType = (uint)rand.Next(5);
                    gimmick.Param6 = uint.Parse($"0{aiType}000000", System.Globalization.NumberStyles.HexNumber);
                    gimmick.Param7 = (uint)rand.Next(6);
                    break;

                case 90:
                    gimmick.Param6 = (uint)rand.Next(mapRtdl.Width * 16);
                    gimmick.Param7 = (uint)rand.Next(mapRtdl.Height * 16);
                    gimmick.Param8 = (uint)rand.Next(481);
                    gimmick.Param9 = (uint)rand.Next(481);
                    break;
            }

            return gimmick;
        }

        void Randomize()
        {
            Int32 seed = (int)numericUpDownSeed.Value;
            Random random = new Random(seed);

            bool isExistFdg = File.Exists(textBoxFdg.Text);

            AddOutputMessage("Randomizing levels with seed " + seed + "...");

            string targetFileType;
            if (checkBoxKrtdlDx.Checked) targetFileType = "*.bin";
            else targetFileType = "*.dat";

            string[] maps = Directory.GetFiles(textBoxTargetPath.Text, targetFileType, SearchOption.AllDirectories);
            int mapId = 0;
            foreach (string map in maps)
            {
                AddOutputMessage($"Randomizing {map}...");
                MapRtDL mapRtdl = new MapRtDL();
                using (FileStream stream = new FileStream(map, FileMode.Open, FileAccess.Read))
                using (EndianBinaryReader reader = new EndianBinaryReader(stream))
                    mapRtdl.Read(reader);

                // Randomize stuff

                // Randomize enemies
                if (checkBoxEnemies.Checked)
                {
                    for (int i = 0; i < mapRtdl.Enemies.Count; i++)
                    {
                        mapRtdl.Enemies[i] = GetRandomEnemy(random, mapRtdl.Enemies[i].X, mapRtdl.Enemies[i].Y, checkBoxEnemySize.Checked);
                    }
                }

                // Randomize bosses
                if (checkBoxBosses.Checked)
                {
                    for (int i = 0; i < mapRtdl.Bosses.Count; i++)
                    {
                        mapRtdl.Bosses[i] = GetRandomBoss(random, mapRtdl.Bosses[i].X, mapRtdl.Bosses[i].Y);
                    }
                }

                // Randomize items
                if (checkBoxItems.Checked)
                {
                    for (int i = 0; i < mapRtdl.Items.Count; i++)
                    {
                        mapRtdl.Items[i] = GetRandomItem(random, mapRtdl.Items[i].X, mapRtdl.Items[i].Y);
                    }

                    for (int i = 0; i < mapRtdl.CarryItems.Count; i++)
                    {
                        mapRtdl.CarryItems[i] = GetRandomCarryItem(random, mapRtdl.CarryItems[i].X, mapRtdl.CarryItems[i].Y, mapRtdl.CarryItems.ToArray());
                    }
                }

                // Randomize gimmicks (oh boy)
                if (checkBoxObjects.Checked)
                {
                    for (int i = 0; i < mapRtdl.Gimmicks.Count; i++)
                    {
                        // Decide if it should be ignored
                        bool shouldIgnore = false;
                        foreach (int gimmickId in gimmicksToIgnore)
                        {
                            if (mapRtdl.Gimmicks[i].Kind == gimmickId)
                            {
                                shouldIgnore = true;
                            }
                        }

                        if (shouldIgnore) continue;

                        mapRtdl.Gimmicks[i] = GetRandomGimmick(random, mapRtdl.Gimmicks[i].X, mapRtdl.Gimmicks[i].Y, mapRtdl);
                    }
                }

                // Randomize types
                if (checkBoxTypes.Checked)
                {
                    //fuck

                    // Randomize the types of all objects that must be randomized

                    //Gimmicks
                    if (checkBoxObjects.Checked)
                    {
                        List<int> gimmicksIdsToDelete = new List<int>();
                        for (int i = 0; i < mapRtdl.Gimmicks.Count; i++)
                        {
                            // Decide if the program should ignore that gimmick
                            bool shouldIgnore = false;
                            foreach (int gimmickId in gimmicksToIgnore)
                            {
                                if (mapRtdl.Gimmicks[i].Kind == gimmickId) shouldIgnore = true;
                            }

                            if (shouldIgnore) continue;

                            if (random.Next(2) == 0)
                            {
                                gimmicksIdsToDelete.Add(i);
                                MapRtDL.Gimmick gimmick = mapRtdl.Gimmicks[i];
                                switch (random.Next(4))
                                {
                                    //Carriable
                                    case 0:
                                        mapRtdl.CarryItems.Add(GetRandomCarryItem(random, gimmick.X, gimmick.Y, mapRtdl.CarryItems.ToArray()));
                                        break;

                                    //Item
                                    case 1:
                                        mapRtdl.Items.Add(GetRandomItem(random, gimmick.X, gimmick.Y));
                                        break;

                                    //Boss
                                    case 2:
                                        mapRtdl.Bosses.Add(GetRandomBoss(random, gimmick.X, gimmick.Y));
                                        break;

                                    //Enemy
                                    case 3:
                                        mapRtdl.Enemies.Add(GetRandomEnemy(random, gimmick.X, gimmick.Y, checkBoxEnemySize.Checked));
                                        break;
                                }
                            }
                        }

                        // Remove the gimmicks that are replaced, starting with the end of the list
                        gimmicksIdsToDelete.Sort();
                        for (int i = gimmicksIdsToDelete.Count - 1; i >= 0; i--)
                        {
                            mapRtdl.Gimmicks.RemoveAt(gimmicksIdsToDelete[i]);
                        }
                    }

                    //Carriables and Items
                    if (checkBoxItems.Checked)
                    {
                        //Carriables
                        List<int> carriablesIdsToDelete = new List<int>();
                        for (int i = 0; i < mapRtdl.CarryItems.Count; i++)
                        {
                            if (random.Next(2) == 0)
                            {
                                carriablesIdsToDelete.Add(i);
                                MapRtDL.CarryItem carryItem = mapRtdl.CarryItems[i];
                                switch (random.Next(4))
                                {
                                    //Gimmick
                                    case 0:
                                        mapRtdl.Gimmicks.Add(GetRandomGimmick(random, carryItem.X, carryItem.Y, mapRtdl));
                                        break;

                                    //Item
                                    case 1:
                                        mapRtdl.Items.Add(GetRandomItem(random, carryItem.X, carryItem.Y));
                                        break;

                                    //Boss
                                    case 2:
                                        mapRtdl.Bosses.Add(GetRandomBoss(random, carryItem.X, carryItem.Y));
                                        break;

                                    //Enemy
                                    case 3:
                                        mapRtdl.Enemies.Add(GetRandomEnemy(random, carryItem.X, carryItem.Y, checkBoxEnemySize.Checked));
                                        break;
                                }
                            }
                        }

                        // Remove the carriables that are replaced, starting with the end of the list
                        carriablesIdsToDelete.Sort();
                        for (int i = carriablesIdsToDelete.Count - 1; i >= 0; i--)
                        {
                            mapRtdl.CarryItems.RemoveAt(carriablesIdsToDelete[i]);
                        }

                        //Items
                        List<int> itemsIdsToDelete = new List<int>();
                        for (int i = 0; i < mapRtdl.Items.Count; i++)
                        {
                            if (random.Next(2) == 0)
                            {
                                carriablesIdsToDelete.Add(i);
                                MapRtDL.Item item = mapRtdl.Items[i];
                                switch (random.Next(4))
                                {
                                    //Gimmicks
                                    case 0:
                                        mapRtdl.Gimmicks.Add(GetRandomGimmick(random, item.X, item.Y, mapRtdl));
                                        break;

                                    //Carriable
                                    case 1:
                                        mapRtdl.CarryItems.Add(GetRandomCarryItem(random, item.X, item.Y, mapRtdl.CarryItems.ToArray()));
                                        break;

                                    //Boss
                                    case 2:
                                        mapRtdl.Bosses.Add(GetRandomBoss(random, item.X, item.Y));
                                        break;

                                    //Enemy
                                    case 3:
                                        mapRtdl.Enemies.Add(GetRandomEnemy(random, item.X, item.Y, checkBoxEnemySize.Checked));
                                        break;
                                }
                            }
                        }

                        // Remove the items that are replaced, starting with the end of the list
                        itemsIdsToDelete.Sort();
                        for (int i = itemsIdsToDelete.Count - 1; i >= 0; i--)
                        {
                            mapRtdl.Items.RemoveAt(itemsIdsToDelete[i]);
                        }
                    }

                    //Bosses
                    if (checkBoxBosses.Checked)
                    {
                        List<int> bossesIdsToDelete = new List<int>();
                        for (int i = 0; i < mapRtdl.Bosses.Count; i++)
                        {
                            if (random.Next(2) == 0)
                            {
                                bossesIdsToDelete.Add(i);
                                MapRtDL.Boss boss = mapRtdl.Bosses[i];
                                switch (random.Next(4))
                                {
                                    //Gimmick
                                    case 0:
                                        mapRtdl.Gimmicks.Add(GetRandomGimmick(random, boss.X, boss.Y, mapRtdl));
                                        break;

                                    //Carriable
                                    case 1:
                                        mapRtdl.CarryItems.Add(GetRandomCarryItem(random, boss.X, boss.Y, mapRtdl.CarryItems.ToArray()));
                                        break;

                                    //Item
                                    case 2:
                                        mapRtdl.Items.Add(GetRandomItem(random, boss.X, boss.Y));
                                        break;

                                    //Enemy
                                    case 3:
                                        mapRtdl.Enemies.Add(GetRandomEnemy(random, boss.X, boss.Y, checkBoxEnemySize.Checked));
                                        break;
                                }
                            }
                        }

                        // Remove the bosses that are replaced, starting with the end of the list
                        bossesIdsToDelete.Sort();
                        for (int i = bossesIdsToDelete.Count - 1; i >= 0; i--)
                        {
                            mapRtdl.Bosses.RemoveAt(bossesIdsToDelete[i]);
                        }
                    }

                    //Enemies
                    if (checkBoxEnemies.Checked)
                    {
                        List<int> enemiesIdsToDelete = new List<int>();
                        for (int i = 0; i < mapRtdl.Enemies.Count; i++)
                        {
                            if (random.Next(2) == 0)
                            {
                                enemiesIdsToDelete.Add(i);
                                MapRtDL.Enemy enemy = mapRtdl.Enemies[i];
                                switch (random.Next(4))
                                {
                                    //Gimmick
                                    case 0:
                                        mapRtdl.Gimmicks.Add(GetRandomGimmick(random, enemy.X, enemy.Y, mapRtdl));
                                        break;

                                    //Carriable
                                    case 1:
                                        mapRtdl.CarryItems.Add(GetRandomCarryItem(random, enemy.X, enemy.Y, mapRtdl.CarryItems.ToArray()));
                                        break;

                                    //Item
                                    case 2:
                                        mapRtdl.Items.Add(GetRandomItem(random, enemy.X, enemy.Y));
                                        break;

                                    //Boss
                                    case 3:
                                        mapRtdl.Bosses.Add(GetRandomBoss(random, enemy.X, enemy.Y));
                                        break;
                                }
                            }
                        }

                        // Remove the enemies that are replaced, starting with the end of the list
                        enemiesIdsToDelete.Sort();
                        for (int i = enemiesIdsToDelete.Count - 1; i >= 0; i--)
                        {
                            mapRtdl.Enemies.RemoveAt(enemiesIdsToDelete[i]);
                        }
                    }
                }

                // Randomize music
                if (checkBoxMusic.Checked)
                {
                    mapRtdl.BGM = BGMList[random.Next(BGMList.Count)];
                }

                // Randomize rooms
                if (checkBoxRooms.Checked)
                {
                    // Find all door objects
                    List<int> doorIds = new List<int>();
                    for (int i = 0; i < mapRtdl.Gimmicks.Count; i++)
                    {
                        if (mapRtdl.Gimmicks[i].Kind == 0 || mapRtdl.Gimmicks[i].Kind == 6 || mapRtdl.Gimmicks[i].Kind == 7 || mapRtdl.Gimmicks[i].Kind == 19 || mapRtdl.Gimmicks[i].Kind == 27)
                        {
                            doorIds.Add(i);
                        }
                    }

                    // Randomize room skip param
                    for (int i = 0; i < doorIds.Count; i++)
                    {
                        MapRtDL.Gimmick door = mapRtdl.Gimmicks[doorIds[i]];
                        if (random.Next(2) == 0)
                        {
                            // Positive
                            door.Param3 = (uint)random.Next(maps.Length - mapId);
                        }
                        else
                        {
                            // Negative
                            door.Param3 = 0xFFFFFFFF - (uint)random.Next(mapId);
                        }
                        mapRtdl.Gimmicks[doorIds[i]] = door;
                    }
                }

                // Randomize background
                if (checkBoxBackground.Checked)
                {
                    while (true)
                    {
                        uint key = (uint)random.Next(71);
                        if (DecorationList.ContainsKey(key))
                        {
                            mapRtdl.Background = key;
                            break;
                        }
                    }
                }

                // Randomize stage properties
                if (checkBoxProperties.Checked)
                {
                    mapRtdl.CustomRespawn = random.Next(3) == 0;
                    mapRtdl.RespawnStartPortal = 0;
                    mapRtdl.RespawnStepShift = random.Next(10);
                    mapRtdl.SFX = (MapRtDL.SFXKind)random.Next(3);
                }

                // Randomize moving terrain
                if (checkBoxMovingTerrain.Checked)
                {
                    for (int i = 0; i < 16; i++)
                    {
                        if (mapRtdl.CollisionMoveGroups[i].Collision != null)
                        {
                            for (int eventId = 0; eventId < mapRtdl.CollisionMoveGroups[i].Action.Events.Count(); eventId++)
                            {
                                MapRtDL.MoveGridEvent ev = mapRtdl.CollisionMoveGroups[i].Action.Events[eventId];
                                ev.Direction = (MapRtDL.MoveGridDirection)random.Next(5);
                                ev.Distance = (byte)random.Next(11);
                                ev.AccelTime = (byte)random.Next(121);
                                ev.Delay = (ushort)random.Next(241);
                                ev.Time = (ushort)random.Next(800);
                                mapRtdl.CollisionMoveGroups[i].Action.Events[eventId] = ev;
                            }
                        }
                    }
                }

                // Randomize tiles
                if (checkBoxTiles.Checked)
                {
                    for (int x = 0; x < mapRtdl.Width; x++)
                    {
                        for (int y = 0; y < mapRtdl.Height; y++)
                        {
                            CollisionTile tile = mapRtdl.Collision[0][x, y];
                            DecorationTile deco = mapRtdl.MLand[x, y];

                            // Boundary
                            if (tileProbabilities["Boundary"] != 0)
                            {
                                if (random.Next(101 - tileProbabilities["Boundary"]) == 0)
                                {
                                    tile.Shape = LandGridShapeKind.Cube;
                                    tile.PropertyFlags = LandGridProperty.Boundary;
                                    goto end_loop;
                                }
                            }

                            // Water
                            if (tileProbabilities["Water"] != 0)
                            {
                                if (random.Next(101 - tileProbabilities["Water"]) == 0)
                                {
                                    tile.PropertyFlags = LandGridProperty.Water;
                                    goto end_loop;
                                }
                            }

                            // Spikes
                            if (tileProbabilities["Spikes"] != 0)
                            {
                                if (random.Next(101 - tileProbabilities["Spikes"]) == 0)
                                {
                                    tile.PropertyFlags = LandGridProperty.Spike;
                                    deco.Tile = 80;
                                    deco.Unknown = 17;
                                    goto end_loop;
                                }
                            }

                            // Ladder
                            if (tileProbabilities["Ladder"] != 0)
                            {
                                if (random.Next(101 - tileProbabilities["Ladder"]) == 0)
                                {
                                    tile.PropertyFlags = LandGridProperty.Ladder;
                                    deco.Tile = 43;
                                    deco.Unknown = 17;
                                    goto end_loop;
                                }
                            }

                            // Auto Movement
                            if (tileProbabilities["Auto Movement"] != 0)
                            {
                                if (random.Next(101 - tileProbabilities["Auto Movement"]) == 0)
                                {
                                    tile.ConveyorSpeed = (sbyte)random.Next(-3, 4);
                                    goto end_loop;
                                }
                            }

                            // Blocks
                            if (tileProbabilities["Blocks"] != 0)
                            {
                                if (random.Next(101 - tileProbabilities["Blocks"]) == 0)
                                {
                                    mapRtdl.Blocks[x, y] = (short)blockKinds[random.Next(blockKinds.Length)];
                                    goto end_loop;
                                }
                            }

                        end_loop:
                            mapRtdl.Collision[0][x, y] = tile;
                            mapRtdl.MLand[x, y] = deco;
                        }
                    }
                }

                //FDG
                if (isExistFdg && checkBoxKrtdlDx.Checked == false)
                {
                    FDG fdg = new FDG();
                    using (FileStream stream = new FileStream(textBoxFdg.Text, FileMode.Open, FileAccess.Read))
                    using (EndianBinaryReader reader = new EndianBinaryReader(stream))
                        fdg.Read(reader);

                    // First search for all the scenes we actually care about
                    List<int> mapDataFdgIds = new List<int>();
                    for (int i = 0; i < fdg.Scenes.Count; i++)
                    {
                        string sceneName = fdg.Scenes[i].Name;
                        if (sceneName.StartsWith("StepMapDataChallenge") || sceneName.StartsWith("StepMapDataOther") || sceneName.StartsWith("StepMapDataLevel"))
                        {
                            mapDataFdgIds.Add(i);
                        }
                    }

                    // Convert the map path string to something the fdg understands
                    string lowerCasePath = map.ToLower();
                    string convertedPath = "StepMapData" + lowerCasePath.Substring(lowerCasePath.IndexOf(@"step") + 4);
                    for (int i = 0; i < convertedPath.Length; i++)
                    {
                        if (convertedPath[i] == '\\' && i + 1 < convertedPath.Length)
                        {
                            StringBuilder sb = new StringBuilder(convertedPath);
                            sb[i + 1] = convertedPath[i + 1].ToString().ToUpper().ToCharArray()[0];
                            convertedPath = sb.ToString();
                            convertedPath = convertedPath.Remove(i, 1);
                        }
                    }

                    if (checkBoxKrtdlDx.Checked) convertedPath = convertedPath.Replace(".bin", ".dn");
                    else convertedPath = convertedPath.Replace(".dat", ".dn");

                    // Search it in the list of ids
                    bool hasFound = false;
                    foreach (int id in mapDataFdgIds)
                    {
                        if (fdg.Scenes[id].Name == convertedPath)
                        {
                            hasFound = true;

                            // Patch it you fucker
                            fdg.Scenes[id] = PatchFDG(fdg.Scenes[id], mapRtdl);
                        }
                    }

                    if (!hasFound)
                    {
                        // uh oh
                        AddOutputMessage("Could not find FDG scene : " + convertedPath + " has not been found.");

                        if (checkBoxManualFdg.Checked == false)
                        {
                            FDGSceneSelector sceneSelector = new FDGSceneSelector(map);
                            DialogResult shouldPatch = sceneSelector.ShowDialog(this);
                            if (shouldPatch == DialogResult.Yes)
                            {
                                // Search it in the list of ids
                                foreach (int id in mapDataFdgIds)
                                {
                                    if (fdg.Scenes[id].Name == sceneSelector.sceneToPatch)
                                    {
                                        // Patch it you fucker
                                        fdg.Scenes[id] = PatchFDG(fdg.Scenes[id], mapRtdl);
                                    }
                                }
                            }
                        }
                    }

                    // Now save it
                    using (FileStream stream = new FileStream(textBoxFdg.Text, FileMode.Create, FileAccess.Write))
                    using (EndianBinaryWriter writer = new EndianBinaryWriter(stream))
                        fdg.Write(writer);
                }

                using (FileStream stream = new FileStream(map, FileMode.Create, FileAccess.Write))
                using (EndianBinaryWriter writer = new EndianBinaryWriter(stream))
                    mapRtdl.Write(writer);
                progressBarRandomizer.PerformStep();
                AddOutputMessage("Done!");
                mapId += 1;
            }

            MessageBox.Show("Finished randomizing levels.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            AddOutputMessage("Finished!");
        }

        private void buttonSelectPath_Click(object sender, EventArgs e)
        {
            using (FolderBrowserDialog dialog = new FolderBrowserDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxTargetPath.Text = dialog.SelectedPath;
                }
            }
        }

        private void buttonStart_Click(object sender, EventArgs e)
        {
            progressBarRandomizer.Value = 0;

            // Setup output message box
            richTextBoxMessage.Text = string.Empty;
            AddOutputMessage("Checking if the inputs are valid...");

            // Check if the inputs are valid
            AddOutputMessage("Checking if the target directory exists...");
            if (Directory.Exists(textBoxTargetPath.Text) == false)
            {
                MessageBox.Show("Can't find the target directory!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                AddOutputMessage("Process aborted : target directory not found.");
                return;
            }
            AddOutputMessage("Done!");

            // Check for FDG if not dx version
            if (checkBoxKrtdlDx.Checked == false)
            {
                AddOutputMessage("Checking for FDG...");
                if (File.Exists(textBoxFdg.Text) == false)
                {
                    AddOutputMessage("Did not find FDG at the designated path.");
                    DialogResult proceed = MessageBox.Show("Could not find FDG file! Without it, you will experience severe lag everytime a new object neeeds to be loaded.\nWould you like to continue regardless?", "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                    if (proceed == DialogResult.No)
                    {
                        AddOutputMessage("Process aborted : user chose to not continue without FDG.");
                        return;
                    }
                    AddOutputMessage("Proceeding without FDG.");
                }
                else AddOutputMessage("Done!");
            }

            // Setup progress bar
            string targetFileType;
            if (checkBoxKrtdlDx.Checked) targetFileType = "*.bin";
            else targetFileType = "*.dat";
            string[] files = Directory.GetFiles(textBoxTargetPath.Text, targetFileType, SearchOption.AllDirectories);
            progressBarRandomizer.Maximum = files.Length + 1;

            progressBarRandomizer.PerformStep();

            Randomize();
        }

        private void buttonRandomizeSeed_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            numericUpDownSeed.Value = rand.Next((int)numericUpDownSeed.Minimum, (int)numericUpDownSeed.Maximum);
        }

        private void buttonTilesCustomize_Click(object sender, EventArgs e)
        {
            TileSettings tileSettings = new TileSettings(this);
            tileSettings.ShowDialog();
        }

        private void checkBoxTiles_CheckedChanged(object sender, EventArgs e)
        {
            buttonTilesCustomize.Enabled = checkBoxTiles.Checked;
        }

        private void buttonFdg_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog dialog = new OpenFileDialog())
            {
                if (dialog.ShowDialog() == DialogResult.OK)
                {
                    textBoxFdg.Text = dialog.FileName;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FDG fdg = new FDG();
            using (FileStream stream = new FileStream(textBoxFdg.Text, FileMode.Open, FileAccess.Read))
            using (EndianBinaryReader reader = new EndianBinaryReader(stream))
                fdg.Read(reader);

            using (FileStream stream = new FileStream(textBoxFdg.Text, FileMode.Create, FileAccess.Write))
            using (EndianBinaryWriter writer = new EndianBinaryWriter(stream))
                fdg.Write(writer);
        }

        private void checkBoxKrtdlDx_CheckedChanged(object sender, EventArgs e)
        {
            bool enableFdgControlPool = !checkBoxKrtdlDx.Checked;

            labelFdg.Enabled = enableFdgControlPool;
            textBoxFdg.Enabled = enableFdgControlPool;
            buttonFdg.Enabled = enableFdgControlPool;
            checkBoxManualFdg.Enabled = enableFdgControlPool;
        }
    }
}
