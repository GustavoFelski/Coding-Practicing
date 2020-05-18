namespace RPGzinho.Character
{
    public interface ICharacter
    {
        string ClasseUpdate { get; set; }
        double CriticalChanceUpdate { get; set; }
        double DamageUpdate { get; set; }
        double LifeUpdate { get; set; }
        int MagicPointsUpdate { get; set; }
        string NameUpdate { get; set; }
        int PotionsUpdate { get; set; }
        double ResistenceUpdate { get; set; }
        int SpeedUpdate { get; set; }
    }
}