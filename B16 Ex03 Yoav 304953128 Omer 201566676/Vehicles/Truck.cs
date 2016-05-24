namespace B16_Ex03_Yoav_304953128_Omer_201566676
{
    public class Truck : Vehicle
    {
        private bool m_DangerousCargo;
        private float m_MaxCargoWeight;

        public bool DangerousCargo
        {
            get { return m_DangerousCargo; }
            set { m_DangerousCargo = value; }
        }

        public float MaxCargoWeight
        {
            get { return m_MaxCargoWeight; }
            set { m_MaxCargoWeight = value; }
        }

        public Truck(string i_ModelName, string i_LicenseNumber) 
            : base(i_ModelName, i_LicenseNumber) {}
    }
}