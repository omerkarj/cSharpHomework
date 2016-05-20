namespace B16_Ex03_Yoav_304953128_Omer_201566676
{
    public class Wheel
    {
        private string m_Manufacturer;
        private float m_CurrentAirPressure;
        private float m_MaxAirPressure;

        public void Inflate(float i_Amount)
        {
            if (m_CurrentAirPressure + i_Amount <= m_MaxAirPressure)
            {
                m_CurrentAirPressure += i_Amount;
            }
            else
            {
                throw new ValueOutOfRangeException();
            }
        }
    }
}