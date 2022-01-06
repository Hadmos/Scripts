//cs_include Scripts/CoreBots.cs
//cs_include Scripts/Hollowborn/CoreHollowborn.cs
//cs_include Scripts/Hollowborn/HollowbornPaladin/LetsGetYouASuit.cs
//cs_include Scripts/Hollowborn/HollowbornPaladin/IGotYourBackAndYourTop.cs
//cs_include Scripts/Hollowborn/HollowbornPaladin/TheDarkSacrifice.cs
//cs_include Scripts/Hollowborn/HollowbornPaladin/ThePostSummoning.cs
//cs_include Scripts/Good/BLoD/CoreBLOD.cs
//cs_include Scripts/Chaos/DrakathArmorBot.cs
//cs_include Scripts/Chaos/AscendedDrakathGear.cs
//cs_include Scripts/Story/TowerOfDoom.cs
//cs_include Scripts/Nulgath/CoreNulgath.cs
//cs_include Scripts/Story/Artixpointe.cs
//cs_include Scripts/CoreFarms.cs
//cs_include Scripts/CoreDailys.cs
using RBot;

public class HollowbornPaladinAll
{
    public ScriptInterface Bot => ScriptInterface.Instance;

    public CoreBots Core => CoreBots.Instance;
    public ThePostSummoning HBPalPost = new ThePostSummoning();

    public void ScriptMain(ScriptInterface bot)
    {
        Core.SetOptions();
        Bot.Player.LoadBank();

        HBPalPost.GetAll();

        Core.SetOptions(false);
    }
}