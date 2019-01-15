namespace FestivalManager.Entities.Instruments
{
    public class Bass : Instrument
    {
	    private int RepairAmountConst = 80;

        public Bass()
            : base()
        {

        }

	    protected override int RepairAmount => RepairAmountConst;
    }
}
