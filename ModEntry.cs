using StardewModdingAPI;
using StardewValley;

namespace FreezeTimeinEvents
{
    public class ModEntry : Mod
    {
        public override void Entry(IModHelper helper)
        {
            // Subscribe to game loop events
            Helper.Events.GameLoop.UpdateTicked += OnUpdateTicked;
        }

        private void OnUpdateTicked(object? sender, StardewModdingAPI.Events.UpdateTickedEventArgs e)
        {
            // Check if an event (cutscene) is active
            if (Game1.eventUp)
            {
                Game1.isTimePaused = true; // Freeze time during events
            }
            else
            {
                Game1.isTimePaused = false; // Unfreeze time when no event is active
            }
        }
    }
}
