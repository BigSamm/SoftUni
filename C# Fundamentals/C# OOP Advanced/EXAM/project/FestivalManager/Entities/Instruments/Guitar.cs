namespace FestivalManager.Entities.Instruments
{
    public class Guitar : Instrument
    {
        private const int RepairAmountConst = 60;

        public Guitar()
            : base()
        {

        }

        protected override int RepairAmount => RepairAmountConst;
    }
}
