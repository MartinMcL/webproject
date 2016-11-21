namespace Web_Assignment.Migrations
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Migrations;
    using System.Linq;
    using Newtonsoft.Json;
    using System.Collections.Generic;
    using Web_Assignment.Models;

    internal sealed class Configuration : DbMigrationsConfiguration<Web_Assignment.Models.ApplicationDbContext>
    {
        public Configuration()
        {
            AutomaticMigrationsEnabled = false;
        }

        protected override void Seed(Web_Assignment.Models.ApplicationDbContext context)
        {
            var stringObj = "[{\"id\":\"aceofspades\",\"name\":\"Ace Of Spades\",\"shortname\":\"AOS\",\"fullname\":\"Ace Of Spades: Battle Builder\",\"copyrights\":\"Jagex\"},{\"id\":\"act_of_agressions\",\"name\":\"Act of Agressions\",\"shortname\":\"AoA\",\"fullname\":\"Act of Agressions\",\"copyrights\":\"Focus Home Interactive\"},{\"id\":\"ageofempires2\",\"name\":\"Age of Empires 2\",\"shortname\":\"AOE 2\",\"fullname\":\"Age of Empires 2\",\"copyrights\":\"Ensemble Studios \\/ Microsoft\"},{\"id\":\"airmecharena\",\"name\":\"AirMech Arena\",\"shortname\":\"AMA\",\"fullname\":\"AirMech Arena\",\"copyrights\":\"Carbon Games \\/ Ubisoft\"},{\"id\":\"arma3\",\"name\":\"Arma 3\",\"shortname\":\"Arma 3\",\"fullname\":\"Arma 3\",\"copyrights\":\"Bohemia Interactive Studio\"},{\"id\":\"armored_warfare\",\"name\":\"Armored Warfare\",\"shortname\":\"AW\",\"fullname\":\"Armored Warfare\",\"copyrights\":\"Obsidian Entertainment\"},{\"id\":\"battleborn\",\"name\":\"Battleborn\",\"shortname\":\"Battleborn\",\"fullname\":\"Battleborn\",\"copyrights\":\"2K Games\"},{\"id\":\"battlefield1\",\"name\":\"Battlefield 1\",\"shortname\":\"Battlefield 1\",\"fullname\":\"Battlefield 1\",\"copyrights\":\"Electronic Arts\"},{\"id\":\"battlefield3\",\"name\":\"Battlefield 3\",\"shortname\":\"BF 3\",\"fullname\":\"Battlefield 3\",\"copyrights\":\"Digital Illusions CE \\/ Electronic Arts\"},{\"id\":\"battlefield4\",\"name\":\"Battlefield 4\",\"shortname\":\"BF4\",\"fullname\":\"Battlefield 4\",\"copyrights\":\"Digital Illusions CE \\/ Electronic Arts\"},{\"id\":\"battlefield_hardline\",\"name\":\"Battlefield Hardline\",\"shortname\":\"BF:Hardline\",\"fullname\":\"Battlefield Hardline\",\"copyrights\":\"Isceral Games \\/ Electronic Arts\"},{\"id\":\"battlefleet_gothic_armada\",\"name\":\"BF Gothic Ar\",\"shortname\":\"BFGA\",\"fullname\":\"Battlefleet Gothic: Armada\",\"copyrights\":\"Focus Home Interactive\"},{\"id\":\"battlerite\",\"name\":\"Battlerite\",\"shortname\":\"Battlerite\",\"fullname\":\"Battlerite\",\"copyrights\":\"Stunlock Studios\"},{\"id\":\"blade_and_soul\",\"name\":\"Blade & Soul\",\"shortname\":\"B&S\",\"fullname\":\"Blade & Soul\",\"copyrights\":\"NCsoft\"},{\"id\":\"blazbluechronophantasma\",\"name\":\"BlazBlue : Chrono Phantasma\",\"shortname\":\"BB:CP\",\"fullname\":\"BlazBlue : Chrono Phantasma\",\"copyrights\":\"Arc System Works\"},{\"id\":\"blocknload\",\"name\":\"Block N Load\",\"shortname\":\"BNL\",\"fullname\":\"Block N Load\",\"copyrights\":\"Jagex Games Studio\"},{\"id\":\"bloodbowl\",\"name\":\"Blood Bowl\",\"shortname\":\"BB\",\"fullname\":\"Blood Bowl\",\"copyrights\":\"Focus Home Interactive \\/ Cyanide\"},{\"id\":\"bloodbowl2\",\"name\":\"BloodBowl 2\",\"shortname\":\"BB2\",\"fullname\":\"BloodBowl 2\",\"copyrights\":\"Cyanide Studio\"},{\"id\":\"bomberman\",\"name\":\"Bomberman\",\"shortname\":\"Bomberman\",\"fullname\":\"Bomberman\",\"copyrights\":\"Hudson Soft\"},{\"id\":\"brawlhalla\",\"name\":\"Brawlhalla\",\"shortname\":\"Brawlhalla\",\"fullname\":\"Brawlhalla\",\"copyrights\":\"Blue Mammoth Games\"},{\"id\":\"callofchampions\",\"name\":\"Call of Champions\",\"shortname\":\"CoC\",\"fullname\":\"Call of Champions\",\"copyrights\":\"Spacetime Studios\"},{\"id\":\"chivalry_medieval_warfare\",\"name\":\"Chivalry\",\"shortname\":\"Chivalry\",\"fullname\":\"Chivalry: Medieval Warfare\",\"copyrights\":\"Torn Banner Studios\"},{\"id\":\"clash_royale\",\"name\":\"Clash Royale\",\"shortname\":\"Clash Royale\",\"fullname\":\"Clash Royale\",\"copyrights\":\"Supercell\"},{\"id\":\"cod4\",\"name\":\"COD4:MW\",\"shortname\":\"COD4\",\"fullname\":\"Call of Duty 4 : Modern Warfare\",\"copyrights\":\"Activision \\/ Infinity Ward\"},{\"id\":\"cod_advanced_warfare\",\"name\":\"COD:Advanced Warfare\",\"shortname\":\"COD:AW\",\"fullname\":\"Call of Duty: Advanced Warfare\",\"copyrights\":\"Activision \\/ Sledgehammer Games\"},{\"id\":\"cod_bo\",\"name\":\"COD: Black Ops\",\"shortname\":\"COD:BO\",\"fullname\":\"Call of Duty: Black Ops\",\"copyrights\":\"Activision \\/ Treyarch\"},{\"id\":\"cod_bo2\",\"name\":\"COD: Black Ops 2\",\"shortname\":\"COD:BO2\",\"fullname\":\"Call of Duty: Black Ops 2\",\"copyrights\":\"Activision \\/ Treyarch\"},{\"id\":\"cod_bo3\",\"name\":\"COD: Black Ops 3\",\"shortname\":\"COD:BO3\",\"fullname\":\"Call of Duty: Black Ops 3\",\"copyrights\":\"Activision \\/ Treyarch\"},{\"id\":\"cod_ghosts\",\"name\":\"COD: Ghosts\",\"shortname\":\"COD:Ghosts\",\"fullname\":\"Call of Duty: Ghosts\",\"copyrights\":\"Activision \\/ Infinity Ward\"},{\"id\":\"cod_infinite_warfare\",\"name\":\"COD: Infinite Warfare\",\"shortname\":\"COD:IW\",\"fullname\":\"Call of Duty: Infinite Warfare\",\"copyrights\":\"Activision \\/ Infinity Ward\"},{\"id\":\"cod_mw2\",\"name\":\"COD: Modern Warfare 2\",\"shortname\":\"COD:MW2\",\"fullname\":\"Call of Duty: Modern Warfare 2\",\"copyrights\":\"Activision \\/ Infinity Ward\"},{\"id\":\"cod_mw3\",\"name\":\"COD: Modern Warfare 3\",\"shortname\":\"COD:MW3\",\"fullname\":\"Call of Duty: Modern Warfare 3\",\"copyrights\":\"Activision \\/ Infinity Ward\"},{\"id\":\"cod_world_at_war\",\"name\":\"COD: World at War\",\"shortname\":\"COD:WW\",\"fullname\":\"Call of Duty: World at War\",\"copyrights\":\"Activision \\/ Treyarch\"},{\"id\":\"combat_arms\",\"name\":\"Combat Arms\",\"shortname\":\"Combat Arms\",\"fullname\":\"Combat Arms\",\"copyrights\":\"Nexon\"},{\"id\":\"company_of_heroes2\",\"name\":\"Company of heroes 2\",\"shortname\":\"COH2\",\"fullname\":\"Company of heroes 2\",\"copyrights\":\"Relic Entertainment\"},{\"id\":\"connect4\",\"name\":\"Connect 4\",\"shortname\":\"Connect 4\",\"fullname\":\"Connect 4\",\"copyrights\":\"Party Game\"},{\"id\":\"counterstrike16\",\"name\":\"Counter-Strike 1.6\",\"shortname\":\"CS 1.6\",\"fullname\":\"Counter-Strike 1.6\",\"copyrights\":\"Valve Software\"},{\"id\":\"counterstrike_go\",\"name\":\"Counter-Strike: GO\",\"shortname\":\"CS:GO\",\"fullname\":\"Counter-Strike: Global Offensive\",\"copyrights\":\"Valve Software\"},{\"id\":\"counterstrikesource\",\"name\":\"Counter-Strike: Source\",\"shortname\":\"CS:Source\",\"fullname\":\"Counter-Strike: Source\",\"copyrights\":\"Valve Software\"},{\"id\":\"critical_ops\",\"name\":\"Critical Ops\",\"shortname\":\"C-Ops\",\"fullname\":\"Critical Ops\",\"copyrights\":\"Critical Force\"},{\"id\":\"crossfire\",\"name\":\"Crossfire\",\"shortname\":\"Crossfire\",\"fullname\":\"Crossfire : Rival Factions\",\"copyrights\":\"Neowiz \\/ SmileGate\"},{\"id\":\"dawngate\",\"name\":\"Dawngate\",\"shortname\":\"Dawngate\",\"fullname\":\"Dawngate\",\"copyrights\":\"Waystone Games \\/ EA Games\"},{\"id\":\"deadoralive5_lastround\",\"name\":\"Dead Or Alive 5 LR\",\"shortname\":\"DOA5 LR\",\"fullname\":\"Dead Or Alive 5 Last Round\",\"copyrights\":\"Koei Tecmo\"},{\"id\":\"destiny\",\"name\":\"Destiny\",\"shortname\":\"Destiny\",\"fullname\":\"Destiny\",\"copyrights\":\"Activision\"},{\"id\":\"doc\",\"name\":\"Duel of Champions\",\"shortname\":\"DOC\",\"fullname\":\"Might & Magic: Duel of Champions\",\"copyrights\":\"Ubisoft\"},{\"id\":\"dofus\",\"name\":\"Dofus\",\"shortname\":\"Dofus\",\"fullname\":\"Dofus\",\"copyrights\":\"Ankama\"},{\"id\":\"dota2\",\"name\":\"Dota2\",\"shortname\":\"Dota2\",\"fullname\":\"Defense of the Ancients 2\",\"copyrights\":\"Valve Software\"},{\"id\":\"doom\",\"name\":\"Doom\",\"shortname\":\"Doom\",\"fullname\":\"Doom\",\"copyrights\":\"id Software\"},{\"id\":\"duelyst\",\"name\":\"Duelyst\",\"shortname\":\"Duelyst\",\"fullname\":\"Duelyst\",\"copyrights\":\"Counterplay Games\"},{\"id\":\"elite_dangerous\",\"name\":\"Elite Dangerous\",\"shortname\":\"E:D\",\"fullname\":\"Elite Dangerous\",\"copyrights\":\"Frontier Developments\"},{\"id\":\"endgods_league_of_gods\",\"name\":\"Endgods LOG\",\"shortname\":\"Endgods\",\"fullname\":\"Endgods League of Gods\",\"copyrights\":\"Sparkjumpers\"},{\"id\":\"faeria\",\"name\":\"Faeria\",\"shortname\":\"Faeria\",\"fullname\":\"Faeria\",\"copyrights\":\"Abrakam\"},{\"id\":\"fatesforever\",\"name\":\"Fates Forever\",\"shortname\":\"Fates\",\"fullname\":\"Fates Forever\",\"copyrights\":\"Hammer & Chisel\"},{\"id\":\"fifa\",\"name\":\"Fifa 14\",\"shortname\":\"Fifa 14\",\"fullname\":\"Fifa 14\",\"copyrights\":\"EA Sports\"},{\"id\":\"fifa15\",\"name\":\"Fifa 15\",\"shortname\":\"Fifa 15\",\"fullname\":\"Fifa 15\",\"copyrights\":\"EA Sports\"},{\"id\":\"fifa16\",\"name\":\"Fifa 16\",\"shortname\":\"Fifa 16\",\"fullname\":\"Fifa 16\",\"copyrights\":\"EA Sports\"},{\"id\":\"fifa17\",\"name\":\"Fifa 17\",\"shortname\":\"Fifa 17\",\"fullname\":\"Fifa 17\",\"copyrights\":\"EA Sports\"},{\"id\":\"forza6\",\"name\":\"Forza Motorsport 6\",\"shortname\":\"Forza 6\",\"fullname\":\"Forza Motorsport 6\",\"copyrights\":\"Microsoft Studios \\/ Turn 10\"},{\"id\":\"gamesofglory\",\"name\":\"Games of Glory\",\"shortname\":\"GoG\",\"fullname\":\"Games of Glory\",\"copyrights\":\"Lighbulb Crew\"},{\"id\":\"gearsofwar3\",\"name\":\"Gears of War 3\",\"shortname\":\"GoW3\",\"fullname\":\"Gears of War 3\",\"copyrights\":\"Epic Games \\/ Microsoft Studios\"},{\"id\":\"gearsofwar4\",\"name\":\"Gears of War 4\",\"shortname\":\"GoW4\",\"fullname\":\"Gears of War 4\",\"copyrights\":\"Microsoft Studios \\/ The Coalition\"},{\"id\":\"gearsofwarue\",\"name\":\"Gears of War Ultimate Edition\",\"shortname\":\"GoW:UE\",\"fullname\":\"Gears of War Ultimate Edition\",\"copyrights\":\"Black Tusk \\/ Microsoft Studios\"},{\"id\":\"generic\",\"name\":\"Generic Discipline\",\"shortname\":\"Generic\",\"fullname\":\"Generic Discipline: game or sport\",\"copyrights\":\"none\"},{\"id\":\"ghost_recon_phantoms\",\"name\":\"Ghost Recon Phantoms\",\"shortname\":\"GR Phantoms\",\"fullname\":\"Tom Clancy's Ghost Recon Phantoms\",\"copyrights\":\"Ubisoft\"},{\"id\":\"gigantic\",\"name\":\"Gigantic\",\"shortname\":\"Gigantic\",\"fullname\":\"Gigantic\",\"copyrights\":\"Motiga\"},{\"id\":\"gta5\",\"name\":\"GTA 5\",\"shortname\":\"GTA 5\",\"fullname\":\"Grand Theft Auto V\",\"copyrights\":\"Rockstar Games\"},{\"id\":\"guildwars2\",\"name\":\"Guild Wars 2\",\"shortname\":\"GW2\",\"fullname\":\"Guild Wars 2\",\"copyrights\":\"ArenaNet \\/ NCsoft\"},{\"id\":\"guiltygear_xrd\",\"name\":\"Guilty Gear XRD\",\"shortname\":\"GG XRD\",\"fullname\":\"Guilty Gear XRD\",\"copyrights\":\"Aksys Games\"},{\"id\":\"guiltygear_xrd_revelator\",\"name\":\"Guilty Gear XRD Rev.\",\"shortname\":\"GG XRD R.\",\"fullname\":\"Guilty Gear XRD Revelator\",\"copyrights\":\"Aksys Games\"},{\"id\":\"guitar_hero_live\",\"name\":\"Guitar Hero Live\",\"shortname\":\"GH Live\",\"fullname\":\"Guitar Hero Live\",\"copyrights\":\"Activision\"},{\"id\":\"gwent\",\"name\":\"Gwent\",\"shortname\":\"Gwent\",\"fullname\":\"Gwent\",\"copyrights\":\"CD Projekt\"},{\"id\":\"halo5_guardians\",\"name\":\"Halo 5\",\"shortname\":\"Halo 5\",\"fullname\":\"Halo 5 Guardians\",\"copyrights\":\"Microsoft\"},{\"id\":\"hearthstone\",\"name\":\"Hearthstone\",\"shortname\":\"Hearthstone\",\"fullname\":\"Hearthstone Heroes of Warcraft\",\"copyrights\":\"Activision Blizzard\"},{\"id\":\"heroes_of_order_and_chaos\",\"name\":\"Heroes of Order & Chaos\",\"shortname\":\"HOC\",\"fullname\":\"Heroes of Order & Chaos\",\"copyrights\":\"Gameloft\"},{\"id\":\"heroesofthestorm\",\"name\":\"Heroes of The Storm\",\"shortname\":\"HotS\",\"fullname\":\"Heros of The Storm\",\"copyrights\":\"Activision Blizzard\"},{\"id\":\"injustice_gods_among_us\",\"name\":\"Injustice GAU\",\"shortname\":\"Injustice\",\"fullname\":\"Injustice Gods Among Us\",\"copyrights\":\"Warner Bros Games \\/ NetherRealm Studios\"},{\"id\":\"jojoallstarbattle\",\"name\":\"JoJo All Star Battle\",\"shortname\":\"JoJo:ASB\",\"fullname\":\"JoJo's Bizarre Adventure : All Star Battle\",\"copyrights\":\"Bandai Namco Games\"},{\"id\":\"justdance2014\",\"name\":\"Just Dance 2014\",\"shortname\":\"JD2014\",\"fullname\":\"Just Dance 2014\",\"copyrights\":\"Ubisoft\"},{\"id\":\"justdance2015\",\"name\":\"Just Dance 2015\",\"shortname\":\"JD2015\",\"fullname\":\"Just Dance 2015\",\"copyrights\":\"Ubisoft\"},{\"id\":\"justdance2016\",\"name\":\"Just Dance 2016\",\"shortname\":\"JD2016\",\"fullname\":\"Just Dance 2016\",\"copyrights\":\"Ubisoft\"},{\"id\":\"justdance2017\",\"name\":\"Just Dance 2017\",\"shortname\":\"JD2017\",\"fullname\":\"Just Dance 2017\",\"copyrights\":\"Ubisoft\"},{\"id\":\"killer_instinct\",\"name\":\"Killer Instinct\",\"shortname\":\"KI\",\"fullname\":\"Killer Instinct\",\"copyrights\":\"Microsoft \\/ Double Helix Games\"},{\"id\":\"krosmaga\",\"name\":\"Krosmaga\",\"shortname\":\"Krosmaga\",\"fullname\":\"Krosmaga\",\"copyrights\":\"Ankama\"},{\"id\":\"last_fight_game\",\"name\":\"LASTFIGHT\",\"shortname\":\"LASTFIGHT\",\"fullname\":\"LASTFIGHT\",\"copyrights\":\"Piranaking\"},{\"id\":\"leagueoflegends\",\"name\":\"League Of Legends\",\"shortname\":\"LOL\",\"fullname\":\"League Of Legends\",\"copyrights\":\"Riot Games\"},{\"id\":\"left4dead2\",\"name\":\"Left 4 Dead 2\",\"shortname\":\"L4D2\",\"fullname\":\"Left 4 Dead 2\",\"copyrights\":\"Valve Software\"},{\"id\":\"madden17\",\"name\":\"Madden 17\",\"shortname\":\"Madden 17\",\"fullname\":\"Madden 17\",\"copyrights\":\"EA Sports\"},{\"id\":\"maddennfl15\",\"name\":\"Madden NFL 15\",\"shortname\":\"NFL 15\",\"fullname\":\"Madden NFL 15\",\"copyrights\":\"EA Sports\"},{\"id\":\"mariokart\",\"name\":\"Mario Kart\",\"shortname\":\"MKart\",\"fullname\":\"Mario Kart\",\"copyrights\":\"Nintendo\"},{\"id\":\"mariokart8\",\"name\":\"Mario Kart 8\",\"shortname\":\"MKart 8\",\"fullname\":\"Mario Kart 8\",\"copyrights\":\"Nintendo\"},{\"id\":\"mayhem\",\"name\":\"Mayhem\",\"shortname\":\"Mayhem\",\"fullname\":\"Mayhem - PvP Arena Action\",\"copyrights\":\"Chobolabs\"},{\"id\":\"minecraft\",\"name\":\"Minecraft\",\"shortname\":\"Minecraft\",\"fullname\":\"Minecraft\",\"copyrights\":\"Mojang AB\"},{\"id\":\"monster_strike\",\"name\":\"Monster Strike\",\"shortname\":\"Monster Strike\",\"fullname\":\"Monster Strike\",\"copyrights\":\"Mixi\"},{\"id\":\"mech_warriors_online\",\"name\":\"MechWarrior Online\",\"shortname\":\"MWO\",\"fullname\":\"MechWarrior Online\",\"copyrights\":\"Piranha Games\"},{\"id\":\"mortalkombatx\",\"name\":\"Mortal Kombat X\",\"shortname\":\"MKX\",\"fullname\":\"Mortal Kombat X\",\"copyrights\":\"Warner Bros\"},{\"id\":\"naruto_storm4\",\"name\":\"Naruto SUN Storm 4\",\"shortname\":\"Naruto SUNS 4\",\"fullname\":\"Naruto Shippuden Ultimate Ninja Storm 4\",\"copyrights\":\"Namco Bandai\"},{\"id\":\"nba2k16\",\"name\":\"NBA 2k16\",\"shortname\":\"NBA 2k16\",\"fullname\":\"NBA 2k16\",\"copyrights\":\"2K Sports\"},{\"id\":\"nba2k17\",\"name\":\"NBA 2k17\",\"shortname\":\"NBA 2k17\",\"fullname\":\"NBA 2k17\",\"copyrights\":\"2K Sports\"},{\"id\":\"nhl16\",\"name\":\"NHL 16\",\"shortname\":\"NHL 16\",\"fullname\":\"NHL 16\",\"copyrights\":\"EA Sports\"},{\"id\":\"nhl17\",\"name\":\"NHL 2017\",\"shortname\":\"NHL 2017\",\"fullname\":\"NHL 2017\",\"copyrights\":\"Electronic Arts \\/ EA Sports\"},{\"id\":\"overwatch\",\"name\":\"Overwatch\",\"shortname\":\"Overwatch\",\"fullname\":\"Overwatch\",\"copyrights\":\"Activision Blizzard\"},{\"id\":\"paladins\",\"name\":\"Paladins: COTR\",\"shortname\":\"Paladins\",\"fullname\":\"Paladins: Champions of the Realm\",\"copyrights\":\"Hi-Rez Studios\"},{\"id\":\"paragon\",\"name\":\"Paragon\",\"shortname\":\"Paragon\",\"fullname\":\"Paragon\",\"copyrights\":\"Epic Games\"},{\"id\":\"pes2014\",\"name\":\"PES 2014\",\"shortname\":\"PES2014\",\"fullname\":\"Pro Evolution Soccer 2014\",\"copyrights\":\"Konami\"},{\"id\":\"pes2015\",\"name\":\"PES 2015\",\"shortname\":\"PES2015\",\"fullname\":\"Pro Evolution Soccer 2015\",\"copyrights\":\"Konami\"},{\"id\":\"pes2016\",\"name\":\"PES 2016\",\"shortname\":\"PES2016\",\"fullname\":\"Pro Evolution Soccer 2016\",\"copyrights\":\"Konami\"},{\"id\":\"pes2017\",\"name\":\"PES 2017\",\"shortname\":\"PES 2017\",\"fullname\":\"Pro Evolution Soccer 2017\",\"copyrights\":\"Konami\"},{\"id\":\"planetside2\",\"name\":\"PlanetSide 2\",\"shortname\":\"PS2\",\"fullname\":\"PlanetSide 2\",\"copyrights\":\"Daybreak Game Company\"},{\"id\":\"point_blank\",\"name\":\"Point Blank\",\"shortname\":\"Point Blank\",\"fullname\":\"Point Blank\",\"copyrights\":\"Garena Online\"},{\"id\":\"pokemon\",\"name\":\"Pokemon\",\"shortname\":\"Pokemon\",\"fullname\":\"Pokemon\",\"copyrights\":\"Nintendo\"},{\"id\":\"pokken\",\"name\":\"Pokk\\u00e9n Tournament\",\"shortname\":\"Pokk\\u00e9n T.\",\"fullname\":\"Pokk\\u00e9n Tournament\",\"copyrights\":\"The Pok\\u00e9mon Company\"},{\"id\":\"quake_champions\",\"name\":\"Quake Champions\",\"shortname\":\"Quake Ch.\",\"fullname\":\"Quake Champions\",\"copyrights\":\"Bethesda Softworks\"},{\"id\":\"quakelive\",\"name\":\"Quake Live\",\"shortname\":\"QL\",\"fullname\":\"Quake Live\",\"copyrights\":\"id Software\"},{\"id\":\"rainbowsix_siege\",\"name\":\"Rainbow Six Siege\",\"shortname\":\"R6 Siege\",\"fullname\":\"Tom Clancy's Rainbow Six Siege\",\"copyrights\":\"Ubisoft\"},{\"id\":\"red_orchestra2\",\"name\":\"Red Orchestra 2\",\"shortname\":\"RO2\",\"fullname\":\"Red Orchestra 2 : Heroes of Stalingrad\",\"copyrights\":\"Ubisoft\"},{\"id\":\"reflex\",\"name\":\"Reflex\",\"shortname\":\"Reflex\",\"fullname\":\"Reflex\",\"copyrights\":\"Turbo Pixel\"},{\"id\":\"rigs_mcl\",\"name\":\"RIGS MCL\",\"shortname\":\"RIGS\",\"fullname\":\"RIGS Mechanized Combat League\",\"copyrights\":\"Sony Interactive Entertainment \\/ Guerrilla Cambridge\"},{\"id\":\"risingthunder\",\"name\":\"Rising Thunder\",\"shortname\":\"RThunder\",\"fullname\":\"Rising Thunder\",\"copyrights\":\"Radiant Entertainment\"},{\"id\":\"rivals_of_aether\",\"name\":\"Rivals of Aether\",\"shortname\":\"RoA\",\"fullname\":\"Rivals of Aether\",\"copyrights\":\"Microsoft\"},{\"id\":\"rocketleague\",\"name\":\"Rocket League\",\"shortname\":\"RL\",\"fullname\":\"Rocket League\",\"copyrights\":\"Psyonix\"},{\"id\":\"rugbywc15\",\"name\":\"Rugby WC 15\",\"shortname\":\"RugbyWC15\",\"fullname\":\"Rugby World Cup 15\",\"copyrights\":\"Bigben Interactive\"},{\"id\":\"secretponchos\",\"name\":\"Secret Ponchos\",\"shortname\":\"SP\",\"fullname\":\"Secret Ponchos\",\"copyrights\":\"Switchblade Monkeys\"},{\"id\":\"shardsofwar\",\"name\":\"Shards of War\",\"shortname\":\"SoW\",\"fullname\":\"Shards of War\",\"copyrights\":\"Bigpoint\"},{\"id\":\"shootmania_storm_elite\",\"name\":\"Shootmania Storm Elite\",\"shortname\":\"SMS:Elite\",\"fullname\":\"Shootmania Storm Elite\",\"copyrights\":\"Nadeo \\/ Ubisoft\"},{\"id\":\"smite\",\"name\":\"Smite\",\"shortname\":\"Smite\",\"fullname\":\"Smite\",\"copyrights\":\"Hi-Rez Studios\"},{\"id\":\"soulcalibur5\",\"name\":\"SoulCalibur V\",\"shortname\":\"SCV\",\"fullname\":\"SoulCalibur V\",\"copyrights\":\"Namco Bandai\"},{\"id\":\"splatoon\",\"name\":\"Splatoon\",\"shortname\":\"Splatoon\",\"fullname\":\"splatoon\",\"copyrights\":\"Nintendo\"},{\"id\":\"squad\",\"name\":\"Squad\",\"shortname\":\"Squad\",\"fullname\":\"Squad\",\"copyrights\":\"Offworld Industries\"},{\"id\":\"starcraft2_hots\",\"name\":\"Starcraft II: HOTS\",\"shortname\":\"SCII:HOTS\",\"fullname\":\"Starcraft II: Heart of the Swarm\",\"copyrights\":\"Activision Blizzard\"},{\"id\":\"starcraft2_lotv\",\"name\":\"Starcraft II: LOTV\",\"shortname\":\"SCII:LOTV\",\"fullname\":\"Starcraft II: Legacy of the Void\",\"copyrights\":\"Activision Blizzard\"},{\"id\":\"starcraft2_wol\",\"name\":\"Starcraft II: WOL\",\"shortname\":\"SCII:WOL\",\"fullname\":\"Starcraft II: Wings of Liberty\",\"copyrights\":\"Activision Blizzard\"},{\"id\":\"starwars_battlefront\",\"name\":\"Star Wars Battlefront\",\"shortname\":\"Battlefront\",\"fullname\":\"Star Wars Battlefront\",\"copyrights\":\"Electronic Arts\"},{\"id\":\"steel_ocean\",\"name\":\"Steel Ocean\",\"shortname\":\"Steel Ocean\",\"fullname\":\"Steel Ocean\",\"copyrights\":\"Changyou.com\"},{\"id\":\"streetfighter2\",\"name\":\"Street Fighter II\",\"shortname\":\"SFII\",\"fullname\":\"Street Fighter II\",\"copyrights\":\"Capcom\"},{\"id\":\"streetfighter3\",\"name\":\"Street Fighter III\",\"shortname\":\"SFIII\",\"fullname\":\"Street Fighter III\",\"copyrights\":\"Capcom\"},{\"id\":\"streetfighter4\",\"name\":\"Street Fighter IV\",\"shortname\":\"SFIV\",\"fullname\":\"Street Fighter IV\",\"copyrights\":\"Capcom\"},{\"id\":\"streetfighter4_ultra\",\"name\":\"Ultra Street Fighter IV\",\"shortname\":\"USFIV\",\"fullname\":\"Ultra Street Fighter IV\",\"copyrights\":\"Capcom\"},{\"id\":\"streetfighter5\",\"name\":\"Street Fighter V\",\"shortname\":\"SFV\",\"fullname\":\"Street Fighter V\",\"copyrights\":\"Capcom\"},{\"id\":\"strife\",\"name\":\"Strife\",\"shortname\":\"Strife\",\"fullname\":\"Strife\",\"copyrights\":\"S2 Games\"},{\"id\":\"summoners_war\",\"name\":\"Summoners War\",\"shortname\":\"Summoners War\",\"fullname\":\"Summoners War\",\"copyrights\":\"Com2uS\"},{\"id\":\"super_senso\",\"name\":\"Super Senso\",\"shortname\":\"Super Senso\",\"fullname\":\"Super Senso\",\"copyrights\":\"Turbo Studios\"},{\"id\":\"supersmashbros\",\"name\":\"Super Smash Bros\",\"shortname\":\"SSB\",\"fullname\":\"Super Smash Bros\",\"copyrights\":\"Namco \\/ Nintendo\"},{\"id\":\"supersmashbros_3ds_wiiu\",\"name\":\"S. Smash Bros. 3DS\\/WIIU\",\"shortname\":\"SSB. 3DS\\/WIIU\",\"fullname\":\"Super Smash Bros. 3DS\\/WIIU\",\"copyrights\":\"Nintendo\"},{\"id\":\"supersmashbros_melee\",\"name\":\"S. Smash Bros. Melee\",\"shortname\":\"SSB. Melee\",\"fullname\":\"Super Smash Bros. Melee\",\"copyrights\":\"Nintendo\"},{\"id\":\"tanki_online\",\"name\":\"Tanki Online\",\"shortname\":\"Tanki O.\",\"fullname\":\"Tanki Online\",\"copyrights\":\"Alternativa Platform\"},{\"id\":\"teamfortress2\",\"name\":\"Team Fortress 2\",\"shortname\":\"TF2\",\"fullname\":\"Team Fortress 2\",\"copyrights\":\"Valve Software\"},{\"id\":\"tekken7\",\"name\":\"Tekken 7\",\"shortname\":\"Tekken 7\",\"fullname\":\"Tekken 7\",\"copyrights\":\"Bandai Namco\"},{\"id\":\"tekkentagtournament2\",\"name\":\"Tekken Tag Tournament 2\",\"shortname\":\"TTT2\",\"fullname\":\"Tekken Tag Tournament 2\",\"copyrights\":\"Bandai Namco Games\"},{\"id\":\"theelderscrolls_legends\",\"name\":\"TES: Legends\",\"shortname\":\"TES:L\",\"fullname\":\"The Elder Scrolls Legends\",\"copyrights\":\"Bethesda Softworks \\/ Dire Wolf\"},{\"id\":\"thekingoffighters13\",\"name\":\"The King Of Fighters 13\",\"shortname\":\"KOF 13\",\"fullname\":\"The King Of Fighters 13\",\"copyrights\":\"SNK \\/ Rising Star Games\"},{\"id\":\"titanfall\",\"name\":\"Titanfall\",\"shortname\":\"Titanfall\",\"fullname\":\"Titanfall\",\"copyrights\":\"Respawn Entertainment \\/ EA Games\"},{\"id\":\"titanfall2\",\"name\":\"Titanfall 2\",\"shortname\":\"Titanfall 2\",\"fullname\":\"Titanfall 2\",\"copyrights\":\"Electronic Arts\"},{\"id\":\"towerfall_ascension\",\"name\":\"TowerFall Ascension\",\"shortname\":\"TowerFall A.\",\"fullname\":\"TowerFall Ascension\",\"copyrights\":\"Matt Makes Games\"},{\"id\":\"trackmania2stadium\",\"name\":\"TrackMania 2 Stadium\",\"shortname\":\"TM2\",\"fullname\":\"TrackMania 2 Stadium\",\"copyrights\":\"Nadeo \\/ Ubisoft\"},{\"id\":\"trackmania_turbo\",\"name\":\"TrackMania Turbo\",\"shortname\":\"TM Turbo\",\"fullname\":\"TrackMania Turbo\",\"copyrights\":\"Ubisoft\"},{\"id\":\"trials_fusion\",\"name\":\"Trials Fusion\",\"shortname\":\"Trials Fusion\",\"fullname\":\"Trials Fusion\",\"copyrights\":\"Ubisoft\"},{\"id\":\"ufc2\",\"name\":\"EA Sports UFC 2\",\"shortname\":\"UFC 2\",\"fullname\":\"EA Sports UFC 2\",\"copyrights\":\"EA Sports\"},{\"id\":\"ultimatemarvelvscapcom3\",\"name\":\"Ultimate Marvel VS Capcom 3\",\"shortname\":\"UMVSC3\",\"fullname\":\"Ultimate Marvel VS Capcom 3\",\"copyrights\":\"Capcom\"},{\"id\":\"unreal_tournament\",\"name\":\"Unreal Tournament\",\"shortname\":\"UT\",\"fullname\":\"Unreal Tournament\",\"copyrights\":\"Epic Games\"},{\"id\":\"urban_terror\",\"name\":\"Urban Terror\",\"shortname\":\"Urban Terror\",\"fullname\":\"Urban Terror\",\"copyrights\":\"Frozen Sand\"},{\"id\":\"ut2004\",\"name\":\"Unreal Tournament 2004\",\"shortname\":\"UT2004\",\"fullname\":\"Unreal Tournament 2004\",\"copyrights\":\"Epic Games\"},{\"id\":\"vainglory\",\"name\":\"Vainglory\",\"shortname\":\"Vainglory\",\"fullname\":\"Vainglory\",\"copyrights\":\"Super Evil Megacorp\"},{\"id\":\"worldoftanks\",\"name\":\"World Of Tanks\",\"shortname\":\"WoT\",\"fullname\":\"World Of Tanks\",\"copyrights\":\"Wargaming\"},{\"id\":\"worldofwarplanes\",\"name\":\"World Of Warplanes\",\"shortname\":\"WoWP\",\"fullname\":\"World Of Warplanes\",\"copyrights\":\"Wargaming\"},{\"id\":\"worldofwarships\",\"name\":\"World Of Warships\",\"shortname\":\"WO Warships\",\"fullname\":\"World Of Warships\",\"copyrights\":\"Wargaming.net\"},{\"id\":\"wwe2k17\",\"name\":\"WWE 2K17\",\"shortname\":\"WWE 2K17\",\"fullname\":\"WWE 2K17\",\"copyrights\":\"2K Sports \\/ Visual Concepts & Yuke's\"}]";
            var sportList = JsonConvert.DeserializeObject<List<FullSport>>(stringObj.ToString());
            foreach (FullSport sp in sportList)
            {
                context.Sports.AddOrUpdate(
                s => s.sportName,
                new Sport { sportName = sp.name, APISportID = sp.id }
                );
            }

            context.SaveChanges();

            //  This method will be called after migrating to the latest version.

            //  You can use the DbSet<T>.AddOrUpdate() helper extension method 
            //  to avoid creating duplicate seed data. E.g.
            //
            //    context.People.AddOrUpdate(
            //      p => p.FullName,
            //      new Person { FullName = "Andrew Peters" },
            //      new Person { FullName = "Brice Lambson" },
            //      new Person { FullName = "Rowan Miller" }
            //    );
            //
        }

    }
}
class FullSport {
    public string id { get; set; }
    public string name { get; set; }
    public string shortname { get; set; }
    public string fullname { get; set; }
    public string copyrights { get; set; }
}
