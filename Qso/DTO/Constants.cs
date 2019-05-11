using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Qso.DTO
{
    public class GameMode
    {
        public static string Classic { get; } = "CLASSIC";
        public static string ARAM { get; } = "ARAM";
        public static string Tutorial { get; } = "TUTORIAL";
        public static string URF { get; } = "URF";
        public static string PracticeTool { get; } = "PRACTICETOOL"; // undocumented on Riot's constants
    }

    public class SpectatorPolicy
    {
        public static string NotAllowed { get; } = "NotAllowed";
        public static string LobbyAllowed { get; } = "LobbyAllowed";
        public static string FriendsAllowed { get; } = "FriendsAllowed";
        public static string AllAllowed { get; } = "AllAllowed";
    }

    public enum QueueType : int
    {
        NormalDraftPick = 400,
        RankedSoloDuo = 420,
        NormalBlindPick = 430,
        RankedFlex = 440,
        ARAM = 450,
        TwistedTreelineBlind = 460,
        TwistedTreelineFlex = 470,
        Clash = 700,
        TwistedTreelineIntermediateAI = 800,
        TwistedTreelineBeginnerAI = 820,
        SummonersRiftIntroAI = 830,
        SummonersRiftBeginnerAI = 840,
        SummonersRiftIntermediateAI = 850,
    };

    public enum GameType : int
    {
        Blind = 1,
        Draft = 2,
        AllRandom = 4,
        TournamentDraft = 6
    }

    public enum MapID : int
    {
        TwistedTreeline = 10,
        SummonersRift = 11,
        HowlingAbyss = 12,
        ButchersBridge = 14,
    };

    public enum TeamID : int
    {
        Team1 = 100,
        Team2 = 200
    }

    public enum ChampionID : int
    {
        Aatrox = 266,
        Ahri = 103,
        Akali = 84,
        Alistar = 12,
        Amumu = 32,
        Anivia = 34,
        Annie = 1,
        Ashe = 22,
        AurelionSol = 136,
        Azir = 268,
        Bard = 432,
        Blitzcrank = 53,
        Brand = 63,
        Braum = 201,
        Caitlyn = 51,
        Camille = 164,
        Cassiopeia = 69,
        Chogath = 31,
        Corki = 42,
        Darius = 122,
        Diana = 131,
        Draven = 119,
        DrMundo = 36,
        Ekko = 245,
        Elise = 60,
        Evelynn = 28,
        Ezreal = 81,
        FiddleSticks = 9,
        Fiora = 114,
        Fizz = 105,
        Galio = 3,
        Gangplank = 41,
        Garen = 86,
        Gnar = 150,
        Gragas = 79,
        Graves = 104,
        Hecarim = 120,
        Heimerdinger = 74,
        Illaoi = 420,
        Irelia = 39,
        Ivern = 427,
        Janna = 40,
        JarvanIV = 59,
        Jax = 24,
        Jayce = 126,
        Jhin = 202,
        Jinx = 222,
        Kalista = 429,
        Karma = 43,
        Karthus = 30,
        Kassadin = 38,
        Katarina = 55,
        Kayle = 10,
        Kennen = 85,
        Khazix = 121,
        Kindred = 203,
        Kled = 240,
        KogMaw = 96,
        Leblanc = 7,
        LeeSin = 64,
        Leona = 89,
        Lissandra = 127,
        Lucian = 236,
        Lulu = 117,
        Lux = 99,
        Malphite = 54,
        Malzahar = 90,
        Maokai = 57,
        MasterYi = 11,
        MissFortune = 21,
        MonkeyKing = 62,
        Mordekaiser = 82,
        Morgana = 25,
        Nami = 267,
        Nasus = 75,
        Nautilus = 111,
        Nidalee = 76,
        Nocturne = 56,
        Nunu = 20,
        Olaf = 2,
        Orianna = 61,
        Pantheon = 80,
        Poppy = 78,
        Quinn = 133,
        Rammus = 33,
        RekSai = 421,
        Renekton = 58,
        Rengar = 107,
        Riven = 92,
        Rumble = 68,
        Ryze = 13,
        Sejuani = 113,
        Shaco = 35,
        Shen = 98,
        Shyvana = 102,
        Singed = 27,
        Sion = 14,
        Sivir = 15,
        Skarner = 72,
        Sona = 37,
        Soraka = 16,
        Swain = 50,
        Syndra = 134,
        TahmKench = 223,
        Taliyah = 163,
        Talon = 91,
        Taric = 44,
        Teemo = 17,
        Thresh = 412,
        Tristana = 18,
        Trundle = 48,
        Tryndamere = 23,
        TwistedFate = 4,
        Twitch = 29,
        Udyr = 77,
        Urgot = 6,
        Varus = 110,
        Vayne = 67,
        Veigar = 45,
        Velkoz = 161,
        Vi = 254,
        Viktor = 112,
        Vladimir = 8,
        Volibear = 106,
        Warwick = 19,
        Xerath = 101,
        XinZhao = 5,
        Yasuo = 157,
        Yorick = 83,
        Zac = 154,
        Zed = 238,
        Ziggs = 115,
        Zilean = 26,
        Zyra = 143
    }

    public enum SummonerSpell : int
    {
        Barrier = 21,
        Cleanse = 1,
        Ignite = 14,
        Exhaust = 3,
        Flash = 4,
        Ghost = 6,
        Heal = 7,
        Clarity = 13,
        Smite = 11,
        SnowballMark = 32,
        Teleport = 12
    }
}
