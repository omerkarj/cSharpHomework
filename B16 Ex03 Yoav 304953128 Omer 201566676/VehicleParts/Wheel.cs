namespace B16_Ex03_Yoav_304953128_Omer_201566676
{
    public class Wheel
    {
        private readonly string m_Manufacturer;
        private readonly float m_MaxAirPressure;
        private float m_CurrentAirPressure;

        public string Manufacturer
        {
            get { return m_Manufacturer; }
        }

        public float MaxAirPressure
        {
            get { return m_MaxAirPressure; }
        }

        public float CurrentAirPressure
        {
            get { return m_CurrentAirPressure; }
            set { m_CurrentAirPressure = value; }
        }

        public Wheel(string i_Manufacturer, float i_MaxAirPressure)
        {
            m_Manufacturer = i_Manufacturer;
            m_MaxAirPressure = i_MaxAirPressure;
        }

        public void Inflate(float i_InflateAmount)
        {
            bool validInflateAmount = m_CurrentAirPressure + i_InflateAmount <= m_MaxAirPressure;
            
            if (validInflateAmount)
            {
                m_CurrentAirPressure += i_InflateAmount;
            }
            else
            {
                throw new ValueOutOfRangeException();
            }
        }
    }
}