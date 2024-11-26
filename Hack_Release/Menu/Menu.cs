using UnityEngine;

public class Menu : MonoBehaviour
{
    private static Rect windowRect = new Rect(Screen.width / 2 - 200, Screen.height / 2 - 150, 400, 300);
    private static string title = "Simmoni Solution Devblogs";

    private static int selectedTab = 0;

    public static void OnGUI()
    {
        // Draw the main window
        windowRect = GUI.Window(0, windowRect, DrawWindow, title);
    }

    private static void DrawWindow(int id)
    {
        // Draw the title bar
        GUI.Label(new Rect(10, 5, 100, 20), title, GUI.skin.label);

        // Draw the tabs
        if (GUI.Button(new Rect(10, 30, 80, 20), "ESP"))
        {
            selectedTab = 0;
        }
        if (GUI.Button(new Rect(100, 30, 80, 20), "Misc"))
        {
            selectedTab = 1;
        }
        if (GUI.Button(new Rect(190, 30, 80, 20), "Aimbot"))
        {
            selectedTab = 2;
        }

        // Draw the tab content
        switch (selectedTab)
        {
            case 0:
                DrawESPTab();
                break;
            case 1:
                DrawMiscTab();
                break;
            case 2:
                DrawAimbotTab();
                break;
        }

        // Draw the drag window button
        GUI.DragWindow(new Rect(0, 0, 10000, 20));
    }

    private static void DrawESPTab()
    {
        // Draw ESP options
        Settings.togglePlayers = GUI.Toggle(new Rect(10, 60, 120, 20), Settings.togglePlayers, " Players: ");
       // Settings.toggleSkeleton = GUI.Toggle(new Rect(10, 60, 120, 20), Settings.togglePlayers, " Skeleton: ");
        Settings.playersDistance = (int)GUI.HorizontalSlider(new Rect(135, 64, 100, 12f), Settings.playersDistance, 0f, 1000f);

        Settings.toggleSleepers = GUI.Toggle(new Rect(10, 85, 120, 20), Settings.toggleSleepers, " Sleepers: ");
        Settings.sleepersDistance = (int)GUI.HorizontalSlider(new Rect(135, 89, 100, 12f), Settings.sleepersDistance, 0f, 1000f);

        Settings.toggleResources = GUI.Toggle(new Rect(10, 110, 120, 20), Settings.toggleResources, " Resources: ");
        Settings.resourcesDistance = (int)GUI.HorizontalSlider(new Rect(135, 114, 100, 12f), Settings.resourcesDistance, 0f, 1000f);

        Settings.toggleAnimals = GUI.Toggle(new Rect(10, 135, 120, 20), Settings.toggleAnimals, " Animals: ");
        Settings.animalsDistance = (int)GUI.HorizontalSlider(new Rect(135, 139, 100, 12f), Settings.animalsDistance, 0f, 1000f);

        Settings.toggleLoot = GUI.Toggle(new Rect(10, 160, 120, 20), Settings.toggleLoot, " Loot: ");
        Settings.lootDistance = (int)GUI.HorizontalSlider(new Rect(135, 164, 100, 12f), Settings.lootDistance, 0f, 1000f);
        Settings.toggleHealth = GUI.Toggle(new Rect(10, 185, 120, 20), Settings.toggleHealth, " Health Bar");
    }

    private static void DrawMiscTab()
    {
        // Draw Misc options
        Settings.toggleCrosshair = GUI.Toggle(new Rect(10, 60, 130, 20), Settings.toggleCrosshair, " Crosshair");
        Settings.toggleLight = GUI.Toggle(new Rect(10, 85, 130, 20), Settings.toggleLight, " Light");
        Settings.toggleNoRecoil = GUI.Toggle(new Rect(10, 110, 130, 20), Settings.toggleNoRecoil, " No Recoil");
        Settings.toggleNoSway = GUI.Toggle(new Rect(10, 135, 130, 20), Settings.toggleNoSway, " No Sway");
        Settings.toggleNoSpread = GUI.Toggle(new Rect(10, 160, 130, 20), Settings.toggleNoSpread, " No Spread");
        Settings.toggleAutomatic = GUI.Toggle(new Rect(10, 185, 130, 20), Settings.toggleAutomatic, " Automatic");
        Settings.toggleNoGrass = GUI.Toggle(new Rect(10, 210, 130, 20), Settings.toggleNoGrass, " No Grass");
    }

    private static void DrawAimbotTab()
    {
        // Draw Aimbot options
        GUI.Label(new Rect(10, 60, 130, 20), "SuperJump");
        Settings.gravityMultiplier = GUI.HorizontalSlider(new Rect(10, 84, 130, 12f), Settings.gravityMultiplier, 2.5f, 0.2f);

        GUI.Label(new Rect(10, 105, 130, 20), "SpeedHack");
        Settings.speedScale = GUI.HorizontalSlider(new Rect(10, 129, 130, 12f), Settings.speedScale, 1.002804f, 1.8f);

        Settings.toggleAimbot = GUI.Toggle(new Rect(10, 150, 130, 20), Settings.toggleAimbot, " Aimbot(X)");
        Settings.toggleVisibleCheck = GUI.Toggle(new Rect(10, 175, 130, 20), Settings.toggleVisibleCheck, " Visible Check");
    }
}
