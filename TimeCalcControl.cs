using Microsoft.VisualBasic.Devices;

namespace TimeCalc;

public partial class TimeCalcControl : UserControl
{
    private bool _lock = false;
    private DateTime _init;
    private DateTime _result;

    private DateTime Init
    {
        get => _init;
        set
        {
            _init = value;
            _lock = true;
            dtpInitDate.Value = value;
            dtpInitTime.Value = value;
            _lock = false;
        }
    }
    private DateTime Result
    {
        get => _result;
        set
        {
            _result = value;
            _lock = true;
            dtpResultDate.Value = value;
            dtpResultTime.Value = value;
            _lock = false;
        }
    }

    public TimeCalcControl()
    {
        InitializeComponent();
        Init = DateTime.Now;
        Result = DateTime.Now;
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
