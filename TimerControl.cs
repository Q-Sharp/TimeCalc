namespace TimeCalc;

public partial class TimerControl : UserControl
{
    private DateTime _init;
    private DateTime _timerEnd;

    private DateTime Init
    {
        get => _init;
        set
        {
            _init = value;
            dtpInitDate.Value = value;
            dtpInitTime.Value = value;
        }
    }

    public TimerControl()
    {
        InitializeComponent();
        Init = DateTime.Now;
    }

    private void Parameter_Changed(object sender, EventArgs e)
    {
        if(sender is DateTimePicker dtp)
        {
            if(dtp == dtpInitDate || dtp == dtpInitTime)
                Init = dtp.Value;
        }
    }

    private void btnStart_Click(object sender, EventArgs e)
    {
        if(timer.Enabled)
        {
            StopTimer();
        }
        else
        {
           StartTimer();
        }
    }

    private void StartTimer()
    {
        _timerEnd = Init;

        if(int.TryParse(tbHours.Text, out var parsedHours))
            _timerEnd = _timerEnd.AddHours(parsedHours);

        if(int.TryParse(tbMinutes.Text, out var parsedMins))
            _timerEnd = _timerEnd.AddMinutes(parsedMins);

        timer.Start();
    }

    private void StopTimer()
    {
        timer.Stop();
        btnStart.Text = "Start";
    }

    private void timer_Tick(object sender, EventArgs e)
    {
        var timeLeft = _timerEnd - DateTime.Now;

        btnStart.Text = timeLeft.ToString();

        if(timeLeft.TotalNanoseconds <= 0)
        {
            Task.Run(async () =>
            {
                var simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
                while(btnStart.Text != "Start")
                {
                    simpleSound.Play();
                    await Task.Delay(TimeSpan.FromSeconds(10));
                }
            });
        }
    }
}
