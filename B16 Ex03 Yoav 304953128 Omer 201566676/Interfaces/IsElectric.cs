namespace B16_Ex03_Yoav_304953128_Omer_201566676
{
    public interface IsElectric
    {
        float BateryHoursLeft { get; set; }
        float MaxBateryHours { get; set; }
        void ChargeBattery(int i_HoursToCharge);
    }
}