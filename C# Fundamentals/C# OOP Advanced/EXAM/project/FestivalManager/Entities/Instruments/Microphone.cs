namespace FestivalManager.Entities.Instruments
{
    public class Microphone : Instrument
    {
        private const int RepairAmountConst = 80;

        public Microphone()
            : base()
        {

        }

        protected override int RepairAmount => RepairAmountConst;
    }
}
