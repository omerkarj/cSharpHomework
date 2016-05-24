namespace B16_Ex03_Yoav_304953128_Omer_201566676
{
    public class ElectricEnergySystem : EnergySystem
    {
        public ElectricEnergySystem(float i_MaxFillAmount) : base(i_MaxFillAmount) {}

        public void ChargeBattery(float i_HoursToCharge)
        {
            bool validChargeTime = m_CurrentFillAmount + i_HoursToCharge <= m_MaxFillAmount;

            if (validChargeTime)
            {
                m_CurrentFillAmount += i_HoursToCharge;
            }
            else
            {
                throw new ValueOutOfRangeException();
            }
        } 
    }
}