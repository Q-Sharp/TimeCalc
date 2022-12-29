namespace TimeCalc;

public partial class TimeCalcControl : UserControl
{
    private bool _lock = false;
    private DateTime _init = DateTime.Now;
    private DateTime _result = DateTime.Now;

    public DateTime Init
    {
        get => _init;
        set
        {
            _init = value;
            dtpInitDate.Value = value;
            dtpInitTime.Value = value;
        }
    }
    public DateTime Result
    {
        get => _result;
        set
        {
            _result = value;
            dtpResultDate.Value = value;
            dtpResultTime.Value = value;
        }
    }

    public TimeCalcControl()
    {
        InitializeComponent();

        dtpInitDate.Value = dtpInitTime.Value = Init;
        dtpResultDate.Value = dtpResultTime.Value = Result;
    }

    private void Parameter_Changed(object sender, EventArgs e)
    {
        if(_lock)
            return;

        _lock = true;
        if(sender == tbHours || sender == tbMinutes)
        {
            var init = Init;

            if(int.TryParse(tbHours.Text, out var parsedHours))
                init = init.AddHours(parsedHours);

            if(int.TryParse(tbMinutes.Text, out var parsedMins))
                init = init.AddMinutes(parsedMins);

            Result = init;
        }

        if(sender is DateTimePicker dtp)
        {
            if(dtp == dtpInitDate || dtp == dtpInitTime)
                Init = dtp.Value;

            if(dtp == dtpResultDate || dtp == dtpResultTime)
                Result = dtp.Value;

            var result = Init - Result;

            tbHours.Text = ((int)Math.Abs(result.TotalHours)).ToString();
            tbMinutes.Text = Math.Abs(result.Minutes).ToString();
        }
        _lock = false;
    }
}
