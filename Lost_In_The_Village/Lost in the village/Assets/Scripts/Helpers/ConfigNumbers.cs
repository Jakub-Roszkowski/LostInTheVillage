namespace LostInTheVillage.Helpers
{
    public class ConfigNumbers
    {
        public static int DonutRestorHpEasy { get; } = 30;
        public static int DonutRestorHpMedium { get; } = 20;
        public static int DonutRestorHpHard { get; } = 5;

        public static int MineHpEasy { get; } = 5;
        public static int MineHpMedium { get; } = 10;
        public static int MineHpHard { get; } = 20;

        public static float MusicMuteVolume { get; } = 0.3f;

        public static float InteractDistance { get; } = 8f;

        public static float MouseXSensitivity { get; } = 10f;
        public static float MouseYSensitivity { get; } = 10f;
        public static float GamepadXSensitivity { get; } = 95f;
        public static float GamepadYSensitivity { get; } = 95f;
        public static float Speed { get; } = 7f;
        public static float RunSpeed { get; } = 15f;
        public static float Gravity { get; } = -9.8f;
        public static float JumpHeight { get; } = 0.5f;

        public static float EnemyDamageEasy { get; } = 1.5f;
        public static float EnemyDamageMedium { get; } = 5f;
        public static float EnemyDamageHard { get; } = 10f;

        public static int NearDeathHPValue { get; } = 40;
        public static float DefaultMaxHp { get; } = 100f;

        public static float SpottingDistanceNPC_Stupid { get; } = 60f;
        public static float SpottingDistanceNPC_Brain { get; } = 70f;
    }
}
