namespace TimeCalc;

partial class TimerControl
{
    /// <summary> 
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary> 
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
        if(disposing && (components != null))
        {
            components.Dispose();
        }
        base.Dispose(disposing);
    }

    #region Component Designer generated code

    /// <summary> 
    /// Required method for Designer support - do not modify 
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent()
    {
            this.components = new System.ComponentModel.Container();
            this.tbl2 = new System.Windows.Forms.TableLayoutPanel();
            this.lblMins = new System.Windows.Forms.Label();
            this.tbHours = new System.Windows.Forms.TextBox();
            this.dtpInitDate = new System.Windows.Forms.DateTimePicker();
            this.dtpInitTime = new System.Windows.Forms.DateTimePicker();
            this.tbMinutes = new System.Windows.Forms.TextBox();
            this.lblHours = new System.Windows.Forms.Label();
            this.btnStart = new System.Windows.Forms.Button();
            this.timer = new System.Windows.Forms.Timer(this.components);
            this.tbl2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tbl2
            // 
            this.tbl2.ColumnCount = 4;
            this.tbl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl2.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle());
            this.tbl2.Controls.Add(this.lblMins, 3, 2);
            this.tbl2.Controls.Add(this.tbHours, 0, 2);
            this.tbl2.Controls.Add(this.dtpInitDate, 0, 1);
            this.tbl2.Controls.Add(this.dtpInitTime, 2, 1);
            this.tbl2.Controls.Add(this.tbMinutes, 2, 2);
            this.tbl2.Controls.Add(this.lblHours, 1, 2);
            this.tbl2.Controls.Add(this.btnStart, 1, 3);
            this.tbl2.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbl2.Location = new System.Drawing.Point(0, 0);
            this.tbl2.Name = "tbl2";
            this.tbl2.RowCount = 5;
            this.tbl2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 20F));
            this.tbl2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl2.RowStyles.Add(new System.Windows.Forms.RowStyle());
            this.tbl2.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 100F));
            this.tbl2.Size = new System.Drawing.Size(433, 185);
            this.tbl2.TabIndex = 0;
            // 
            // lblMins
            // 
            this.lblMins.Location = new System.Drawing.Point(231, 63);
            this.lblMins.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lblMins.Name = "lblMins";
            this.lblMins.Size = new System.Drawing.Size(51, 22);
            this.lblMins.TabIndex = 18;
            this.lblMins.Text = "mm";
            // 
            // tbHours
            // 
            this.tbHours.Location = new System.Drawing.Point(3, 60);
            this.tbHours.Name = "tbHours";
            this.tbHours.PlaceholderText = "hours";
            this.tbHours.Size = new System.Drawing.Size(84, 31);
            this.tbHours.TabIndex = 15;
            this.tbHours.TextChanged += new System.EventHandler(this.Parameter_Changed);
            // 
            // dtpInitDate
            // 
            this.tbl2.SetColumnSpan(this.dtpInitDate, 2);
            this.dtpInitDate.CustomFormat = "dd.MM.yyyy";
            this.dtpInitDate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInitDate.Location = new System.Drawing.Point(3, 23);
            this.dtpInitDate.Name = "dtpInitDate";
            this.dtpInitDate.Size = new System.Drawing.Size(142, 31);
            this.dtpInitDate.TabIndex = 12;
            this.dtpInitDate.Value = new System.DateTime(2021, 9, 1, 3, 4, 44, 0);
            this.dtpInitDate.ValueChanged += new System.EventHandler(this.Parameter_Changed);
            // 
            // dtpInitTime
            // 
            this.tbl2.SetColumnSpan(this.dtpInitTime, 2);
            this.dtpInitTime.CustomFormat = "HH:mm";
            this.dtpInitTime.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dtpInitTime.Location = new System.Drawing.Point(159, 23);
            this.dtpInitTime.Name = "dtpInitTime";
            this.dtpInitTime.ShowUpDown = true;
            this.dtpInitTime.Size = new System.Drawing.Size(108, 31);
            this.dtpInitTime.TabIndex = 13;
            this.dtpInitTime.ValueChanged += new System.EventHandler(this.Parameter_Changed);
            // 
            // tbMinutes
            // 
            this.tbMinutes.Location = new System.Drawing.Point(159, 60);
            this.tbMinutes.Name = "tbMinutes";
            this.tbMinutes.PlaceholderText = "minutes";
            this.tbMinutes.Size = new System.Drawing.Size(66, 31);
            this.tbMinutes.TabIndex = 16;
            this.tbMinutes.TextChanged += new System.EventHandler(this.Parameter_Changed);
            // 
            // lblHours
            // 
            this.lblHours.Location = new System.Drawing.Point(93, 63);
            this.lblHours.Margin = new System.Windows.Forms.Padding(3, 6, 3, 0);
            this.lblHours.Name = "lblHours";
            this.lblHours.Size = new System.Drawing.Size(60, 22);
            this.lblHours.TabIndex = 17;
            this.lblHours.Text = "HH";
            // 
            // btnStart
            // 
            this.tbl2.SetColumnSpan(this.btnStart, 3);
            this.btnStart.Location = new System.Drawing.Point(93, 97);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(146, 34);
            this.btnStart.TabIndex = 19;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // timer
            // 
            this.timer.Tick += new System.EventHandler(this.timer_Tick);
            // 
            // TimerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.tbl2);
            this.Name = "TimerControl";
            this.Size = new System.Drawing.Size(433, 185);
            this.tbl2.ResumeLayout(false);
            this.tbl2.PerformLayout();
            this.ResumeLayout(false);

    }

    #endregion

    private TableLayoutPanel tbl2;
    private DateTimePicker dtpInitDate;
    private DateTimePicker dtpInitTime;
    private TextBox tbHours;
    private TextBox tbMinutes;
    private Label lblMins;
    private Label lblHours;
    private Button btnStart;
    private System.Windows.Forms.Timer timer;
}
