namespace B16_Ex03_Yoav_304953128_Omer_201566676
{
    public abstract class EnergySystem
    {
        protected readonly float m_MaxFillAmount;
        protected float m_CurrentFillAmount;

        public float MaxFillAmount
        {
            get { return m_MaxFillAmount; }
        }

        public float CurrentFillAmount
        {
            get { return m_CurrentFillAmount; }
            set { m_CurrentFillAmount = value; }
        }

        protected EnergySystem(float i_MaxFillAmount)
        {
            m_MaxFillAmount = i_MaxFillAmount;
        }
    }
}