namespace B16_Ex03_Yoav_304953128_Omer_201566676
{
    public class Car : Vehicle
    {
        protected ePaintColor m_PaintColor;
        protected readonly eCarDoorsNumber m_NumOfDoors;

        public ePaintColor PaintColor
        {
            get { return m_PaintColor; }
            set { m_PaintColor = value; }
        }

        public eCarDoorsNumber NumOfDoors
        {
            get { return m_NumOfDoors; }
        }

        protected Car(string i_ModelName, string i_LicenseNumber, eCarDoorsNumber i_NumOfDoors)
            : base(i_ModelName, i_LicenseNumber)
        {
            m_NumOfDoors = i_NumOfDoors;
        }
    }
}