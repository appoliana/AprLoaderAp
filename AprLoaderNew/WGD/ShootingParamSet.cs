namespace AprLoader.Models
{
    public struct ShootingParamSet
    {
        public void Update(bool? isGraphy, bool? isSerialGraphy, bool? isScopy, bool? isHdScopy, bool? isTomoSynt, bool? isTomo)
        {
            IsGraphy = isGraphy;
            IsSerialGraphy = isSerialGraphy;
            IsScopy = isScopy;
            IsHdScopy = isHdScopy;
            IsTomoSynt = isTomoSynt;
            IsTomo = isTomo;
        }

        public bool? IsGraphy { get; private set; }
        public bool? IsSerialGraphy { get; private set; }
        public bool? IsScopy { get; private set; }
        public bool? IsHdScopy { get; private set; }
        public bool? IsTomoSynt { get; private set; }
        public bool? IsTomo { get; private set; }
    }
}
